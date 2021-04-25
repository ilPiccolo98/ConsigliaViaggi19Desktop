using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsigliaViaggi19
{
    public partial class Recensioni : Form
    {
        public Recensioni()
        {
            InitializeComponent();
            recensioni = new List<Recensione>();
            visualizzaRecensione = new VisualizzaRecensione();
        }

        public bool UsaIdStruttura { get; set; }
        public int IdStruttura { get; set; } 

        protected override void OnShown(EventArgs e)
        {
            OttieniRecensioniDalDatabase();
            if(!(recensioni is null) && recensioni.Count == 0)
            {
                MessageBox.Show("Nessun commento disponibile", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            else if(!(recensioni is null))
            {
                ordinaComboBox.SelectedIndex = 0;
                OrdinaRecensioni();
            }
        }

        private void OttieniRecensioniDalDatabase()
        {
            try
            {
                recensioni = null;
                if (!UsaIdStruttura)
                    recensioni = Queries.GetRecensioni();
                else
                    recensioni = Queries.GetRecensioni(IdStruttura);
            }
            catch(SqlException)
            {
                MessageBox.Show("Nessuna connessione", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void OrdinaPerRecensioniNonLette()
        {
            var recensioniNonLette = from recensione in recensioni where recensione.StatoApprovazione == "in attesa" select recensione;
            var recensioniLette = from recensione in recensioni
                                  where recensione.StatoApprovazione != "in attesa"
                                  orderby recensione.DataCreazione descending
                                  select recensione;
            List<Recensione> recensioniUnione = new List<Recensione>();
            recensioniUnione.AddRange(recensioniNonLette);
            recensioniUnione.AddRange(recensioniLette);
            recensioni = recensioniUnione;
        }

        private void OrdinaRecensioniDalPiuRecente()
        {
            var recensioniOrdinate = from recensione in recensioni orderby recensione.DataCreazione descending select recensione;
            recensioni = new List<Recensione>(recensioniOrdinate);
        }

        private void OrdinaRecensioniDalMenoRecente()
        {
            var recensioniOrdinate = from recensione in recensioni orderby recensione.DataCreazione ascending select recensione;
            recensioni = new List<Recensione>(recensioniOrdinate);
        }

        private void InitRecensioniListViewItems()
        {
            recensioniListView.Items.Clear();
            ImageList listaImmagini = new ImageList();
            listaImmagini.ImageSize = new Size(10, 70);
            recensioniListView.SmallImageList = listaImmagini;
            foreach (Recensione r in recensioni)
            {
                recensioniListView.Items.Add(new ListViewItem(new[] {$"Nome: {r.NomeUtente}\nCognome: {r.CognomeUtente}\nNickname: {r.NicknameUtente}",
                    $"Valutazione: {r.Valutazione}\nData creazione: {r.DataCreazione.ToString("dd/MM/yyyy")}",
                    $"Stato approvazione: {r.StatoApprovazione}", $"Nome: {r.NomeStruttura}\nTipo: {r.TipoStruttura}"}));
            }
            recensioniListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            recensioniListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            recensioniListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            recensioniListView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void ordinaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrdinaRecensioni();
        }

        private void OrdinaRecensioni()
        {
            switch (ordinaComboBox.SelectedIndex)
            {
                case 0:
                    OrdinaPerRecensioniNonLette();
                    break;
                case 1:
                    OrdinaRecensioniDalPiuRecente();
                    break;
                case 2:
                    OrdinaRecensioniDalMenoRecente();
                    break;
            }
            InitRecensioniListViewItems();
        }

        private void aggiornaPulsante_Click(object sender, EventArgs e)
        {
            OttieniRecensioniDalDatabase();
            OrdinaRecensioni();
        }

        private void recensioniListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            visualizzaRecensione.Recensione = recensioni[recensioniListView.SelectedIndices[0]];
            visualizzaRecensione.ShowDialog();
            if (visualizzaRecensione.PremutoApplica)
                InitRecensioniListViewItems();
        }

        private List<Recensione> recensioni;
        private VisualizzaRecensione visualizzaRecensione;
    }
}
