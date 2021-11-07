using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Spotifaille
{
    public partial class connexionForm : Form
    {
        string paramEmailText = "Adresse e-mail";
        string paramMdpText = "Mot de passe";

        private List<User> userList;
        private FileReader fr;

        static public MainForm f2;
        static public connexionForm f1;

        public connexionForm()
        {
            InitializeComponent();
            f1 = this;
            fr = new FileReader();
            userList = new List<User>();
            userList = fr.ReadUserData();

            mdpTextBox.KeyDown += MdpTextBox_KeyPress;
            nbUserLabel.Text = string.Format("Rejoignez les {0} utilisateurs", userList.Count());
        }

        private void MdpTextBox_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                connexionButton_Click(sender, e);
            }
        }

        private void connexionButton_Click(object sender, EventArgs e)
        {
            string mail = idTextBox.Text;
            string mdp = mdpTextBox.Text;

            foreach (User user in userList)
            {
                if (user.MailAddress == mail)
                {
                    if (user.PassWord == mdp)
                    {
                        MessageBox.Show("Bienvenue " + mail + " sur Spotifaille", "Connexion réussie");
                        f2 = new MainForm(user);
                        f2.Show();
                        f1.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Mot de passe incorrect !\nMot de passe oublié ?", "Connexion refusé");
                        return;
                    }
                }
            }
            MessageBox.Show("Identifiant incorrect/inconnue !\nCréer un compte ?", "Connexion refusé");
        }

        private void mdpOublieLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Bah dommage", "Mot de passe oublié");
        }

        private void idTextBox_Enter(object sender, EventArgs e)
        {
            if (string.Equals(idTextBox.Text, paramEmailText))
            {
                idTextBox.Text = "";
                idTextBox.Font = new Font(idTextBox.Font, FontStyle.Regular);
                idTextBox.ForeColor = Color.White;
            }
        }

        private void idTextBox_Leave(object sender, EventArgs e)
        {
            if (string.Equals(idTextBox.Text, ""))
            {
                idTextBox.Text = paramEmailText;
                idTextBox.Font = new Font(idTextBox.Font, FontStyle.Italic);
                idTextBox.ForeColor = Color.DarkGray;
            }
        }

        private void mdpTextBox_Enter(object sender, EventArgs e)
        {
            if (string.Equals(mdpTextBox.Text, paramMdpText))
            {
                mdpTextBox.Text = "";
                mdpTextBox.Font = new Font(mdpTextBox.Font, FontStyle.Regular);
                mdpTextBox.ForeColor = Color.White;
                mdpTextBox.UseSystemPasswordChar = true;
            }
        }

        private void mdpTextBox_Leave(object sender, EventArgs e)
        {
            if (string.Equals(mdpTextBox.Text, ""))
            {
                mdpTextBox.Text = paramMdpText;
                mdpTextBox.Font = new Font(mdpTextBox.Font, FontStyle.Italic);
                mdpTextBox.ForeColor = Color.DarkGray;
                mdpTextBox.UseSystemPasswordChar = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (idTextBox.Text != paramEmailText)
            {
                User user = new User();
                user.MailAddress = idTextBox.Text;
                user.PassWord = mdpTextBox.Text;

                foreach (User _user in userList)
                {
                    if (_user.MailAddress == user.MailAddress)
                    {
                        MessageBox.Show("Adresse e-mail déjà utilisé !", "Erreur création compte");
                        return;
                    }
                }

                fr.AddUserData(user);

                userList = fr.ReadUserData();

                MessageBox.Show("Votre compte a été créé, vous pouvez désormais vous connecter.", "Compte créé", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Veuillez d'abord rentrer votre adresse e-mail et votre mot de passe.", "Manque d'information");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
