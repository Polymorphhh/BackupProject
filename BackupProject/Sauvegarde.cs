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
    public partial class Sauvegarde : Form
    {
        private Form parentForm;

        public Sauvegarde(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void Sauvegarde_Load(object sender, EventArgs e)
        {

        }

        private void btn_sauv_annuler_Click(object sender, EventArgs e)
        {           
            this.parentForm.Show();
            this.Close();
        }
    }
}
