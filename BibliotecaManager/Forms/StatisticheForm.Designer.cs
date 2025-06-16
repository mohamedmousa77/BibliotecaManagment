namespace BibliotecaManager.Forms
{
    partial class StatisticheForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInCorso = new System.Windows.Forms.Label();
            this.AttiviLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblScaduti = new System.Windows.Forms.Label();
            this.ScadutiLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.UtentiRegistratiLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.LibriPrestitiLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(980, 549);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lblInCorso);
            this.panel1.Controls.Add(this.AttiviLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 267);
            this.panel1.TabIndex = 0;
            // 
            // lblInCorso
            // 
            this.lblInCorso.AutoSize = true;
            this.lblInCorso.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInCorso.Location = new System.Drawing.Point(165, 146);
            this.lblInCorso.Name = "lblInCorso";
            this.lblInCorso.Size = new System.Drawing.Size(137, 54);
            this.lblInCorso.TabIndex = 1;
            this.lblInCorso.Text = "label9";
            this.lblInCorso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInCorso.Click += new System.EventHandler(this.label2_Click);
            // 
            // AttiviLabel
            // 
            this.AttiviLabel.AutoSize = true;
            this.AttiviLabel.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttiviLabel.Location = new System.Drawing.Point(31, 44);
            this.AttiviLabel.Name = "AttiviLabel";
            this.AttiviLabel.Size = new System.Drawing.Size(144, 28);
            this.AttiviLabel.TabIndex = 0;
            this.AttiviLabel.Text = "Prestiti Attivi";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.lblScaduti);
            this.panel2.Controls.Add(this.ScadutiLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(493, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 267);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblScaduti
            // 
            this.lblScaduti.AutoSize = true;
            this.lblScaduti.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScaduti.Location = new System.Drawing.Point(134, 146);
            this.lblScaduti.Name = "lblScaduti";
            this.lblScaduti.Size = new System.Drawing.Size(160, 54);
            this.lblScaduti.TabIndex = 2;
            this.lblScaduti.Text = "label10";
            this.lblScaduti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScaduti.Click += new System.EventHandler(this.lblScaduti_Click);
            // 
            // ScadutiLabel
            // 
            this.ScadutiLabel.AutoSize = true;
            this.ScadutiLabel.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScadutiLabel.Location = new System.Drawing.Point(58, 44);
            this.ScadutiLabel.Name = "ScadutiLabel";
            this.ScadutiLabel.Size = new System.Drawing.Size(84, 28);
            this.ScadutiLabel.TabIndex = 0;
            this.ScadutiLabel.Text = "Scaduti";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.UtentiRegistratiLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(482, 267);
            this.panel3.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(165, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 54);
            this.label8.TabIndex = 4;
            this.label8.Text = "label8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UtentiRegistratiLabel
            // 
            this.UtentiRegistratiLabel.AutoSize = true;
            this.UtentiRegistratiLabel.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UtentiRegistratiLabel.Location = new System.Drawing.Point(31, 42);
            this.UtentiRegistratiLabel.Name = "UtentiRegistratiLabel";
            this.UtentiRegistratiLabel.Size = new System.Drawing.Size(170, 28);
            this.UtentiRegistratiLabel.TabIndex = 1;
            this.UtentiRegistratiLabel.Text = "Utenti registrati";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.LibriPrestitiLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(493, 278);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(483, 267);
            this.panel4.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(157, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 54);
            this.label7.TabIndex = 3;
            this.label7.Text = "label7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // LibriPrestitiLabel
            // 
            this.LibriPrestitiLabel.AutoSize = true;
            this.LibriPrestitiLabel.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibriPrestitiLabel.Location = new System.Drawing.Point(58, 42);
            this.LibriPrestitiLabel.Name = "LibriPrestitiLabel";
            this.LibriPrestitiLabel.Padding = new System.Windows.Forms.Padding(5);
            this.LibriPrestitiLabel.Size = new System.Drawing.Size(223, 38);
            this.LibriPrestitiLabel.TabIndex = 2;
            this.LibriPrestitiLabel.Text = "Libri prestati ai soci ";
            // 
            // StatisticheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 549);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StatisticheForm";
            this.Text = "StatisticheForm";
            this.Load += new System.EventHandler(this.StatisticheForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInCorso;
        private System.Windows.Forms.Label AttiviLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ScadutiLabel;
        private System.Windows.Forms.Label lblScaduti;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label UtentiRegistratiLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LibriPrestitiLabel;
    }
}