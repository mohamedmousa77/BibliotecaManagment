namespace BibliotecaManager.Forms
{
    partial class InscerisciLibro
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
            this.ISBNtxt = new System.Windows.Forms.TextBox();
            this.CasaEditricetxt = new System.Windows.Forms.TextBox();
            this.Titolotxt = new System.Windows.Forms.TextBox();
            this.Autoretxt = new System.Windows.Forms.TextBox();
            this.Generetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ConfermaBTN = new System.Windows.Forms.Button();
            this.AnnullaBTN = new System.Windows.Forms.Button();
            this.AnnoPubDate = new System.Windows.Forms.DateTimePicker();
            this.QtyMagazzino = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.QtyMagazzino)).BeginInit();
            this.SuspendLayout();
            // 
            // ISBNtxt
            // 
            this.ISBNtxt.Location = new System.Drawing.Point(220, 292);
            this.ISBNtxt.Name = "ISBNtxt";
            this.ISBNtxt.Size = new System.Drawing.Size(312, 22);
            this.ISBNtxt.TabIndex = 0;
            // 
            // CasaEditricetxt
            // 
            this.CasaEditricetxt.Location = new System.Drawing.Point(220, 73);
            this.CasaEditricetxt.Name = "CasaEditricetxt";
            this.CasaEditricetxt.Size = new System.Drawing.Size(312, 22);
            this.CasaEditricetxt.TabIndex = 2;
            // 
            // Titolotxt
            // 
            this.Titolotxt.Location = new System.Drawing.Point(220, 28);
            this.Titolotxt.Name = "Titolotxt";
            this.Titolotxt.Size = new System.Drawing.Size(312, 22);
            this.Titolotxt.TabIndex = 3;
            // 
            // Autoretxt
            // 
            this.Autoretxt.Location = new System.Drawing.Point(220, 202);
            this.Autoretxt.Name = "Autoretxt";
            this.Autoretxt.Size = new System.Drawing.Size(312, 22);
            this.Autoretxt.TabIndex = 4;
            // 
            // Generetxt
            // 
            this.Generetxt.Location = new System.Drawing.Point(220, 248);
            this.Generetxt.Name = "Generetxt";
            this.Generetxt.Size = new System.Drawing.Size(312, 22);
            this.Generetxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "ISBN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantita Magazzino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Anno Pubblicazione";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Genere";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Casa Editrice";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Titolo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Autore";
            // 
            // ConfermaBTN
            // 
            this.ConfermaBTN.Location = new System.Drawing.Point(220, 346);
            this.ConfermaBTN.Name = "ConfermaBTN";
            this.ConfermaBTN.Size = new System.Drawing.Size(146, 33);
            this.ConfermaBTN.TabIndex = 14;
            this.ConfermaBTN.Text = "Conferma";
            this.ConfermaBTN.UseVisualStyleBackColor = true;
            this.ConfermaBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnnullaBTN
            // 
            this.AnnullaBTN.Location = new System.Drawing.Point(386, 346);
            this.AnnullaBTN.Name = "AnnullaBTN";
            this.AnnullaBTN.Size = new System.Drawing.Size(146, 33);
            this.AnnullaBTN.TabIndex = 15;
            this.AnnullaBTN.Text = "Annulla";
            this.AnnullaBTN.UseVisualStyleBackColor = true;
            this.AnnullaBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // AnnoPubDate
            // 
            this.AnnoPubDate.Location = new System.Drawing.Point(220, 114);
            this.AnnoPubDate.Name = "AnnoPubDate";
            this.AnnoPubDate.Size = new System.Drawing.Size(312, 22);
            this.AnnoPubDate.TabIndex = 16;
            this.AnnoPubDate.ValueChanged += new System.EventHandler(this.AnnoPubDate_ValueChanged);
            // 
            // QtyMagazzino
            // 
            this.QtyMagazzino.Location = new System.Drawing.Point(220, 158);
            this.QtyMagazzino.Name = "QtyMagazzino";
            this.QtyMagazzino.Size = new System.Drawing.Size(312, 22);
            this.QtyMagazzino.TabIndex = 17;
            this.QtyMagazzino.ValueChanged += new System.EventHandler(this.QtyMagazzino_ValueChanged);
            // 
            // InscerisciLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.QtyMagazzino);
            this.Controls.Add(this.AnnoPubDate);
            this.Controls.Add(this.AnnullaBTN);
            this.Controls.Add(this.ConfermaBTN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Generetxt);
            this.Controls.Add(this.Autoretxt);
            this.Controls.Add(this.Titolotxt);
            this.Controls.Add(this.CasaEditricetxt);
            this.Controls.Add(this.ISBNtxt);
            this.Name = "InscerisciLibro";
            this.Text = "InscerisciLibro";
            ((System.ComponentModel.ISupportInitialize)(this.QtyMagazzino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ISBNtxt;
        private System.Windows.Forms.TextBox CasaEditricetxt;
        private System.Windows.Forms.TextBox Titolotxt;
        private System.Windows.Forms.TextBox Autoretxt;
        private System.Windows.Forms.TextBox Generetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ConfermaBTN;
        private System.Windows.Forms.Button AnnullaBTN;
        private System.Windows.Forms.DateTimePicker AnnoPubDate;
        private System.Windows.Forms.NumericUpDown QtyMagazzino;
    }
}