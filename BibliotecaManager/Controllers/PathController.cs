using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaManager.Controllers
{
    public class PathController
    {
        public string FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BibliotecaManager\\"; //default path

        //    public PathController(string path)
        //    {
        //        FolderPath = path ?? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BibliotecaManager\\";
        //}
        public string updatePath(string newPath)
        {
            FolderPath = newPath;
            MessageBox.Show("Percorso aggiornato: " + FolderPath, "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return FolderPath;
            
        }


    }
}
