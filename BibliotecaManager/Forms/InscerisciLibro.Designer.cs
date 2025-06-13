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
            this.autoriComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.QtyMagazzino)).BeginInit();
            this.SuspendLayout();
            // 
            // ISBNtxt
            // 
            this.ISBNtxt.Location = new System.Drawing.Point(248, 365);
            this.ISBNtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ISBNtxt.Name = "ISBNtxt";
            this.ISBNtxt.Size = new System.Drawing.Size(350, 26);
            this.ISBNtxt.TabIndex = 0;
            // 
            // CasaEditricetxt
            // 
            this.CasaEditricetxt.Location = new System.Drawing.Point(248, 91);
            this.CasaEditricetxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CasaEditricetxt.Name = "CasaEditricetxt";
            this.CasaEditricetxt.Size = new System.Drawing.Size(350, 26);
            this.CasaEditricetxt.TabIndex = 2;
            // 
            // Titolotxt
            // 
            this.Titolotxt.Location = new System.Drawing.Point(248, 35);
            this.Titolotxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Titolotxt.Name = "Titolotxt";
            this.Titolotxt.Size = new System.Drawing.Size(350, 26);
            this.Titolotxt.TabIndex = 3;
            // 
            // Generetxt
            // 
            this.Generetxt.Location = new System.Drawing.Point(248, 310);
            this.Generetxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Generetxt.Name = "Generetxt";
            this.Generetxt.Size = new System.Drawing.Size(350, 26);
            this.Generetxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ISBN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantita Magazzino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Anno Pubblicazione";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Genere";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Casa Editrice";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Titolo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Autore";
            // 
            // ConfermaBTN
            // 
            this.ConfermaBTN.Location = new System.Drawing.Point(248, 432);
            this.ConfermaBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfermaBTN.Name = "ConfermaBTN";
            this.ConfermaBTN.Size = new System.Drawing.Size(164, 41);
            this.ConfermaBTN.TabIndex = 14;
            this.ConfermaBTN.Text = "Conferma";
            this.ConfermaBTN.UseVisualStyleBackColor = true;
            this.ConfermaBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnnullaBTN
            // 
            this.AnnullaBTN.Location = new System.Drawing.Point(434, 432);
            this.AnnullaBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AnnullaBTN.Name = "AnnullaBTN";
            this.AnnullaBTN.Size = new System.Drawing.Size(164, 41);
            this.AnnullaBTN.TabIndex = 15;
            this.AnnullaBTN.Text = "Annulla";
            this.AnnullaBTN.UseVisualStyleBackColor = true;
            this.AnnullaBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // AnnoPubDate
            // 
            this.AnnoPubDate.Location = new System.Drawing.Point(248, 142);
            this.AnnoPubDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AnnoPubDate.Name = "AnnoPubDate";
            this.AnnoPubDate.Size = new System.Drawing.Size(350, 26);
            this.AnnoPubDate.TabIndex = 16;
            this.AnnoPubDate.ValueChanged += new System.EventHandler(this.AnnoPubDate_ValueChanged);
            // 
            // QtyMagazzino
            // 
            this.QtyMagazzino.Location = new System.Drawing.Point(248, 198);
            this.QtyMagazzino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QtyMagazzino.Name = "QtyMagazzino";
            this.QtyMagazzino.Size = new System.Drawing.Size(351, 26);
            this.QtyMagazzino.TabIndex = 17;
            this.QtyMagazzino.ValueChanged += new System.EventHandler(this.QtyMagazzino_ValueChanged);
            // 
            // autoriComboBox
            // 
            this.autoriComboBox.FormattingEnabled = true;
            this.autoriComboBox.Location = new System.Drawing.Point(248, 247);
            this.autoriComboBox.Name = "autoriComboBox";
            this.autoriComboBox.Size = new System.Drawing.Size(350, 28);
            this.autoriComboBox.TabIndex = 18;
            this.autoriComboBox.SelectedIndexChanged += new System.EventHandler(this.autoriComboBox_SelectedIndexChanged);
            // 
            // InscerisciLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 562);
            this.Controls.Add(this.autoriComboBox);
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
            this.Controls.Add(this.Titolotxt);
            this.Controls.Add(this.CasaEditricetxt);
            this.Controls.Add(this.ISBNtxt);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InscerisciLibro";
            this.Text = "InscerisciLibro";
            this.Load += new System.EventHandler(this.InscerisciLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QtyMagazzino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ISBNtxt;
        private System.Windows.Forms.TextBox CasaEditricetxt;
        private System.Windows.Forms.TextBox Titolotxt;
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
        private System.Windows.Forms.ComboBox autoriComboBox;
    }
}