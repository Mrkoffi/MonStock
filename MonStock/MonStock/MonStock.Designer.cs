namespace MonStock
{
    partial class MonStock
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesEntreesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesSortiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesFournisseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manuelDutlilisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneLicencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surMonStock10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nousContacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faireUneSauvegardeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurerUneSauvegardeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesSauvegardesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aProposToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesEntreesToolStripMenuItem,
            this.mesSortiesToolStripMenuItem,
            this.mesCommandesToolStripMenuItem,
            this.mesFournisseursToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // mesEntreesToolStripMenuItem
            // 
            this.mesEntreesToolStripMenuItem.Name = "mesEntreesToolStripMenuItem";
            this.mesEntreesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.mesEntreesToolStripMenuItem.Text = "Mes Entrees";
            // 
            // mesSortiesToolStripMenuItem
            // 
            this.mesSortiesToolStripMenuItem.Name = "mesSortiesToolStripMenuItem";
            this.mesSortiesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.mesSortiesToolStripMenuItem.Text = "Mes Sorties";
            // 
            // mesCommandesToolStripMenuItem
            // 
            this.mesCommandesToolStripMenuItem.Name = "mesCommandesToolStripMenuItem";
            this.mesCommandesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.mesCommandesToolStripMenuItem.Text = "Mes Commandes";
            // 
            // mesFournisseursToolStripMenuItem
            // 
            this.mesFournisseursToolStripMenuItem.Name = "mesFournisseursToolStripMenuItem";
            this.mesFournisseursToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.mesFournisseursToolStripMenuItem.Text = "Mes Fournisseurs";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuelDutlilisationToolStripMenuItem,
            this.ajouterUneLicencesToolStripMenuItem,
            this.surMonStock10ToolStripMenuItem,
            this.nousContacterToolStripMenuItem});
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // manuelDutlilisationToolStripMenuItem
            // 
            this.manuelDutlilisationToolStripMenuItem.Name = "manuelDutlilisationToolStripMenuItem";
            this.manuelDutlilisationToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.manuelDutlilisationToolStripMenuItem.Text = "Manuel d\'utlilisation";
            // 
            // ajouterUneLicencesToolStripMenuItem
            // 
            this.ajouterUneLicencesToolStripMenuItem.Name = "ajouterUneLicencesToolStripMenuItem";
            this.ajouterUneLicencesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ajouterUneLicencesToolStripMenuItem.Text = "Ajouter une licence";
            this.ajouterUneLicencesToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneLicencesToolStripMenuItem_Click);
            // 
            // surMonStock10ToolStripMenuItem
            // 
            this.surMonStock10ToolStripMenuItem.Name = "surMonStock10ToolStripMenuItem";
            this.surMonStock10ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.surMonStock10ToolStripMenuItem.Text = "Sur MonStock 1.0";
            // 
            // nousContacterToolStripMenuItem
            // 
            this.nousContacterToolStripMenuItem.Name = "nousContacterToolStripMenuItem";
            this.nousContacterToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.nousContacterToolStripMenuItem.Text = "Nous contacter";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faireUneSauvegardeToolStripMenuItem,
            this.restaurerUneSauvegardeToolStripMenuItem,
            this.mesSauvegardesToolStripMenuItem});
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // faireUneSauvegardeToolStripMenuItem
            // 
            this.faireUneSauvegardeToolStripMenuItem.Name = "faireUneSauvegardeToolStripMenuItem";
            this.faireUneSauvegardeToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.faireUneSauvegardeToolStripMenuItem.Text = "Faire une sauvegarde";
            // 
            // restaurerUneSauvegardeToolStripMenuItem
            // 
            this.restaurerUneSauvegardeToolStripMenuItem.Name = "restaurerUneSauvegardeToolStripMenuItem";
            this.restaurerUneSauvegardeToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.restaurerUneSauvegardeToolStripMenuItem.Text = "Restaurer une sauvegarde";
            // 
            // mesSauvegardesToolStripMenuItem
            // 
            this.mesSauvegardesToolStripMenuItem.Name = "mesSauvegardesToolStripMenuItem";
            this.mesSauvegardesToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.mesSauvegardesToolStripMenuItem.Text = "Mes sauvegardes";
            // 
            // MonStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MonStock";
            this.Text = "MonStock 1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MonStock_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesEntreesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesSortiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesFournisseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manuelDutlilisationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneLicencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem surMonStock10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nousContacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faireUneSauvegardeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurerUneSauvegardeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesSauvegardesToolStripMenuItem;
    }
}

