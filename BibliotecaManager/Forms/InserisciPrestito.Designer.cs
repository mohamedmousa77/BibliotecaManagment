namespace BibliotecaManager.Forms
{
    partial class InserisciPrestitoForm
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
            this.components = new System.ComponentModel.Container();
            this.btnConferma = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.dataScadenza = new System.Windows.Forms.DateTimePicker();
            this.dataConsegna = new System.Windows.Forms.DateTimePicker();
            this.dataPrestito = new System.Windows.Forms.DateTimePicker();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(67, 330);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(211, 88);
            this.btnConferma.TabIndex = 0;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(339, 330);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(196, 88);
            this.btnAnnulla.TabIndex = 1;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // dataScadenza
            // 
            this.dataScadenza.Location = new System.Drawing.Point(268, 214);
            this.dataScadenza.Name = "dataScadenza";
            this.dataScadenza.Size = new System.Drawing.Size(267, 26);
            this.dataScadenza.TabIndex = 2;
            // 
            // dataConsegna
            // 
            this.dataConsegna.Location = new System.Drawing.Point(268, 284);
            this.dataConsegna.Name = "dataConsegna";
            this.dataConsegna.Size = new System.Drawing.Size(267, 26);
            this.dataConsegna.TabIndex = 3;
            // 
            // dataPrestito
            // 
            this.dataPrestito.Location = new System.Drawing.Point(268, 140);
            this.dataPrestito.Name = "dataPrestito";
            this.dataPrestito.Size = new System.Drawing.Size(267, 26);
            this.dataPrestito.TabIndex = 4;
            // 
            // txtLibro
            // 
            this.txtLibro.Location = new System.Drawing.Point(268, 78);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(267, 26);
            this.txtLibro.TabIndex = 5;
            this.txtLibro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(268, 25);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(267, 26);
            this.txtCliente.TabIndex = 6;
            this.txtCliente.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cliente:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Libro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data Prestito:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data di Scadenza:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data di Consegna:";
            // 
            // InserisciPrestitoForm
            // 
            this.ClientSize = new System.Drawing.Size(723, 443);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.dataPrestito);
            this.Controls.Add(this.dataConsegna);
            this.Controls.Add(this.dataScadenza);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnConferma);
            this.Name = "InserisciPrestitoForm";
            this.Text = "Inserisci Prestito";
            this.Load += new System.EventHandler(this.InserisciPrestitoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.DateTimePicker dataScadenza;
        private System.Windows.Forms.DateTimePicker dataConsegna;
        private System.Windows.Forms.DateTimePicker dataPrestito;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}