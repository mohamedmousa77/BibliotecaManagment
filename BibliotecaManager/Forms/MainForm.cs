using BibliotecaManager.Controllers;
using BibliotecaManager.Services;
using System;
using System.Windows.Forms;
namespace BibliotecaManager.Forms
{
    public partial class MainForm : Form
    {
        private PersonaController personaController;
        private DataStorageService storageService;
        private PrestitoController prestitoController;
        private LibroController libroController;
        private string folderPath;
        private void MainForm_Load(object sender, EventArgs e)
        {
            // inizializzazioni al caricamento
            InitializeComponent();
        }
        public MainForm()
        {
            InitializeComponent();
            InitializeMenu();
            //LoadForm(new Form { BackColor = Color.Orange });
            folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BibliotecaManager\\";
            personaController = new PersonaController();
            storageService = new DataStorageService();
            prestitoController = new PrestitoController();
            libroController = new LibroController(folderPath);
            

            try
            {
                var (autori, clienti, libri, prestiti) = storageService.CaricaTutti(folderPath);
                personaController.Autori = autori;
                personaController.Clienti = clienti;
                prestitoController.Prestiti = prestiti;
                libroController.Libri = libri;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il caricamento dei dati: {ex.Message}", "Errore", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        //private void LoadForm(Form form)
        //{
        //    //if (panelContent == null)
        //    //{
        //    //    MessageBox.Show("panelContent è null!");
        //    //    return;
        //    //}
        //    //panelContent.Controls.Clear();
        //    //form.TopLevel = false;
        //    //form.FormBorderStyle = FormBorderStyle.None;
        //    //form.Dock = DockStyle.Fill;
        //    //panelContent.Controls.Add(form);
        //    //form.Show();

        //    MessageBox.Show("Sto caricando il form...");

        //    if (panelContent == null)
        //    {
        //        MessageBox.Show("panelContent è null!");
        //        return;
        //    }

        //    //panelContent.Controls.Clear();

        //    form.TopLevel = false;
        //    form.FormBorderStyle = FormBorderStyle.None;
        //    form.Dock = DockStyle.Fill;
        //    form.BackColor = Color.Red; // forza un colore visibile

        //    //panelContent.Controls.Add(form);
        //    form.Show();

        //    MessageBox.Show("Form aggiunto a panelContent.");

        //}

        private void InitializeMenu()
        {
            var menuStrip = new MenuStrip();

            var gestioneMenu = new ToolStripMenuItem("Gestione");
            gestioneMenu.DropDownItems.Add("Autori", null, (s, e) => new AutoriForm(personaController, storageService, folderPath).ShowDialog());
            gestioneMenu.DropDownItems.Add("Clienti", null, (s, e) => new ClientiForm(personaController, storageService, folderPath).ShowDialog());
            gestioneMenu.DropDownItems.Add("Libri", null, (s, e) => new Gestione(libroController, storageService, folderPath).ShowDialog());
            gestioneMenu.DropDownItems.Add("Prestiti", null, (s, e) => new PrestitiForm(prestitoController, storageService, folderPath).ShowDialog());

            var statisticheMenu = new ToolStripMenuItem("Statiche");
            statisticheMenu.Click += (s, e) => new StatisticheForm(prestitoController.Prestiti).ShowDialog();

            var archivioMenu = new ToolStripMenuItem("Archivio");
            archivioMenu.DropDownItems.Add("Salva", null, (s, e) => SalvaArchivio());
            archivioMenu.DropDownItems.Add("Carica", null, (s, e) => CaricaArchivio());

            menuStrip.Items.Add(gestioneMenu);
            menuStrip.Items.Add(statisticheMenu);
            menuStrip.Items.Add(archivioMenu);
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }

        public void SalvaArchivio()
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Archivio salvato.");
                }
            }

        }

        public void CaricaArchivio()
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Archivio caricato.");
                }
            }
        }
        
        //private void btnGestione_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Clic ricevuto!");

        //    LoadForm(new Form { BackColor = Color.LightGreen }); // o GestioneForm
        //}

        //private void btnStatistiche_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Clic ricevuto!");

        //    LoadForm(new Form { BackColor = Color.Azure }); // o StatisticheForm
        //}

        //private void btnArchivio_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Clic ricevuto!");

        //    //LoadForm(new Form { BackColor = Color.Orange }); // o ArchivioForm

        //    //panelContent.Controls.Clear();
        //    Label lbl = new Label
        //    {
        //        Text = "Test Label",
        //        AutoSize = true,
        //        Location = new Point(10, 10),
        //        ForeColor = Color.Black
        //    };
        //    //panelContent.Controls.Add(lbl);
        //}

        
    }
}
