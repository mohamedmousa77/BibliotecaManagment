namespace BibliotecaManager.Forms
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.gestioneAutori = new System.Windows.Forms.Label();
            this.gestioneClienti = new System.Windows.Forms.Label();
            this.gestioneLibri = new System.Windows.Forms.Label();
            this.gestionePrestiti = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.caricaBtn = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Label();
            this.StatisticheBtn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(296, 62);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(598, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteca Managment System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gestioneAutori
            // 
            this.gestioneAutori.AutoSize = true;
            this.gestioneAutori.BackColor = System.Drawing.Color.SkyBlue;
            this.gestioneAutori.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gestioneAutori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gestioneAutori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestioneAutori.Location = new System.Drawing.Point(38, 230);
            this.gestioneAutori.Name = "gestioneAutori";
            this.gestioneAutori.Padding = new System.Windows.Forms.Padding(5);
            this.gestioneAutori.Size = new System.Drawing.Size(248, 41);
            this.gestioneAutori.TabIndex = 1;
            this.gestioneAutori.Text = "Gestione degli autori";
            this.gestioneAutori.Click += new System.EventHandler(this.btnAutori_Click);
            // 
            // gestioneClienti
            // 
            this.gestioneClienti.AutoSize = true;
            this.gestioneClienti.BackColor = System.Drawing.Color.SkyBlue;
            this.gestioneClienti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gestioneClienti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gestioneClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestioneClienti.Location = new System.Drawing.Point(332, 230);
            this.gestioneClienti.Name = "gestioneClienti";
            this.gestioneClienti.Padding = new System.Windows.Forms.Padding(5);
            this.gestioneClienti.Size = new System.Drawing.Size(231, 41);
            this.gestioneClienti.TabIndex = 2;
            this.gestioneClienti.Text = "Gestione dei clienti";
            this.gestioneClienti.Click += new System.EventHandler(this.btnClienti_Click);
            // 
            // gestioneLibri
            // 
            this.gestioneLibri.AutoSize = true;
            this.gestioneLibri.BackColor = System.Drawing.Color.SkyBlue;
            this.gestioneLibri.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gestioneLibri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gestioneLibri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestioneLibri.Location = new System.Drawing.Point(620, 230);
            this.gestioneLibri.Name = "gestioneLibri";
            this.gestioneLibri.Padding = new System.Windows.Forms.Padding(5);
            this.gestioneLibri.Size = new System.Drawing.Size(208, 41);
            this.gestioneLibri.TabIndex = 3;
            this.gestioneLibri.Text = "Gestione dei libri";
            this.gestioneLibri.Click += new System.EventHandler(this.btnLibri_Click);
            // 
            // gestionePrestiti
            // 
            this.gestionePrestiti.AutoSize = true;
            this.gestionePrestiti.BackColor = System.Drawing.Color.SkyBlue;
            this.gestionePrestiti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gestionePrestiti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gestionePrestiti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionePrestiti.Location = new System.Drawing.Point(902, 230);
            this.gestionePrestiti.Name = "gestionePrestiti";
            this.gestionePrestiti.Padding = new System.Windows.Forms.Padding(5);
            this.gestionePrestiti.Size = new System.Drawing.Size(240, 41);
            this.gestionePrestiti.TabIndex = 4;
            this.gestionePrestiti.Text = "Gestione dei prestiti";
            this.gestionePrestiti.Click += new System.EventHandler(this.btnPrestiti_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(38, 335);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(30, 7, 30, 7);
            this.label2.Size = new System.Drawing.Size(175, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Archivio:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // caricaBtn
            // 
            this.caricaBtn.AutoSize = true;
            this.caricaBtn.BackColor = System.Drawing.Color.Navy;
            this.caricaBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caricaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.caricaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caricaBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.caricaBtn.Location = new System.Drawing.Point(395, 337);
            this.caricaBtn.Name = "caricaBtn";
            this.caricaBtn.Padding = new System.Windows.Forms.Padding(10);
            this.caricaBtn.Size = new System.Drawing.Size(97, 47);
            this.caricaBtn.TabIndex = 6;
            this.caricaBtn.Text = "Carica";
            this.caricaBtn.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.AutoSize = true;
            this.saveBtn.BackColor = System.Drawing.Color.Navy;
            this.saveBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveBtn.Location = new System.Drawing.Point(256, 337);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Padding = new System.Windows.Forms.Padding(10);
            this.saveBtn.Size = new System.Drawing.Size(89, 47);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Salva";
            this.saveBtn.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // StatisticheBtn
            // 
            this.StatisticheBtn.AutoSize = true;
            this.StatisticheBtn.BackColor = System.Drawing.Color.Navy;
            this.StatisticheBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatisticheBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StatisticheBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatisticheBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StatisticheBtn.Location = new System.Drawing.Point(256, 454);
            this.StatisticheBtn.Name = "StatisticheBtn";
            this.StatisticheBtn.Padding = new System.Windows.Forms.Padding(10);
            this.StatisticheBtn.Size = new System.Drawing.Size(133, 47);
            this.StatisticheBtn.TabIndex = 9;
            this.StatisticheBtn.Text = "Visualizza";
            this.StatisticheBtn.Click += new System.EventHandler(this.btnStatistiche_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(38, 452);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(30, 7, 30, 7);
            this.label4.Size = new System.Drawing.Size(196, 45);
            this.label4.TabIndex = 8;
            this.label4.Text = "Statistiche";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1207, 639);
            this.Controls.Add(this.StatisticheBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.caricaBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gestionePrestiti);
            this.Controls.Add(this.gestioneLibri);
            this.Controls.Add(this.gestioneClienti);
            this.Controls.Add(this.gestioneAutori);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Biblioteca Managment";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gestioneAutori;
        private System.Windows.Forms.Label gestioneClienti;
        private System.Windows.Forms.Label gestioneLibri;
        private System.Windows.Forms.Label gestionePrestiti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label caricaBtn;
        private System.Windows.Forms.Label saveBtn;
        private System.Windows.Forms.Label StatisticheBtn;
        private System.Windows.Forms.Label label4;
    }
}