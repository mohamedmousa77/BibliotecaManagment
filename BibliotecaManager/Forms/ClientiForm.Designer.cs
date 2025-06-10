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
            this.btnElimina.Location = new System.Drawing.Point(940, 365);
            this.btnElimina.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(214, 69);
            this.btnElimina.TabIndex = 0;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(498, 365);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(225, 69);
            this.btnModifica.TabIndex = 1;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(34, 365);
            this.btnAggiungi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(236, 69);
            this.btnAggiungi.TabIndex = 2;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // dgvClienti
            // 
            this.dgvClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienti.Location = new System.Drawing.Point(18, 18);
            this.dgvClienti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvClienti.Name = "dgvClienti";
            this.dgvClienti.RowHeadersWidth = 62;
            this.dgvClienti.Size = new System.Drawing.Size(1164, 337);
            this.dgvClienti.TabIndex = 3;
            // 
            // ClientiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dgvClienti);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnElimina);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientiForm";
            this.Text = "ClientiForm";
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