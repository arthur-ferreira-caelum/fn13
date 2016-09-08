namespace Caelum.EditorDeTexto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoConteudo = new System.Windows.Forms.TextBox();
            this.botaoGrava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoConteudo
            // 
            this.textoConteudo.Location = new System.Drawing.Point(12, 19);
            this.textoConteudo.Multiline = true;
            this.textoConteudo.Name = "textoConteudo";
            this.textoConteudo.Size = new System.Drawing.Size(538, 290);
            this.textoConteudo.TabIndex = 0;
            // 
            // botaoGrava
            // 
            this.botaoGrava.Location = new System.Drawing.Point(12, 315);
            this.botaoGrava.Name = "botaoGrava";
            this.botaoGrava.Size = new System.Drawing.Size(86, 35);
            this.botaoGrava.TabIndex = 1;
            this.botaoGrava.Text = "Grava";
            this.botaoGrava.UseVisualStyleBackColor = true;
            this.botaoGrava.Click += new System.EventHandler(this.botaoGrava_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 362);
            this.Controls.Add(this.botaoGrava);
            this.Controls.Add(this.textoConteudo);
            this.Name = "Form1";
            this.Text = "Editor De Texto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoConteudo;
        private System.Windows.Forms.Button botaoGrava;
    }
}

