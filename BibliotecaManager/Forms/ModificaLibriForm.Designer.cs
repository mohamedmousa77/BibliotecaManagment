namespace BibliotecaManager.Forms
{
    partial class ModificaLibriForm
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
            this.QtyMagazzino = new System.Windows.Forms.NumericUpDown();
            this.AnnoPubDate = new System.Windows.Forms.DateTimePicker();
            this.AnnullaBTN = new System.Windows.Forms.Button();
            this.ConfermaBTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Generetxt = new System.Windows.Forms.TextBox();
            this.Autoretxt = new System.Windows.Forms.TextBox();
            this.Titolotxt = new System.Windows.Forms.TextBox();
            this.CasaEditricetxt = new System.Windows.Forms.TextBox();
            this.ISBNtxt = new System.Windows.Forms.TextBox();
            this.autoriComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.QtyMagazzino)).BeginInit();
            this.SuspendLayout();
            // 
            // QtyMagazzino
            // 
            this.QtyMagazzino.Location = new System.Drawing.Point(226, 215);
            this.QtyMagazzino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QtyMagazzino.Name = "QtyMagazzino";
            this.QtyMagazzino.Size = new System.Drawing.Size(351, 26);
            this.QtyMagazzino.TabIndex = 33;
            // 
            // AnnoPubDate
            // 
            this.AnnoPubDate.Location = new System.Drawing.Point(226, 160);
            this.AnnoPubDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AnnoPubDate.Name = "AnnoPubDate";
            this.AnnoPubDate.Size = new System.Drawing.Size(350, 26);
            this.AnnoPubDate.TabIndex = 32;
            // 
            // AnnullaBTN
            // 
            this.AnnullaBTN.Location = new System.Drawing.Point(413, 450);
            this.AnnullaBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AnnullaBTN.Name = "AnnullaBTN";
            this.AnnullaBTN.Size = new System.Drawing.Size(164, 41);
            this.AnnullaBTN.TabIndex = 31;
            this.AnnullaBTN.Text = "Annulla";
            this.AnnullaBTN.UseVisualStyleBackColor = true;
            this.AnnullaBTN.Click += new System.EventHandler(this.AnnullaBTN_Click);
            // 
            // ConfermaBTN
            // 
            this.ConfermaBTN.Location = new System.Drawing.Point(226, 450);
            this.ConfermaBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfermaBTN.Name = "ConfermaBTN";
            this.ConfermaBTN.Size = new System.Drawing.Size(164, 41);
            this.ConfermaBTN.TabIndex = 30;
            this.ConfermaBTN.Text = "Conferma";
            this.ConfermaBTN.UseVisualStyleBackColor = true;
            this.ConfermaBTN.Click += new System.EventHandler(this.ConfermaBTN_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Autore";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Titolo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Casa Editrice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Genere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Anno Pubblicazione";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Quantita Magazzino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "ISBN";
            // 
            // Generetxt
            // 
            this.Generetxt.Location = new System.Drawing.Point(226, 328);
            this.Generetxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Generetxt.Name = "Generetxt";
            this.Generetxt.Size = new System.Drawing.Size(350, 26);
            this.Generetxt.TabIndex = 22;
            // 
            // Autoretxt
            // 
            this.Autoretxt.Location = new System.Drawing.Point(226, 270);
            this.Autoretxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Autoretxt.Name = "Autoretxt";
            this.Autoretxt.Size = new System.Drawing.Size(350, 26);
            this.Autoretxt.TabIndex = 21;
            // 
            // Titolotxt
            // 
            this.Titolotxt.Location = new System.Drawing.Point(226, 52);
            this.Titolotxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Titolotxt.Name = "Titolotxt";
            this.Titolotxt.Size = new System.Drawing.Size(350, 26);
            this.Titolotxt.TabIndex = 20;
            // 
            // CasaEditricetxt
            // 
            this.CasaEditricetxt.Location = new System.Drawing.Point(226, 109);
            this.CasaEditricetxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CasaEditricetxt.Name = "CasaEditricetxt";
            this.CasaEditricetxt.Size = new System.Drawing.Size(350, 26);
            this.CasaEditricetxt.TabIndex = 19;
            // 
            // ISBNtxt
            // 
            this.ISBNtxt.Location = new System.Drawing.Point(226, 382);
            this.ISBNtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ISBNtxt.Name = "ISBNtxt";
            this.ISBNtxt.Size = new System.Drawing.Size(350, 26);
            this.ISBNtxt.TabIndex = 18;
            // 
            // autoriComboBox
            // 
            this.autoriComboBox.BackColor = System.Drawing.Color.Transparent;
            this.autoriComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.autoriComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autoriComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.autoriComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.autoriComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.autoriComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.autoriComboBox.ItemHeight = 30;
            this.autoriComboBox.Location = new System.Drawing.Point(595, 266);
            this.autoriComboBox.Name = "autoriComboBox";
            this.autoriComboBox.Size = new System.Drawing.Size(223, 36);
            this.autoriComboBox.TabIndex = 34;
            this.autoriComboBox.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // ModificaLibriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 562);
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
            this.Controls.Add(this.Autoretxt);
            this.Controls.Add(this.Titolotxt);
            this.Controls.Add(this.CasaEditricetxt);
            this.Controls.Add(this.ISBNtxt);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModificaLibriForm";
            this.Text = "ModificaLibriForm";
            this.Load += new System.EventHandler(this.ModificaLibriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QtyMagazzino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown QtyMagazzino;
        private System.Windows.Forms.DateTimePicker AnnoPubDate;
        private System.Windows.Forms.Button AnnullaBTN;
        private System.Windows.Forms.Button ConfermaBTN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Generetxt;
        private System.Windows.Forms.TextBox Autoretxt;
        private System.Windows.Forms.TextBox Titolotxt;
        private System.Windows.Forms.TextBox CasaEditricetxt;
        private System.Windows.Forms.TextBox ISBNtxt;
        private Guna.UI2.WinForms.Guna2ComboBox autoriComboBox;
    }
}