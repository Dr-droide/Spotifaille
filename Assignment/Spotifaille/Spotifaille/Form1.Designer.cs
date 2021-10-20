
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
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.mdpLabel = new System.Windows.Forms.Label();
            this.mdpTextBox = new System.Windows.Forms.TextBox();
            this.connexionButton = new System.Windows.Forms.Button();
            this.creerCompteButton = new System.Windows.Forms.Button();
            this.mdpOublieLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(59, 40);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(69, 17);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Identifiant";
            this.idLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(188, 40);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(180, 22);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.Text = "Rentrez votre adresse mail";
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mdpLabel
            // 
            this.mdpLabel.AutoSize = true;
            this.mdpLabel.Location = new System.Drawing.Point(48, 93);
            this.mdpLabel.Name = "mdpLabel";
            this.mdpLabel.Size = new System.Drawing.Size(93, 17);
            this.mdpLabel.TabIndex = 2;
            this.mdpLabel.Text = "Mot de passe";
            // 
            // mdpTextBox
            // 
            this.mdpTextBox.Location = new System.Drawing.Point(187, 93);
            this.mdpTextBox.Name = "mdpTextBox";
            this.mdpTextBox.Size = new System.Drawing.Size(181, 22);
            this.mdpTextBox.TabIndex = 3;
            this.mdpTextBox.Text = "Rentrez votre mot de passe";
            this.mdpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // connexionButton
            // 
            this.connexionButton.Location = new System.Drawing.Point(191, 162);
            this.connexionButton.Name = "connexionButton";
            this.connexionButton.Size = new System.Drawing.Size(169, 39);
            this.connexionButton.TabIndex = 4;
            this.connexionButton.Text = "Se connecter";
            this.connexionButton.UseVisualStyleBackColor = true;
            // 
            // creerCompteButton
            // 
            this.creerCompteButton.Location = new System.Drawing.Point(34, 162);
            this.creerCompteButton.Name = "creerCompteButton";
            this.creerCompteButton.Size = new System.Drawing.Size(133, 39);
            this.creerCompteButton.TabIndex = 5;
            this.creerCompteButton.Text = "Créer un compte";
            this.creerCompteButton.UseVisualStyleBackColor = true;
            // 
            // mdpOublieLinkLabel
            // 
            this.mdpOublieLinkLabel.AutoSize = true;
            this.mdpOublieLinkLabel.LinkColor = System.Drawing.Color.DimGray;
            this.mdpOublieLinkLabel.Location = new System.Drawing.Point(204, 131);
            this.mdpOublieLinkLabel.Name = "mdpOublieLinkLabel";
            this.mdpOublieLinkLabel.Size = new System.Drawing.Size(147, 17);
            this.mdpOublieLinkLabel.TabIndex = 6;
            this.mdpOublieLinkLabel.TabStop = true;
            this.mdpOublieLinkLabel.Text = "Mot de passe oublié ?";
            // 
            // connexionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 238);
            this.Controls.Add(this.mdpOublieLinkLabel);
            this.Controls.Add(this.creerCompteButton);
            this.Controls.Add(this.connexionButton);
            this.Controls.Add(this.mdpTextBox);
            this.Controls.Add(this.mdpLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "connexionForm";
            this.Text = "Connectez-vous";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label mdpLabel;
        private System.Windows.Forms.TextBox mdpTextBox;
        private System.Windows.Forms.Button connexionButton;
        private System.Windows.Forms.Button creerCompteButton;
        private System.Windows.Forms.LinkLabel mdpOublieLinkLabel;
    }
}

