namespace BibliotecaManager.Forms
{
    partial class AutoriForm
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
            this.dgvAutori = new System.Windows.Forms.DataGridView();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutori)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutori
            // 
            this.dgvAutori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutori.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAutori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutori.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAutori.Location = new System.Drawing.Point(0, 0);
            this.dgvAutori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAutori.Name = "dgvAutori";
            this.dgvAutori.ReadOnly = true;
            this.dgvAutori.RowHeadersWidth = 62;
            this.dgvAutori.RowTemplate.Height = 28;
            this.dgvAutori.Size = new System.Drawing.Size(889, 188);
            this.dgvAutori.TabIndex = 0;
            this.dgvAutori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutori_CellContentClick);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.LightGreen;
            this.btnAggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungi.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungi.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAggiungi.Location = new System.Drawing.Point(21, 446);
            this.btnAggiungi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(248, 85);
            this.btnAggiungi.TabIndex = 1;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.Khaki;
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifica.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnModifica.Location = new System.Drawing.Point(325, 446);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(248, 85);
            this.btnModifica.TabIndex = 2;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.BackColor = System.Drawing.Color.LightCoral;
            this.btnElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimina.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.ForeColor = System.Drawing.Color.DarkRed;
            this.btnElimina.Location = new System.Drawing.Point(629, 446);
            this.btnElimina.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(248, 85);
            this.btnElimina.TabIndex = 3;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // AutoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(889, 562);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.dgvAutori);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AutoriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "👤Autori Form";
            this.Load += new System.EventHandler(this.AutoriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutori;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnElimina;
    }
}