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
    public partial class Divorced : Form
    {
        public Divorced()
        {
            InitializeComponent();
        }

        private void Divorced_Load(object sender, EventArgs e)
        {

        }


        private void continuee_Click(object sender, EventArgs e)
        {

            long nk = NumKids.Value;
            // if user has kids then show kids interface
            if (nk > 0)
            {
                Kids k = new Kids();
                k.Show();
            }
            else
            {
                //show 
                Job j = new Job();
                j.Show();
            }
            this.Hide();
        }
    }
}
