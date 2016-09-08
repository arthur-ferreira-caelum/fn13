namespace OiMundo
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
            this.button1 = new System.Windows.Forms.Button();
            this.exercicio351 = new System.Windows.Forms.Button();
            this.exercicio352 = new System.Windows.Forms.Button();
            this.exercicio353 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exercicio351
            // 
            this.exercicio351.Location = new System.Drawing.Point(13, 42);
            this.exercicio351.Name = "exercicio351";
            this.exercicio351.Size = new System.Drawing.Size(146, 23);
            this.exercicio351.TabIndex = 1;
            this.exercicio351.Text = "Exercício 3.5.1";
            this.exercicio351.UseVisualStyleBackColor = true;
            this.exercicio351.Click += new System.EventHandler(this.exercicio351_Click);
            // 
            // exercicio352
            // 
            this.exercicio352.Location = new System.Drawing.Point(13, 71);
            this.exercicio352.Name = "exercicio352";
            this.exercicio352.Size = new System.Drawing.Size(146, 23);
            this.exercicio352.TabIndex = 2;
            this.exercicio352.Text = "Exercício 3.5.2";
            this.exercicio352.UseVisualStyleBackColor = true;
            this.exercicio352.Click += new System.EventHandler(this.exercicio352_Click);
            // 
            // exercicio353
            // 
            this.exercicio353.Location = new System.Drawing.Point(13, 100);
            this.exercicio353.Name = "exercicio353";
            this.exercicio353.Size = new System.Drawing.Size(146, 23);
            this.exercicio353.TabIndex = 3;
            this.exercicio353.Text = "Exercício 3.5.3";
            this.exercicio353.UseVisualStyleBackColor = true;
            this.exercicio353.Click += new System.EventHandler(this.exercicio353_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 511);
            this.Controls.Add(this.exercicio353);
            this.Controls.Add(this.exercicio352);
            this.Controls.Add(this.exercicio351);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exercicio351;
        private System.Windows.Forms.Button exercicio352;
        private System.Windows.Forms.Button exercicio353;
    }
}

