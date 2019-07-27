using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PosDecode
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /***
         * Decodifica una richiesta
         */
        private void btnReqDecode_Click(object sender, EventArgs e)
        {
            lvData.Items.Clear();
            lvData.Items.Add("Primo1 ");
            lvData.Items.Add("Primo2 ");

            ListViewItem row = new ListViewItem(new string[] { "Pri1", "Pri2" });
            lvData.Items.Add(row);

            // Lettura dati dalla TextBox
            String data = tbRichiesta.Text;

            // Analisi preliminare
            if (data.Length == 0)
                return;
            // Normalizzo la stringa togliendo tutti gli spazi
            data = data.Replace(" ", "");
            data = data.ToUpper();

            if (data.Length % 1 == 1)
                MessageBox.Show("Contenuto non formattato correttamente - numero dispari di digit", "PosDecode", MessageBoxButtons.OK, MessageBoxIcon.Error);

            lvData.Items.Add(new ListViewItem(new string[] { "Stringa da analizzare", data }));

            if (data.Length < 2 * 15) {     // Lunghezza minima TBV
                MessageBox.Show("Lunghezza minima non soddisfatta", "PosDecode", MessageBoxButtons.OK, MessageBoxIcon.Error);
              return;
            }

            // Analisi comando
            String command = data.Remove(2 * 11, 2);
            switch (command)
            {
                case "00": break;
                default:
                    lvData.Items.Add(new ListViewItem(new string[] { command, "Comando non ancora supportato" }));
                    break;
            }
        }


        /**
         * Decodifica una risposta POS
         */
        private void btnResDecode_Click(object sender, EventArgs e)
        {
            lvData.Items.Clear();

            lvData.Items.Add(new ListViewItem(new string[] { "Ciao", "Salve" }));

            String[] row = new string[] { "Sec1", "Sec2" };
            lvData.Items.Add("Sec1 ");
            lvData.Items.Add("Sec2 ");
        }


        /****
         * Sul caricamento della form
         */
        private void MainForm_Load(object sender, EventArgs e)
        {
            lvData.View = View.Details;
            lvData.FullRowSelect = true;
            lvData.Columns.Add("Bytes");
            lvData.Columns.Add("Val");
        }

        /**
         * Esportazione dati decodificati
         */
        private void btnExport_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            DialogResult res = dlg.ShowDialog();
            if (res == DialogResult.Cancel)
                return;

            List<String> rows = new List<string>();
            foreach(ListView item in lvData.Items)
            {
                // rows.Add(row[0] + " - " + row[1]);
                rows.Add("row[0]" + " - " + "row[1]");
            }

            String filename = dlg.FileName;
            File.WriteAllLines(filename, rows);

            MessageBox.Show("File " + filename + " salvato", "PosDecode", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
