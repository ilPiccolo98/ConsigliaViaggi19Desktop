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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            menuPrincipale = new MenuPrincipale();
        }

        protected override void OnShown(EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AreTextBoxesEmpty())
                    MessageBox.Show("Inserire username e password", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (!Queries.IsAmministratoreEsistente(usernameTextBox.Text, passwordTextBox.Text))
                    MessageBox.Show("Username o password non valide", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Hide();
                    menuPrincipale.UsernameAmministratore = usernameTextBox.Text;
                    menuPrincipale.ShowDialog();
                    Show();
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    mostraPasswordCheckBox.Checked = false;
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Connessione assente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AreTextBoxesEmpty()
        {
            if (usernameTextBox.Text.Length != 0 && passwordTextBox.Text.Length != 0)
                return false;
            return true;
        }

        private void mostraPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mostraPasswordCheckBox.Checked)
                passwordTextBox.UseSystemPasswordChar = false;
            else
                passwordTextBox.UseSystemPasswordChar = true;
        }

        private MenuPrincipale menuPrincipale;
    }
}
