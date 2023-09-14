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
    public partial class water : Form
    {
     
        public water()
        {
            InitializeComponent();
            aide.Hide();
            pk.Hide();
        }

        private void water_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
            P2.Show();
        }
        private int Calculer(double n)
        { int nb = 0;
            if (n % 0.2 == 0)
                nb = (int)(n / 0.2);
            else
                nb =(int) (n/0.2) + 1;
            return nb;
      
        }

        
        private void Qeau_SelectedIndexChanged(object sender, EventArgs e)
        {
                       
            int Q = Qeau.SelectedIndex;
            double quantite = 0;
            int nb;
            switch (Q)
            {
                case 0:
                    quantite = 0.9;
                    this.panel5.Controls.Clear();

                    break;
                case 1:
                    quantite = 1;
                    this.panel5.Controls.Clear();

                    break;
                case 2:
                    quantite = 1.6;
                    this.panel5.Controls.Clear();


                    break;
                case 3:
                    quantite = 1.6;
                    this.panel5.Controls.Clear();

                    break;
                case 4:
                    quantite = 2;
                    this.panel5.Controls.Clear();

                    break;
                case 5:
                    quantite = 2;
                    this.panel5.Controls.Clear();

                    break;
            }

            nb = Calculer(quantite);

            int y = 40;
            int H = 8;
            for (int i = 0; i < nb; i++)
            {
                Label t = new Label();
                t.Size = new System.Drawing.Size(100, 30);
                t.Location = new Point(45, y);
                y = y + 36;
                t.BackColor = System.Drawing.SystemColors.Control;
                t.Text ="" + 0.2 + " L  : AT " + H + ":00";
                t.TextAlign = ContentAlignment.MiddleCenter;
                t.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
                t.TabIndex = 0;
                t.AutoSize = true;
                t.BackColor = System.Drawing.Color.Transparent;

                if (quantite == 0.9 || quantite == 1)
                    H = H + 3;
                else if (quantite == 1.6)
                    H = H + 2;
                else
                    H = H + 1;

                this.panel5.Controls.Add(t);

            }
        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            P2.Show();
        }

        private void P2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton10_Click(object sender, EventArgs e)
        {
            
            pk.Hide();
            aide.Show();
        }

        private void aide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaImageButton11_Click(object sender, EventArgs e)
        {
            
            aide.Hide();
            pk.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pk.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aide.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            aide.Hide();
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            
            pk.Hide();
            aide.Hide();
            gunaPictureBox2.Show();        
        }

        private void gunaButton1_Click_2(object sender, EventArgs e)
        {
            gunaPictureBox2.Hide();
            pk.Hide();
            aide.Show();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            gunaPictureBox2.Hide();
            aide.Hide();
            pk.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
