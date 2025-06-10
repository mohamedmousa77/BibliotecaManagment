namespace BibliotecaManager.Forms
{
    partial class InserisciClienteForm
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblCasaEditrice = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnConferma = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(35, 29);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(144, 39);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(218, 28);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(322, 26);
            this.txtNome.TabIndex = 11;
            // 
            // lblCognome
            // 
            this.lblCognome.Location = new System.Drawing.Point(32, 79);
            this.lblCognome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(176, 39);
            this.lblCognome.TabIndex = 12;
            this.lblCognome.Text = "Cognome:";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(217, 79);
            this.txtCognome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(324, 26);
            this.txtCognome.TabIndex = 13;
            this.txtCognome.TextChanged += new System.EventHandler(this.txtCognome_TextChanged);
            // 
            // lblCasaEditrice
            // 
            this.lblCasaEditrice.Location = new System.Drawing.Point(40, 118);
            this.lblCasaEditrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCasaEditrice.Name = "lblCasaEditrice";
            this.lblCasaEditrice.Size = new System.Drawing.Size(139, 39);
            this.lblCasaEditrice.TabIndex = 14;
            this.lblCasaEditrice.Text = "E-mail:";
            this.lblCasaEditrice.Click += new System.EventHandler(this.lblCasaEditrice_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(218, 118);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(322, 26);
            this.txtMail.TabIndex = 15;
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(111, 260);
            this.btnConferma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(124, 50);
            this.btnConferma.TabIndex = 18;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click_1);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(288, 260);
            this.btnAnnulla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(124, 50);
            this.btnAnnulla.TabIndex = 19;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Numero di Telefono:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(218, 158);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(321, 26);
            this.txtPhone.TabIndex = 21;
            this.txtPhone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // InserisciClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.lblCasaEditrice);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.btnAnnulla);
            this.Name = "InserisciClienteForm";
            this.Text = "Inserisci Cliente ";
            this.Load += new System.EventHandler(this.InserisciClienteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblCasaEditrice;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
    }
}