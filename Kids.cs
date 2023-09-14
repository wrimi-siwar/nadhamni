using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nadhemni
{
    public partial class Kids : Form
    {
        public Kids()
        {
            InitializeComponent();
        }

        private void sideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Kids_Load(object sender, EventArgs e)
        {
            TimeTable.Hide();
        }

        private void cmb_study_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_study.Text == "Not studying")
            {
                TimeTable.Hide();
            }
            else
            {
                TimeTable.Show();
            }

        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {

        }

        private void continuee_Click(object sender, EventArgs e)
        {
            Job j = new Job();
            j.Show();
            this.Hide();
        }
    }
}
