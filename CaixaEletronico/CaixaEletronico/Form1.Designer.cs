namespace CaixaEletronico
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
            this.btnContaCorrente = new System.Windows.Forms.Button();
            this.Tela = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Tela2 = new System.Windows.Forms.RichTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnContaPoupança = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnContaCorrente
            // 
            this.btnContaCorrente.Location = new System.Drawing.Point(50, 12);
            this.btnContaCorrente.Name = "btnContaCorrente";
            this.btnContaCorrente.Size = new System.Drawing.Size(140, 23);
            this.btnContaCorrente.TabIndex = 0;
            this.btnContaCorrente.Text = "Criar Conta Corrente";
            this.btnContaCorrente.UseVisualStyleBackColor = true;
            this.btnContaCorrente.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tela
            // 
            this.Tela.Location = new System.Drawing.Point(196, 5);
            this.Tela.Name = "Tela";
            this.Tela.Size = new System.Drawing.Size(201, 329);
            this.Tela.TabIndex = 1;
            this.Tela.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Nome";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(50, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Saldo";
            // 
            // Tela2
            // 
            this.Tela2.Location = new System.Drawing.Point(403, 5);
            this.Tela2.Name = "Tela2";
            this.Tela2.Size = new System.Drawing.Size(201, 329);
            this.Tela2.TabIndex = 1;
            this.Tela2.Text = "";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(50, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Nome";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(50, 148);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(140, 20);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "Saldo";
            // 
            // btnContaPoupança
            // 
            this.btnContaPoupança.Location = new System.Drawing.Point(50, 93);
            this.btnContaPoupança.Name = "btnContaPoupança";
            this.btnContaPoupança.Size = new System.Drawing.Size(140, 23);
            this.btnContaPoupança.TabIndex = 3;
            this.btnContaPoupança.Text = "Criar Conta Poupança";
            this.btnContaPoupança.UseVisualStyleBackColor = true;
            this.btnContaPoupança.Click += new System.EventHandler(this.btnContaPoupança_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 346);
            this.Controls.Add(this.btnContaPoupança);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Tela2);
            this.Controls.Add(this.Tela);
            this.Controls.Add(this.btnContaCorrente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContaCorrente;
        private System.Windows.Forms.RichTextBox Tela;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox Tela2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnContaPoupança;
    }
}

