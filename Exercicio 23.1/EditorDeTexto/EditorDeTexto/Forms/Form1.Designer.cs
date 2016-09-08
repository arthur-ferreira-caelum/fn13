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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textoSubstituto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoBusca = new System.Windows.Forms.Button();
            this.botaoSubstituir = new System.Windows.Forms.Button();
            this.textoBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoMaiusculas = new System.Windows.Forms.Button();
            this.botaoMinusculas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoConteudo
            // 
            this.textoConteudo.Location = new System.Drawing.Point(12, 19);
            this.textoConteudo.Multiline = true;
            this.textoConteudo.Name = "textoConteudo";
            this.textoConteudo.Size = new System.Drawing.Size(538, 186);
            this.textoConteudo.TabIndex = 0;
            // 
            // botaoGrava
            // 
            this.botaoGrava.Location = new System.Drawing.Point(12, 354);
            this.botaoGrava.Name = "botaoGrava";
            this.botaoGrava.Size = new System.Drawing.Size(86, 35);
            this.botaoGrava.TabIndex = 1;
            this.botaoGrava.Text = "Grava";
            this.botaoGrava.UseVisualStyleBackColor = true;
            this.botaoGrava.Click += new System.EventHandler(this.botaoGrava_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textoSubstituto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.botaoBusca);
            this.groupBox1.Controls.Add(this.botaoSubstituir);
            this.groupBox1.Controls.Add(this.textoBusca);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(212, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 178);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar e Substituir";
            // 
            // textoSubstituto
            // 
            this.textoSubstituto.Location = new System.Drawing.Point(84, 110);
            this.textoSubstituto.Name = "textoSubstituto";
            this.textoSubstituto.Size = new System.Drawing.Size(248, 22);
            this.textoSubstituto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Substituir:";
            // 
            // botaoBusca
            // 
            this.botaoBusca.Location = new System.Drawing.Point(9, 64);
            this.botaoBusca.Name = "botaoBusca";
            this.botaoBusca.Size = new System.Drawing.Size(97, 32);
            this.botaoBusca.TabIndex = 3;
            this.botaoBusca.Text = "Buscar";
            this.botaoBusca.UseVisualStyleBackColor = true;
            this.botaoBusca.Click += new System.EventHandler(this.botaoBusca_Click);
            // 
            // botaoSubstituir
            // 
            this.botaoSubstituir.Location = new System.Drawing.Point(9, 138);
            this.botaoSubstituir.Name = "botaoSubstituir";
            this.botaoSubstituir.Size = new System.Drawing.Size(94, 32);
            this.botaoSubstituir.TabIndex = 2;
            this.botaoSubstituir.Text = "Substituir";
            this.botaoSubstituir.UseVisualStyleBackColor = true;
            this.botaoSubstituir.Click += new System.EventHandler(this.botaoSubstituir_Click);
            // 
            // textoBusca
            // 
            this.textoBusca.Location = new System.Drawing.Point(65, 36);
            this.textoBusca.Name = "textoBusca";
            this.textoBusca.Size = new System.Drawing.Size(267, 22);
            this.textoBusca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // botaoMaiusculas
            // 
            this.botaoMaiusculas.Location = new System.Drawing.Point(13, 212);
            this.botaoMaiusculas.Name = "botaoMaiusculas";
            this.botaoMaiusculas.Size = new System.Drawing.Size(127, 36);
            this.botaoMaiusculas.TabIndex = 3;
            this.botaoMaiusculas.Text = "MAIÚSCULAS";
            this.botaoMaiusculas.UseVisualStyleBackColor = true;
            this.botaoMaiusculas.Click += new System.EventHandler(this.botaoMaiusculas_Click);
            // 
            // botaoMinusculas
            // 
            this.botaoMinusculas.Location = new System.Drawing.Point(13, 255);
            this.botaoMinusculas.Name = "botaoMinusculas";
            this.botaoMinusculas.Size = new System.Drawing.Size(127, 36);
            this.botaoMinusculas.TabIndex = 4;
            this.botaoMinusculas.Text = "minúsculas";
            this.botaoMinusculas.UseVisualStyleBackColor = true;
            this.botaoMinusculas.Click += new System.EventHandler(this.botaoMinusculas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 395);
            this.Controls.Add(this.botaoMinusculas);
            this.Controls.Add(this.botaoMaiusculas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botaoGrava);
            this.Controls.Add(this.textoConteudo);
            this.Name = "Form1";
            this.Text = "Editor De Texto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoConteudo;
        private System.Windows.Forms.Button botaoGrava;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botaoBusca;
        private System.Windows.Forms.Button botaoSubstituir;
        private System.Windows.Forms.TextBox textoBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoSubstituto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botaoMaiusculas;
        private System.Windows.Forms.Button botaoMinusculas;
    }
}

