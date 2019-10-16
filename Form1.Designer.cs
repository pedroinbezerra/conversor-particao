namespace Conversor_de_partição
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxDiscos = new System.Windows.Forms.ListBox();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.radioButtonMBR = new System.Windows.Forms.RadioButton();
            this.radioButtonGPT = new System.Windows.Forms.RadioButton();
            this.buttonConverter = new System.Windows.Forms.Button();
            this.On_Off_Convert_Button = new System.Windows.Forms.Timer(this.components);
            this.labelDiscos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxDiscos
            // 
            this.listBoxDiscos.FormattingEnabled = true;
            this.listBoxDiscos.HorizontalScrollbar = true;
            this.listBoxDiscos.Location = new System.Drawing.Point(40, 31);
            this.listBoxDiscos.Name = "listBoxDiscos";
            this.listBoxDiscos.Size = new System.Drawing.Size(117, 82);
            this.listBoxDiscos.TabIndex = 0;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(40, 143);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizar.TabIndex = 1;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.ButtonAtualizar_Click);
            // 
            // radioButtonMBR
            // 
            this.radioButtonMBR.AutoSize = true;
            this.radioButtonMBR.Location = new System.Drawing.Point(206, 31);
            this.radioButtonMBR.Name = "radioButtonMBR";
            this.radioButtonMBR.Size = new System.Drawing.Size(49, 17);
            this.radioButtonMBR.TabIndex = 2;
            this.radioButtonMBR.TabStop = true;
            this.radioButtonMBR.Text = "MBR";
            this.radioButtonMBR.UseVisualStyleBackColor = true;
            // 
            // radioButtonGPT
            // 
            this.radioButtonGPT.AutoSize = true;
            this.radioButtonGPT.Location = new System.Drawing.Point(206, 74);
            this.radioButtonGPT.Name = "radioButtonGPT";
            this.radioButtonGPT.Size = new System.Drawing.Size(47, 17);
            this.radioButtonGPT.TabIndex = 3;
            this.radioButtonGPT.TabStop = true;
            this.radioButtonGPT.Text = "GPT";
            this.radioButtonGPT.UseVisualStyleBackColor = true;
            // 
            // buttonConverter
            // 
            this.buttonConverter.Location = new System.Drawing.Point(159, 143);
            this.buttonConverter.Name = "buttonConverter";
            this.buttonConverter.Size = new System.Drawing.Size(75, 23);
            this.buttonConverter.TabIndex = 4;
            this.buttonConverter.Text = "Converter";
            this.buttonConverter.UseVisualStyleBackColor = true;
            this.buttonConverter.Click += new System.EventHandler(this.ButtonConverter_Click);
            // 
            // On_Off_Convert_Button
            // 
            this.On_Off_Convert_Button.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // labelDiscos
            // 
            this.labelDiscos.AutoSize = true;
            this.labelDiscos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscos.Location = new System.Drawing.Point(37, 9);
            this.labelDiscos.Name = "labelDiscos";
            this.labelDiscos.Size = new System.Drawing.Size(49, 13);
            this.labelDiscos.TabIndex = 5;
            this.labelDiscos.Text = "Discos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 204);
            this.Controls.Add(this.labelDiscos);
            this.Controls.Add(this.buttonConverter);
            this.Controls.Add(this.radioButtonGPT);
            this.Controls.Add(this.radioButtonMBR);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.listBoxDiscos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de inicialização";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxDiscos;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.RadioButton radioButtonMBR;
        private System.Windows.Forms.RadioButton radioButtonGPT;
        private System.Windows.Forms.Button buttonConverter;
        private System.Windows.Forms.Timer On_Off_Convert_Button;
        private System.Windows.Forms.Label labelDiscos;
    }
}

