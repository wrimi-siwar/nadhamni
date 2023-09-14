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
    public partial class Couple : Form
    {
        public Couple()
        {
            InitializeComponent();
        }

        private void Couple_Load(object sender, EventArgs e)
        {

        }

        private void continuee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parents p = new Parents();
            p.Show();
        }
    }
}
