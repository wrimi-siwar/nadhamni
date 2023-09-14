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
    
    public partial class events : Form
    {
        private int nbClick = 0;
        private List<String> lst = new List<String>
        {
        "annif   : 02/12/2020",
        "formation c# : 03/04/2020",
        "workshop python : 15/11/2020",
        "annif   : 02/12/2020",
        "formation c# : 03/04/2020",
        "workshop python : 15/11/2020",
        "annif   : 02/12/2020",
        "formation c# : 03/04/2020",
        "workshop python : 15/11/2020"
            ,"annif   : 02/12/2020",
        "formation c# : 03/04/2020",
        "workshop python : 15/11/2020"
            ,"annif   : 02/12/2020",
        "formation c# : 03/04/2020",
        "workshop python : 15/11/2020",
        "annif   : 02/12/2020",
        "formation c# : 03/04/2020",
        "workshop python : 15/11/2020",
        "annif   : 02/12/2020",
        "formation c# : 03/04/2020",
        "workshop python : 15/11/2020",
        "annif   : 02/12/2020",
        "formation c# : 03/04/2020",
        "workshop python : 15/11/2020", 
         "annif   : 02/12/2020",
        "formation c# : 03/04/2020",
        "workshop python : 15/11/2020"
         ,"annif   : 02/12/2020",
        "formation c# : 03/04/2020",
        "workshop python : 15/11/2020",
        "formation c# : 03/04/2020",
        "workshop python : 15/11/2020",
        "annif   : 02/12/2020",
        "formation c# : 03/04/2020",
        "workshop python : 15/11/2020",
        "annif   : 02/12/2020",
        "formation c# : 03/04/2020",
        "workshop python : 15/11/2020",
        "annif   : 02/12/2020",
        "formation c# : 03/04/2020",
        "workshop python : 15/11/2020",
         "annif   : 02/12/2020",
        "formation c# : 03/04/2020",
        "workshop python : 15/11/2020"
         ,"annif   : 02/12/2020",
        "formation c# : 03/04/2020",
        "workshop python : 15/11/2020"

        }
        ;
        public events()
        {
            InitializeComponent();
        }

        private void events_Load(object sender, EventArgs e)
        {
           

          
        }

        private void ev_Click(object sender, EventArgs e)
        {
            nbClick += 1;
            if (nbClick == 1)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    Guna.UI.WinForms.GunaLineTextBox t = new Guna.UI.WinForms.GunaLineTextBox();
                    t.Size = new System.Drawing.Size(335, 10);
                    t.Location = new System.Drawing.Point(1, (ev.Controls.Count + 1) * 20);
                    t.BackColor = System.Drawing.SystemColors.Control;
                    t.Text = lst[i];
                    
                    ev.Enabled = false;
                    ev.Controls.Add(t);
                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            lst.Add(""+titre.Text    +" : " +date.Value );
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            ev.Enabled = true;
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

        private void Health_Click(object sender, EventArgs e)
        {
            this.Hide();
            heal1 h = new heal1();
            h.Show();
        }

        private void Beauty_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pets h = new Pets();
            h.Show();
        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            events h = new events();
            h.Show();
        }

        private void gunaGradientButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bills h = new Bills();
            h.Show();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parents h = new Parents();
            h.Show();
        }

        private void Job_Click(object sender, EventArgs e)
        {
            this.Hide();
            Job h = new Job();
            h.Show();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Beauty h = new Beauty();
            h.Show();
        }

        private void gunaGradientButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Treasury h = new Treasury();
            h.Show();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sign_in h = new sign_in();
            h.Show();
        }
    }
}
