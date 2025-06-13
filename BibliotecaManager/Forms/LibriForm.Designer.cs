namespace BibliotecaManager.Forms
{
    partial class Gestione
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
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.dgvLibri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.LightGreen;
            this.btnAggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungi.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungi.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAggiungi.Location = new System.Drawing.Point(18, 560);
            this.btnAggiungi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(312, 104);
            this.btnAggiungi.TabIndex = 0;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.Khaki;
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifica.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnModifica.Location = new System.Drawing.Point(438, 560);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(312, 104);
            this.btnModifica.TabIndex = 1;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.BackColor = System.Drawing.Color.LightCoral;
            this.btnElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimina.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.ForeColor = System.Drawing.Color.DarkRed;
            this.btnElimina.Location = new System.Drawing.Point(868, 560);
            this.btnElimina.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(314, 104);
            this.btnElimina.TabIndex = 2;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // dgvLibri
            // 
            this.dgvLibri.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.dgvLibri.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvLibri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibri.Location = new System.Drawing.Point(18, 19);
            this.dgvLibri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLibri.Name = "dgvLibri";
            this.dgvLibri.RowHeadersWidth = 51;
            this.dgvLibri.Size = new System.Drawing.Size(1164, 322);
            this.dgvLibri.TabIndex = 3;
            this.dgvLibri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Gestione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dgvLibri);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAggiungi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gestione";
            this.Text = "📚 Gestione Libri ";
            this.Load += new System.EventHandler(this.LibriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.DataGridView dgvLibri;
    }
}