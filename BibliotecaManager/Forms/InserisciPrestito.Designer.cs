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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.autoriComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.libroComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(114, 416);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(211, 88);
            this.btnConferma.TabIndex = 0;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(386, 416);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(196, 88);
            this.btnAnnulla.TabIndex = 1;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // dataScadenza
            // 
            this.dataScadenza.Location = new System.Drawing.Point(315, 275);
            this.dataScadenza.Name = "dataScadenza";
            this.dataScadenza.Size = new System.Drawing.Size(267, 26);
            this.dataScadenza.TabIndex = 2;
            // 
            // dataConsegna
            // 
            this.dataConsegna.Location = new System.Drawing.Point(315, 345);
            this.dataConsegna.Name = "dataConsegna";
            this.dataConsegna.Size = new System.Drawing.Size(267, 26);
            this.dataConsegna.TabIndex = 3;
            // 
            // dataPrestito
            // 
            this.dataPrestito.Location = new System.Drawing.Point(315, 201);
            this.dataPrestito.Name = "dataPrestito";
            this.dataPrestito.Size = new System.Drawing.Size(267, 26);
            this.dataPrestito.TabIndex = 4;
            // 
            // txtLibro
            // 
            this.txtLibro.Location = new System.Drawing.Point(314, 78);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(267, 26);
            this.txtLibro.TabIndex = 5;
            this.txtLibro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.label3.Location = new System.Drawing.Point(56, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data Prestito:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data di Scadenza:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data di Consegna:";
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(319, 28);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(262, 28);
            this.clienteComboBox.TabIndex = 13;
            this.clienteComboBox.SelectedIndexChanged += new System.EventHandler(this.clienteComboBox_SelectedIndexChanged);
            // 
            // autoriComboBox
            // 
            this.autoriComboBox.FormattingEnabled = true;
            this.autoriComboBox.Location = new System.Drawing.Point(314, 133);
            this.autoriComboBox.Name = "autoriComboBox";
            this.autoriComboBox.Size = new System.Drawing.Size(267, 28);
            this.autoriComboBox.TabIndex = 14;
            this.autoriComboBox.SelectedIndexChanged += new System.EventHandler(this.autoriComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Autore";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // libroComboBox
            // 
            this.libroComboBox.FormattingEnabled = true;
            this.libroComboBox.Location = new System.Drawing.Point(613, 82);
            this.libroComboBox.Name = "libroComboBox";
            this.libroComboBox.Size = new System.Drawing.Size(223, 28);
            this.libroComboBox.TabIndex = 16;
            this.libroComboBox.SelectedIndexChanged += new System.EventHandler(this.libroComboBox_SelectedIndexChanged);
            // 
            // InserisciPrestitoForm
            // 
            this.ClientSize = new System.Drawing.Size(921, 559);
            this.Controls.Add(this.libroComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.autoriComboBox);
            this.Controls.Add(this.clienteComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.ComboBox autoriComboBox;
        private System.Windows.Forms.ComboBox libroComboBox;
        private System.Windows.Forms.Label label6;
        
    }
}