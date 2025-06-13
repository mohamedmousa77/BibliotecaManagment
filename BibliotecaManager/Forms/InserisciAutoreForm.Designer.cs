namespace BibliotecaManager.Forms
{
    partial class InserisciAutoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
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
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblCasaEditrice = new System.Windows.Forms.Label();
            this.lblGradimento = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtCasaEditrice = new System.Windows.Forms.TextBox();
            this.numGradimento = new System.Windows.Forms.NumericUpDown();
            this.btnConferma = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numGradimento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(26, 37);
            this.lblNome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(217, 56);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblCognome
            // 
            this.lblCognome.Location = new System.Drawing.Point(26, 110);
            this.lblCognome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(217, 56);
            this.lblCognome.TabIndex = 2;
            this.lblCognome.Text = "Cognome:";
            // 
            // lblCasaEditrice
            // 
            this.lblCasaEditrice.Location = new System.Drawing.Point(26, 184);
            this.lblCasaEditrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCasaEditrice.Name = "lblCasaEditrice";
            this.lblCasaEditrice.Size = new System.Drawing.Size(217, 56);
            this.lblCasaEditrice.TabIndex = 4;
            this.lblCasaEditrice.Text = "Casa Editrice:";
            // 
            // lblGradimento
            // 
            this.lblGradimento.Location = new System.Drawing.Point(26, 259);
            this.lblGradimento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGradimento.Name = "lblGradimento";
            this.lblGradimento.Size = new System.Drawing.Size(217, 56);
            this.lblGradimento.TabIndex = 6;
            this.lblGradimento.Text = "Gradimento:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(260, 29);
            this.txtNome.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(429, 39);
            this.txtNome.TabIndex = 1;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(260, 104);
            this.txtCognome.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(429, 39);
            this.txtCognome.TabIndex = 3;
            // 
            // txtCasaEditrice
            // 
            this.txtCasaEditrice.Location = new System.Drawing.Point(260, 178);
            this.txtCasaEditrice.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtCasaEditrice.Name = "txtCasaEditrice";
            this.txtCasaEditrice.Size = new System.Drawing.Size(429, 39);
            this.txtCasaEditrice.TabIndex = 5;
            // 
            // numGradimento
            // 
            this.numGradimento.Location = new System.Drawing.Point(260, 251);
            this.numGradimento.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.numGradimento.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numGradimento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGradimento.Name = "numGradimento";
            this.numGradimento.Size = new System.Drawing.Size(429, 39);
            this.numGradimento.TabIndex = 7;
            this.numGradimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numGradimento.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnConferma
            // 
            this.btnConferma.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnConferma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConferma.Location = new System.Drawing.Point(48, 344);
            this.btnConferma.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(195, 74);
            this.btnConferma.TabIndex = 8;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = false;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAnnulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulla.Location = new System.Drawing.Point(498, 344);
            this.btnAnnulla.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(195, 74);
            this.btnAnnulla.TabIndex = 9;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = false;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // InserisciAutoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(745, 467);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.lblCasaEditrice);
            this.Controls.Add(this.txtCasaEditrice);
            this.Controls.Add(this.lblGradimento);
            this.Controls.Add(this.numGradimento);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.btnAnnulla);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InserisciAutoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "➕ Inserisci Autore";
            this.Load += new System.EventHandler(this.InserisciAutoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numGradimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lblCasaEditrice;
        private System.Windows.Forms.Label lblGradimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtCasaEditrice;
        private System.Windows.Forms.NumericUpDown numGradimento;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Button btnAnnulla;
    }
}