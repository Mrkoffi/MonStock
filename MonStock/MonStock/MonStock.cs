using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonStock
{
    public partial class MonStock : Form
    {
        public MonStock()
        {
            InitializeComponent();
        }

        private void ajouterUneLicencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void MonStock_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Display a MsgBox asking the user to save changes or abort.
            if (MessageBox.Show("Do you want to close?", "My Application",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Cancel the Closing event from closing the form.
               // e.Cancel = true;
                // Call method to save file...
            }
            System.Windows.Forms.Application.Exit();
        }

    }
}
