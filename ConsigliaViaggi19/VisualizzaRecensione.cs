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
    public partial class VisualizzaRecensione : Form
    {
        public VisualizzaRecensione()
        {
            InitializeComponent();
            PremutoApplica = false;
        }

        public Recensione Recensione { get; set; }

        protected override void OnShown(EventArgs e)
        {
            PremutoApplica = false;
            nicknameTextBox.Text = Recensione.NicknameUtente;
            nomeTextBox.Text = Recensione.NomeUtente;
            cognomeTextBox.Text = Recensione.CognomeUtente;
            commentoRichTextBox.Text = Recensione.Commento;
            valutazioneTextBox.Text = Recensione.Valutazione.ToString() + " Stelle";
            dataTextBox.Text = Recensione.DataCreazione.ToString("dd/MM/yyyy");
            nomeStrutturaTextBox.Text = Recensione.NomeStruttura;
            tipoStrutturaTextBox.Text = Recensione.TipoStruttura;
            switch(Recensione.StatoApprovazione)
            {
                case "approvato":
                    approvatoRadioButton.Checked = true;
                    nonApprovatoRadioButton.Checked = false;
                    break;
                case "non approvato":
                    approvatoRadioButton.Checked = false;
                    nonApprovatoRadioButton.Checked = true;
                    break;
                case "in attesa":
                    approvatoRadioButton.Checked = false;
                    nonApprovatoRadioButton.Checked = false;
                    break;
            }
        }

        private bool SelezionatoRadioButton()
        {
            return !(!approvatoRadioButton.Checked && !nonApprovatoRadioButton.Checked);
        }

        private void CambiaStatoRecensione()
        {
            try
            {
                string stato = "";
                if (approvatoRadioButton.Checked)
                    stato = "approvato";
                else
                    stato = "non approvato";
                Queries.CambiaStatoRecensione(Recensione.IdRecensione, stato);
                MessageBox.Show("Modifiche applicate con successo", "Stato cambiato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PremutoApplica = true;
                Recensione.StatoApprovazione = stato;
                Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Nessuna connessione", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void applicaButton_Click(object sender, EventArgs e)
        {
            if (!SelezionatoRadioButton())
                MessageBox.Show("Nessuno stato selezionato", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult dialogResult = MessageBox.Show("Sicuro di voler cambiare lo stato della recensione?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dialogResult == DialogResult.Yes)
                    CambiaStatoRecensione();
            }
        }

        public bool PremutoApplica { get; private set; }
    }
}
