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
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnConferma = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(36, 56);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(160, 49);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(242, 56);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(359, 31);
            this.txtNome.TabIndex = 11;
            // 
            // lblCognome
            // 
            this.lblCognome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCognome.Location = new System.Drawing.Point(36, 105);
            this.lblCognome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(196, 49);
            this.lblCognome.TabIndex = 12;
            this.lblCognome.Text = "Cognome:";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(241, 99);
            this.txtCognome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(360, 31);
            this.txtCognome.TabIndex = 13;
            this.txtCognome.TextChanged += new System.EventHandler(this.txtCognome_TextChanged);
            // 
            // lblMail
            // 
            this.lblMail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(36, 151);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(154, 49);
            this.lblMail.TabIndex = 14;
            this.lblMail.Text = "E-mail:";
            this.lblMail.Click += new System.EventHandler(this.lblCasaEditrice_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(242, 148);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(359, 31);
            this.txtMail.TabIndex = 15;
            // 
            // btnConferma
            // 
            this.btnConferma.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnConferma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConferma.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConferma.ForeColor = System.Drawing.Color.White;
            this.btnConferma.Location = new System.Drawing.Point(58, 325);
            this.btnConferma.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(138, 62);
            this.btnConferma.TabIndex = 18;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = false;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click_1);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAnnulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulla.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.ForeColor = System.Drawing.Color.White;
            this.btnAnnulla.Location = new System.Drawing.Point(440, 325);
            this.btnAnnulla.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(138, 62);
            this.btnAnnulla.TabIndex = 19;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = false;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "Numero di Telefono:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(241, 209);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(360, 31);
            this.txtPhone.TabIndex = 22;
            // 
            // InserisciClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(643, 499);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.btnAnnulla);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InserisciClienteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "➕ Inserisci Cliente";
            this.Load += new System.EventHandler(this.InserisciClienteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Button btnAnnulla;
        
    }
}