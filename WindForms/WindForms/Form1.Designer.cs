namespace WindForms
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
            this.cmdClientes = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdClientes
            // 
            this.cmdClientes.BackColor = System.Drawing.Color.Blue;
            this.cmdClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdClientes.ForeColor = System.Drawing.Color.White;
            this.cmdClientes.Location = new System.Drawing.Point(12, 50);
            this.cmdClientes.Name = "cmdClientes";
            this.cmdClientes.Size = new System.Drawing.Size(164, 68);
            this.cmdClientes.TabIndex = 0;
            this.cmdClientes.Text = "Clientes";
            this.cmdClientes.UseVisualStyleBackColor = false;
            this.cmdClientes.Click += new System.EventHandler(this.cmdClientes_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Blue;
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(182, 50);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(164, 68);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Empregado";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindForms.Properties.Resources.img_como_colocar_fundo_preto_nas_fotos_16171_orig;
            this.ClientSize = new System.Drawing.Size(355, 159);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.cmdClientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdClientes;
        private System.Windows.Forms.Button btnEmployee;
    }
}

