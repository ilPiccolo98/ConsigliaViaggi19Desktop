using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsigliaViaggi19
{
    public partial class RicercaPersonalizzata : Form
    {
        public RicercaPersonalizzata()
        {
            InitializeComponent();
            Parametri = new ParametriRicercaStrutture();
            valutazioneMinimaComboBox.SelectedIndex = 0;
            valutazioneMassimaComboBox.SelectedIndex = valutazioneMassimaComboBox.Items.Count - 1;
            InitCitta();
            Parametri.ValutazioneMediaMinima = int.Parse(valutazioneMinimaComboBox.SelectedItem.ToString());
            Parametri.ValutazioneMediaMassima = int.Parse(valutazioneMassimaComboBox.SelectedItem.ToString());
            Parametri.Citta = cittaComboBox.Text;
        }

        public ParametriRicercaStrutture Parametri { get; set; }

        private void InitCitta()
        {
            try
            {
                cittaComboBox.Items.Clear();
                List<string> citta = Queries.GetCitta();
                cittaComboBox.Items.AddRange(citta.ToArray());
                cittaComboBox.Items.Add("Tutte le città");
                cittaComboBox.SelectedIndex = cittaComboBox.Items.Count - 1;
            }
            catch(SqlException)
            {
                MessageBox.Show("Connessione assente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private bool ValutazioniCorrette()
        {
            return (valutazioneMinimaComboBox.SelectedIndex <= valutazioneMassimaComboBox.SelectedIndex);
        }

        private void applicaButton_Click(object sender, EventArgs e)
        {
            if (ValutazioniCorrette())
            {
                Parametri.ValutazioneMediaMinima = int.Parse(valutazioneMinimaComboBox.SelectedItem.ToString());
                Parametri.ValutazioneMediaMassima = int.Parse(valutazioneMassimaComboBox.SelectedItem.ToString());
                Parametri.Citta = cittaComboBox.Text;
                Close();
            }
            else
                MessageBox.Show("Valutazione media minima e massima non valide", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
