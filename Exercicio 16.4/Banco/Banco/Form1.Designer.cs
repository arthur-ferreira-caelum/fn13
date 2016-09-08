namespace Banco
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botaoNovaConta = new System.Windows.Forms.Button();
            this.comboDestino = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.botaoDeposita = new System.Windows.Forms.Button();
            this.botaoSaca = new System.Windows.Forms.Button();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botaoImpostos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botaoImpostos);
            this.groupBox1.Controls.Add(this.botaoNovaConta);
            this.groupBox1.Controls.Add(this.comboDestino);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.botaoDeposita);
            this.groupBox1.Controls.Add(this.botaoSaca);
            this.groupBox1.Controls.Add(this.textoValor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textoSaldo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textoNumero);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textoTitular);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // botaoNovaConta
            // 
            this.botaoNovaConta.Location = new System.Drawing.Point(10, 239);
            this.botaoNovaConta.Name = "botaoNovaConta";
            this.botaoNovaConta.Size = new System.Drawing.Size(117, 32);
            this.botaoNovaConta.TabIndex = 11;
            this.botaoNovaConta.Text = "Nova Conta";
            this.botaoNovaConta.UseVisualStyleBackColor = true;
            this.botaoNovaConta.Click += new System.EventHandler(this.botaoNovaConta_Click);
            // 
            // comboDestino
            // 
            this.comboDestino.FormattingEnabled = true;
            this.comboDestino.Location = new System.Drawing.Point(173, 186);
            this.comboDestino.Name = "comboDestino";
            this.comboDestino.Size = new System.Drawing.Size(190, 24);
            this.comboDestino.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Transfere";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.botaoTransfere_Click);
            // 
            // botaoDeposita
            // 
            this.botaoDeposita.Location = new System.Drawing.Point(174, 146);
            this.botaoDeposita.Name = "botaoDeposita";
            this.botaoDeposita.Size = new System.Drawing.Size(92, 30);
            this.botaoDeposita.TabIndex = 9;
            this.botaoDeposita.Text = "Deposita";
            this.botaoDeposita.UseVisualStyleBackColor = true;
            this.botaoDeposita.Click += new System.EventHandler(this.botaoDeposita_Click);
            // 
            // botaoSaca
            // 
            this.botaoSaca.Location = new System.Drawing.Point(75, 146);
            this.botaoSaca.Name = "botaoSaca";
            this.botaoSaca.Size = new System.Drawing.Size(93, 30);
            this.botaoSaca.TabIndex = 8;
            this.botaoSaca.Text = "Saca";
            this.botaoSaca.UseVisualStyleBackColor = true;
            this.botaoSaca.Click += new System.EventHandler(this.botaoSaca_Click);
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(75, 117);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(100, 22);
            this.textoValor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor:";
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(75, 89);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(100, 22);
            this.textoSaldo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo:";
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(75, 61);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 22);
            this.textoNumero.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número:";
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(75, 33);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 22);
            this.textoTitular.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titular:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboContas);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busca Conta";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(129, 32);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(190, 24);
            this.comboContas.TabIndex = 1;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Escolha a Conta:";
            // 
            // botaoImpostos
            // 
            this.botaoImpostos.Location = new System.Drawing.Point(133, 239);
            this.botaoImpostos.Name = "botaoImpostos";
            this.botaoImpostos.Size = new System.Drawing.Size(120, 32);
            this.botaoImpostos.TabIndex = 2;
            this.botaoImpostos.Text = "Impostos";
            this.botaoImpostos.UseVisualStyleBackColor = true;
            this.botaoImpostos.Click += new System.EventHandler(this.botaoImpostos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 380);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Caixa Eletrônico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoDeposita;
        private System.Windows.Forms.Button botaoSaca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.ComboBox comboDestino;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botaoNovaConta;
        private System.Windows.Forms.Button botaoImpostos;
    }
}

