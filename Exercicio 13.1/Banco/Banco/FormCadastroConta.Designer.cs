namespace Banco
{
    partial class FormCadastroConta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.botaoCadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titular: ";
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(84, 52);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(161, 22);
            this.textoNumero.TabIndex = 2;
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(84, 80);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(161, 22);
            this.textoTitular.TabIndex = 3;
            // 
            // botaoCadastrar
            // 
            this.botaoCadastrar.Location = new System.Drawing.Point(147, 109);
            this.botaoCadastrar.Name = "botaoCadastrar";
            this.botaoCadastrar.Size = new System.Drawing.Size(97, 27);
            this.botaoCadastrar.TabIndex = 4;
            this.botaoCadastrar.Text = "Cadastrar";
            this.botaoCadastrar.UseVisualStyleBackColor = true;
            this.botaoCadastrar.Click += new System.EventHandler(this.botaoCadastrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo:";
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(84, 22);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(161, 24);
            this.comboTipo.TabIndex = 6;
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 197);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botaoCadastrar);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastroConta";
            this.Text = "Nova Conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Button botaoCadastrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboTipo;
    }
}