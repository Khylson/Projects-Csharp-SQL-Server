namespace WindForms
{
    partial class frmEmpregados
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
            this.dgvEmpregado = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpregado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpregado
            // 
            this.dgvEmpregado.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmpregado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpregado.Location = new System.Drawing.Point(12, 12);
            this.dgvEmpregado.Name = "dgvEmpregado";
            this.dgvEmpregado.Size = new System.Drawing.Size(548, 331);
            this.dgvEmpregado.TabIndex = 0;
            this.dgvEmpregado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpregado_CellContentClick);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(485, 349);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmEmpregados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindForms.Properties.Resources.img_como_colocar_fundo_preto_nas_fotos_16171_orig;
            this.ClientSize = new System.Drawing.Size(572, 377);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvEmpregado);
            this.Name = "frmEmpregados";
            this.Text = "frmEmpregados";
            this.Load += new System.EventHandler(this.frmEmpregados_Load);
            this.DoubleClick += new System.EventHandler(this.frmEmpregados_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpregado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpregado;
        private System.Windows.Forms.Button btnNovo;
    }
}