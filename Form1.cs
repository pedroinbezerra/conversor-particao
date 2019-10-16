using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Conversor_de_partição
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Executa o diskpart recebendo uma variáveis do tipo string como comando.
        // Logo após executa o diskpart com o comando passado atribuí o retorno
        // a uma variável (output)
        private String Diskpart(String comando1, String comando2 = "", String comando3 = "")
        {
            Process process = new Process();
            process.StartInfo.FileName = "diskpart.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            process.StandardInput.WriteLine(comando1);
            process.StandardInput.WriteLine(comando2);
            process.StandardInput.WriteLine(comando3);
            process.StandardInput.WriteLine("exit");
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return output;
        }

        public void ListaDrivers()
        {
            // Executa o diskpart e o comando listdisk e logo após isso atribuí
            // o resultado a uma variável output
            var listdisk = Diskpart("list disk");

            // Extrai as informações da variável output
            string table = listdisk.Split(new string[] { "DISKPART>" }, StringSplitOptions.None)[1];
            var rows = table.Split(new string[] { "\n" }, StringSplitOptions.None);
            for (int i = 3; i < rows.Length; i++)
            {

                if (rows[i].Contains("Disco"))
                {
                    int index = Int32.Parse(rows[i].Split(new string[] { " " }, StringSplitOptions.None)[3]);
                    listBoxDiscos.Items.Add($@"Disco {index}");
                }
            }

            buttonAtualizar.Enabled = true;
            radioButtonGPT.Checked = false;
            radioButtonMBR.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaDrivers();
            On_Off_Convert_Button.Start();
        }

        private void ButtonAtualizar_Click(object sender, EventArgs e)
        {
            buttonAtualizar.Enabled = false;
            listBoxDiscos.Items.Clear();
            ListaDrivers();
        }

        private void ButtonConverter_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show("Ao clicar em OK todos os dados contidos no disco selecionado serão" +
                " apagados. Prosseguir?", "", MessageBoxButtons.OKCancel);

            if (confirmacao.ToString()=="OK")
            {
                try
                {
                    String volume = (listBoxDiscos.SelectedItem.ToString().Split(new Char[] { ' ' })[1]);

                    //listBoxDiscos.Items.Add(listBoxDiscos.SelectedItem.ToString().Split(new Char[] { ' ' })[1]);

                    String tipo = "";

                    if (radioButtonGPT.Checked)
                    {
                        tipo = "GPT";
                    }
                    else if (radioButtonMBR.Checked)
                    {
                        tipo = "MBR";
                    }

                    String comando1 = "select disk " + volume;
                    String comando2 = "clean";
                    String comando3 = "convert " + tipo;

                    String retorno = Diskpart(comando1, comando2, comando3);

                    MessageBox.Show("Partição de inicialização convertida com sucesso!");



                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao converter a partição de inicialização.");

                };
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(listBoxDiscos.SelectedItems.Count == 0 || radioButtonMBR.Checked == false && radioButtonGPT.Checked == false)
            {
                buttonConverter.Enabled = false;
            }
            else
            {
                buttonConverter.Enabled = true;
            }
        }
    }
}
