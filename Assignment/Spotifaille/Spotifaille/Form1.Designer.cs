
namespace Spotifaille
{
    partial class connexionForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connexionForm));
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.mdpTextBox = new System.Windows.Forms.TextBox();
            this.connexionButton = new System.Windows.Forms.Button();
            this.mdpOublieLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConnexionPanel = new System.Windows.Forms.Panel();
            this.nbUserLabel = new System.Windows.Forms.Label();
            this.inscritpionLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ConnexionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.idTextBox.Location = new System.Drawing.Point(54, 174);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(279, 27);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.Text = "Adresse e-mail";
            this.idTextBox.Enter += new System.EventHandler(this.idTextBox_Enter);
            this.idTextBox.Leave += new System.EventHandler(this.idTextBox_Leave);
            // 
            // mdpTextBox
            // 
            this.mdpTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mdpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdpTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.mdpTextBox.Location = new System.Drawing.Point(54, 215);
            this.mdpTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.mdpTextBox.Name = "mdpTextBox";
            this.mdpTextBox.Size = new System.Drawing.Size(279, 27);
            this.mdpTextBox.TabIndex = 3;
            this.mdpTextBox.Text = "Mot de passe";
            this.mdpTextBox.Enter += new System.EventHandler(this.mdpTextBox_Enter);
            this.mdpTextBox.Leave += new System.EventHandler(this.mdpTextBox_Leave);
            // 
            // connexionButton
            // 
            this.connexionButton.BackColor = System.Drawing.Color.White;
            this.connexionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connexionButton.ForeColor = System.Drawing.Color.Black;
            this.connexionButton.Location = new System.Drawing.Point(111, 296);
            this.connexionButton.Margin = new System.Windows.Forms.Padding(2);
            this.connexionButton.Name = "connexionButton";
            this.connexionButton.Size = new System.Drawing.Size(154, 45);
            this.connexionButton.TabIndex = 4;
            this.connexionButton.Text = "Connexion";
            this.connexionButton.UseVisualStyleBackColor = false;
            this.connexionButton.Click += new System.EventHandler(this.connexionButton_Click);
            // 
            // mdpOublieLinkLabel
            // 
            this.mdpOublieLinkLabel.AutoSize = true;
            this.mdpOublieLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdpOublieLinkLabel.LinkColor = System.Drawing.Color.DarkGray;
            this.mdpOublieLinkLabel.Location = new System.Drawing.Point(180, 259);
            this.mdpOublieLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mdpOublieLinkLabel.Name = "mdpOublieLinkLabel";
            this.mdpOublieLinkLabel.Size = new System.Drawing.Size(153, 18);
            this.mdpOublieLinkLabel.TabIndex = 6;
            this.mdpOublieLinkLabel.TabStop = true;
            this.mdpOublieLinkLabel.Text = "Mot de passe oublié ?";
            this.mdpOublieLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mdpOublieLinkLabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ConnexionPanel
            // 
            this.ConnexionPanel.Controls.Add(this.nbUserLabel);
            this.ConnexionPanel.Controls.Add(this.inscritpionLinkLabel);
            this.ConnexionPanel.Controls.Add(this.label1);
            this.ConnexionPanel.Controls.Add(this.pictureBox1);
            this.ConnexionPanel.Controls.Add(this.idTextBox);
            this.ConnexionPanel.Controls.Add(this.mdpOublieLinkLabel);
            this.ConnexionPanel.Controls.Add(this.mdpTextBox);
            this.ConnexionPanel.Controls.Add(this.connexionButton);
            this.ConnexionPanel.ForeColor = System.Drawing.Color.Black;
            this.ConnexionPanel.Location = new System.Drawing.Point(682, 234);
            this.ConnexionPanel.Name = "ConnexionPanel";
            this.ConnexionPanel.Size = new System.Drawing.Size(379, 467);
            this.ConnexionPanel.TabIndex = 8;
            // 
            // nbUserLabel
            // 
            this.nbUserLabel.AutoSize = true;
            this.nbUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbUserLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.nbUserLabel.Location = new System.Drawing.Point(95, 370);
            this.nbUserLabel.Name = "nbUserLabel";
            this.nbUserLabel.Size = new System.Drawing.Size(189, 18);
            this.nbUserLabel.TabIndex = 10;
            this.nbUserLabel.Text = "Rejoignez les x utilisateurs !";
            // 
            // inscritpionLinkLabel
            // 
            this.inscritpionLinkLabel.AutoSize = true;
            this.inscritpionLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscritpionLinkLabel.LinkColor = System.Drawing.Color.White;
            this.inscritpionLinkLabel.Location = new System.Drawing.Point(110, 409);
            this.inscritpionLinkLabel.Name = "inscritpionLinkLabel";
            this.inscritpionLinkLabel.Size = new System.Drawing.Size(164, 29);
            this.inscritpionLinkLabel.TabIndex = 9;
            this.inscritpionLinkLabel.TabStop = true;
            this.inscritpionLinkLabel.Text = "Inscrivez-vous";
            this.inscritpionLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(95, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vous n\'avez pas de compte ?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(1660, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DarkGray;
            this.button2.Location = new System.Drawing.Point(1624, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 25);
            this.button2.TabIndex = 10;
            this.button2.Text = "O";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.DarkGray;
            this.button3.Location = new System.Drawing.Point(1588, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 25);
            this.button3.TabIndex = 11;
            this.button3.Text = "_";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // connexionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1693, 919);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConnexionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "connexionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spotifaille - Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ConnexionPanel.ResumeLayout(false);
            this.ConnexionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox mdpTextBox;
        private System.Windows.Forms.Button connexionButton;
        private System.Windows.Forms.LinkLabel mdpOublieLinkLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel ConnexionPanel;
        private System.Windows.Forms.Label nbUserLabel;
        private System.Windows.Forms.LinkLabel inscritpionLinkLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

