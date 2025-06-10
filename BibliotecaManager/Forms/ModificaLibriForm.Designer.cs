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
            ((System.ComponentModel.ISupportInitialize)(this.QtyMagazzino)).BeginInit();
            this.SuspendLayout();
            // 
            // QtyMagazzino
            // 
            this.QtyMagazzino.Location = new System.Drawing.Point(201, 172);
            this.QtyMagazzino.Name = "QtyMagazzino";
            this.QtyMagazzino.Size = new System.Drawing.Size(312, 22);
            this.QtyMagazzino.TabIndex = 33;
            // 
            // AnnoPubDate
            // 
            this.AnnoPubDate.Location = new System.Drawing.Point(201, 128);
            this.AnnoPubDate.Name = "AnnoPubDate";
            this.AnnoPubDate.Size = new System.Drawing.Size(312, 22);
            this.AnnoPubDate.TabIndex = 32;
            // 
            // AnnullaBTN
            // 
            this.AnnullaBTN.Location = new System.Drawing.Point(367, 360);
            this.AnnullaBTN.Name = "AnnullaBTN";
            this.AnnullaBTN.Size = new System.Drawing.Size(146, 33);
            this.AnnullaBTN.TabIndex = 31;
            this.AnnullaBTN.Text = "Annulla";
            this.AnnullaBTN.UseVisualStyleBackColor = true;
            this.AnnullaBTN.Click += new System.EventHandler(this.AnnullaBTN_Click);
            // 
            // ConfermaBTN
            // 
            this.ConfermaBTN.Location = new System.Drawing.Point(201, 360);
            this.ConfermaBTN.Name = "ConfermaBTN";
            this.ConfermaBTN.Size = new System.Drawing.Size(146, 33);
            this.ConfermaBTN.TabIndex = 30;
            this.ConfermaBTN.Text = "Conferma";
            this.ConfermaBTN.UseVisualStyleBackColor = true;
            this.ConfermaBTN.Click += new System.EventHandler(this.ConfermaBTN_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Autore";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Titolo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Casa Editrice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Genere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Anno Pubblicazione";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Quantita Magazzino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "ISBN";
            // 
            // Generetxt
            // 
            this.Generetxt.Location = new System.Drawing.Point(201, 262);
            this.Generetxt.Name = "Generetxt";
            this.Generetxt.Size = new System.Drawing.Size(312, 22);
            this.Generetxt.TabIndex = 22;
            // 
            // Autoretxt
            // 
            this.Autoretxt.Location = new System.Drawing.Point(201, 216);
            this.Autoretxt.Name = "Autoretxt";
            this.Autoretxt.Size = new System.Drawing.Size(312, 22);
            this.Autoretxt.TabIndex = 21;
            // 
            // Titolotxt
            // 
            this.Titolotxt.Location = new System.Drawing.Point(201, 42);
            this.Titolotxt.Name = "Titolotxt";
            this.Titolotxt.Size = new System.Drawing.Size(312, 22);
            this.Titolotxt.TabIndex = 20;
            // 
            // CasaEditricetxt
            // 
            this.CasaEditricetxt.Location = new System.Drawing.Point(201, 87);
            this.CasaEditricetxt.Name = "CasaEditricetxt";
            this.CasaEditricetxt.Size = new System.Drawing.Size(312, 22);
            this.CasaEditricetxt.TabIndex = 19;
            // 
            // ISBNtxt
            // 
            this.ISBNtxt.Location = new System.Drawing.Point(201, 306);
            this.ISBNtxt.Name = "ISBNtxt";
            this.ISBNtxt.Size = new System.Drawing.Size(312, 22);
            this.ISBNtxt.TabIndex = 18;
            // 
            // ModificaLibriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 450);
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
    }
}