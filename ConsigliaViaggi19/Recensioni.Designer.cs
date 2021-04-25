namespace ConsigliaViaggi19
{
    partial class Recensioni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.ordinaComboBox = new System.Windows.Forms.ComboBox();
            this.aggiornaPulsante = new System.Windows.Forms.Button();
            this.recensioniListView = new System.Windows.Forms.ListView();
            this.dettagliUtenteColonna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dettagliRecensioneColonna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statoColonna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dettagliStrutturaColonna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ordinaComboBox
            // 
            this.ordinaComboBox.FormattingEnabled = true;
            this.ordinaComboBox.Items.AddRange(new object[] {
            "Non lette",
            "Dal più recente",
            "Dal meno recente"});
            this.ordinaComboBox.Location = new System.Drawing.Point(12, 8);
            this.ordinaComboBox.Name = "ordinaComboBox";
            this.ordinaComboBox.Size = new System.Drawing.Size(121, 21);
            this.ordinaComboBox.TabIndex = 1;
            this.ordinaComboBox.Text = "Ordina";
            this.ordinaComboBox.SelectedIndexChanged += new System.EventHandler(this.ordinaComboBox_SelectedIndexChanged);
            // 
            // aggiornaPulsante
            // 
            this.aggiornaPulsante.Location = new System.Drawing.Point(139, 6);
            this.aggiornaPulsante.Name = "aggiornaPulsante";
            this.aggiornaPulsante.Size = new System.Drawing.Size(75, 23);
            this.aggiornaPulsante.TabIndex = 2;
            this.aggiornaPulsante.Text = "Aggiorna";
            this.aggiornaPulsante.UseVisualStyleBackColor = true;
            this.aggiornaPulsante.Click += new System.EventHandler(this.aggiornaPulsante_Click);
            // 
            // recensioniListView
            // 
            this.recensioniListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recensioniListView.BackColor = System.Drawing.Color.LightGreen;
            this.recensioniListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dettagliUtenteColonna,
            this.dettagliRecensioneColonna,
            this.statoColonna,
            this.dettagliStrutturaColonna});
            this.recensioniListView.ForeColor = System.Drawing.Color.Black;
            this.recensioniListView.GridLines = true;
            this.recensioniListView.HideSelection = false;
            this.recensioniListView.Location = new System.Drawing.Point(17, 49);
            this.recensioniListView.Margin = new System.Windows.Forms.Padding(2);
            this.recensioniListView.Name = "recensioniListView";
            this.recensioniListView.Size = new System.Drawing.Size(942, 552);
            this.recensioniListView.TabIndex = 0;
            this.recensioniListView.UseCompatibleStateImageBehavior = false;
            this.recensioniListView.View = System.Windows.Forms.View.Details;
            this.recensioniListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.recensioniListView_MouseDoubleClick);
            // 
            // dettagliUtenteColonna
            // 
            this.dettagliUtenteColonna.Text = "Dettagli Utente";
            this.dettagliUtenteColonna.Width = 204;
            // 
            // dettagliRecensioneColonna
            // 
            this.dettagliRecensioneColonna.Text = "Dettagli Recensione";
            this.dettagliRecensioneColonna.Width = 162;
            // 
            // statoColonna
            // 
            this.statoColonna.Text = "Stato Recensione";
            this.statoColonna.Width = 202;
            // 
            // dettagliStrutturaColonna
            // 
            this.dettagliStrutturaColonna.Text = "Dettagli Struttura";
            this.dettagliStrutturaColonna.Width = 255;
            // 
            // Recensioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(970, 612);
            this.Controls.Add(this.recensioniListView);
            this.Controls.Add(this.aggiornaPulsante);
            this.Controls.Add(this.ordinaComboBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(398, 474);
            this.Name = "Recensioni";
            this.Text = "ConsigliaViaggi19 - Recensioni";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox ordinaComboBox;
        private System.Windows.Forms.Button aggiornaPulsante;
        private System.Windows.Forms.ListView recensioniListView;
        private System.Windows.Forms.ColumnHeader dettagliUtenteColonna;
        private System.Windows.Forms.ColumnHeader dettagliRecensioneColonna;
        private System.Windows.Forms.ColumnHeader statoColonna;
        private System.Windows.Forms.ColumnHeader dettagliStrutturaColonna;
    }
}