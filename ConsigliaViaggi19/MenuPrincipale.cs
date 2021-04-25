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
using System.IO;

namespace ConsigliaViaggi19
{
    public partial class MenuPrincipale : Form
    {

        public MenuPrincipale()
        {
            InitializeComponent();
            recensioni = new Recensioni();
            ricercaPersonalizzata = new RicercaPersonalizzata();
            strutture = new List<Struttura>();
        }

        protected override void OnShown(EventArgs e)
        {
            InitTitle();
            InitTipiStrutture();
            struttureListView.Items.Clear();
        }

        private void InitTitle()
        {
            Text = $"ConsigliaViaggi19 - {UsernameAmministratore}";
        }

        private void InitTipiStrutture()
        {
            try
            {
                tipiStruttureComboBox.Items.Clear();
                string[] tipiStrutture = Queries.GetTipiStrutture().ToArray();
                tipiStruttureComboBox.Items.AddRange(tipiStrutture);
                tipiStruttureComboBox.Items.Add("Tutti i tipi");
                tipiStruttureComboBox.SelectedIndex = tipiStruttureComboBox.Items.Count - 1;
            }
            catch(SqlException)
            {
                MessageBox.Show("Errore", "Connessione assente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void notificheButton_Click(object sender, EventArgs e)
        {
            recensioni.UsaIdStruttura = false; //Modificare sequence
            recensioni.ShowDialog();
        }

        private void ImpostaStruttureListView(List<Struttura> strutture)
        {
            struttureListView.Items.Clear();
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(100, 70);
            struttureListView.SmallImageList = imageList;
            for(int i = 0; i != strutture.Count; ++i)
            {
                imageList.Images.Add(strutture[i].Immagine);
                struttureListView.Items.Add(new ListViewItem(new[] { "", $"Nome: {strutture[i].Nome}\nIndirizzo: {strutture[i].Indirizzo}",
                $"Categoria: {strutture[i].Tipo}\nValutazione media: {strutture[i].ValutazioneMedia}"}, i));
            }
            struttureListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            struttureListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            struttureListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void cercaButton_Click(object sender, EventArgs e)
        {
            try
            {
                ricercaPersonalizzata.Parametri.NomeStruttura = nomeTextBox.Text;
                ricercaPersonalizzata.Parametri.TipoStruttura = tipiStruttureComboBox.SelectedItem.ToString();
                strutture = Queries.GetStrutture(ricercaPersonalizzata.Parametri);
                if (strutture.Count == 0)
                    MessageBox.Show("Nessun risultato ottenuto durante la ricerca", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    ImpostaStruttureListView(strutture);
            }
            catch(SqlException)
            {
                MessageBox.Show("Connessione assente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ricercaPersonalizzataLinkLabel_Click(object sender, EventArgs e)
        {
            ricercaPersonalizzata.ShowDialog();
        }

        private void struttureListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = struttureListView.SelectedIndices[0];
            recensioni.IdStruttura = strutture[index].Id;
            recensioni.UsaIdStruttura = true;
            recensioni.ShowDialog();
        }

        public string UsernameAmministratore { get; set; }
        private Recensioni recensioni;
        private RicercaPersonalizzata ricercaPersonalizzata;
        private List<Struttura> strutture;
    }
}
