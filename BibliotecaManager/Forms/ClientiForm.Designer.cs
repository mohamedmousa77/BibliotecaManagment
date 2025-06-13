namespace BibliotecaManager.Forms
{
    partial class ClientiForm
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
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.dgvClienti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnElimina
            // 
            this.btnElimina.BackColor = System.Drawing.Color.LightCoral;
            this.btnElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimina.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.ForeColor = System.Drawing.Color.DarkRed;
            this.btnElimina.Location = new System.Drawing.Point(743, 465);
            this.btnElimina.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(263, 89);
            this.btnElimina.TabIndex = 0;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = false;
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.Khaki;
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnModifica.Location = new System.Drawing.Point(376, 465);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(274, 89);
            this.btnModifica.TabIndex = 1;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = false;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.LightGreen;
            this.btnAggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungi.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAggiungi.Location = new System.Drawing.Point(25, 465);
            this.btnAggiungi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(285, 89);
            this.btnAggiungi.TabIndex = 2;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // dgvClienti
            // 
            this.dgvClienti.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienti.Location = new System.Drawing.Point(18, 18);
            this.dgvClienti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvClienti.Name = "dgvClienti";
            this.dgvClienti.RowHeadersWidth = 62;
            this.dgvClienti.Size = new System.Drawing.Size(1019, 411);
            this.dgvClienti.TabIndex = 3;
            // 
            // ClientiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1050, 589);
            this.Controls.Add(this.dgvClienti);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnElimina);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "👥 Gestione Clienti";
            this.Load += new System.EventHandler(this.ClientiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.DataGridView dgvClienti;
    }
}