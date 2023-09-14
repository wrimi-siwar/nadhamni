using System;
using System.Windows.Forms;

namespace Nadhemni
{
    public partial class Parents : Form
    {
        public Parents()
        {
            InitializeComponent();
        }

        private void Parents_Load(object sender, EventArgs e)
        {
            dt_Death.Hide();
            ck_lives.Hide();
            In.Hide();
            dt_Death2.Hide();
            ck_lives2.Hide();
            In2.Hide();
        }

        private void gunaRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaRadioButton1.Checked)
            {
                In.Show();
                dt_Death.Show();
                msg.Text = "I'm sorry to know that !";
                ck_lives.Hide();
            }

        }

        private void gunaRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (gunaRadioButton2.Checked)
            {
                dt_Death.Hide();
                In.Hide();
                msg.Text = "May God protect her !";
                ck_lives.Show();
            }
        }

        private void gunaRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaRadioButton4.Checked)
            {
                In2.Show();
                dt_Death2.Show();
                msg2.Text = "I'm sorry to know that !";
                ck_lives2.Hide();
            }
        }

        private void gunaRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

            if (gunaRadioButton3.Checked)
            {
                dt_Death2.Hide();
                In2.Hide();
                msg2.Text = "May God protect him !";
                ck_lives2.Show();
            }
        }

        private void continuee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Job j = new Job();
            j.Show();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void Health_Click(object sender, EventArgs e)
        {
            this.Hide();
            heal1 h = new heal1();
            h.Show();
        }

        private void Job_Click(object sender, EventArgs e)
        {
            this.Hide();
            Job h = new Job();
            h.Show();
        }

        private void Beauty_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pets h = new Pets();
            h.Show();
        }

        private void Events_Click(object sender, EventArgs e)
        {
            this.Hide();
            Beauty h = new Beauty();
            h.Show();
        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            events h = new events();
            h.Show();
        }

        private void gunaGradientButton5_Click(object sender, EventArgs e)
        {

         
            this.Hide();
            Treasury h = new Treasury();
            h.Show();
        }

        private void gunaGradientButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bills h = new Bills();
            h.Show();

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sign_in h = new sign_in();
            h.Show();
        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            if (sideMenu.Width == 196)
            {
                sideMenu.Visible = false;
                sideMenu.Width = 43;
                bunifuTransition1.ShowSync(sideMenu);
                bunifuTransition1.ShowSync(logo);

            }
            else
            {
                sideMenu.Visible = false;
                sideMenu.Width = 196;
                bunifuTransition1.ShowSync(sideMenu);
                bunifuTransition1.ShowSync(logo);
            }
        }
    }
}
