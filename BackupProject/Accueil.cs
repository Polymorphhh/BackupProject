using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupProject
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void ajouter_sauvClick(object sender, EventArgs e)
        {
            Sauvegarde sauv = new Sauvegarde(this);
            sauv.Show();

            this.Hide();
        }
    }
}
