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
    public partial class healthy : Form
    {
        private int nbClick=0;
        private List<String> lst = new List <String> {
            "Food                    Serving            Calories",
            "Black Olive    1 olive(2.7 g)     2 cal \n",
            "Artichoke        1 artichoke(128g)  60 cal \n" ,
            "Arugula          1 leaf (2 g)       1 cal \n",
            "Asparagus        1 spear (12 g)     2 cal \n",
            "Aubergine        1 aubergine(458g)  115 cal \n",
            "Beetroot         1 beet (82 g)      35 cal \n",
            "Acai             1 oz. (28.35 g)    20 cal",
            "Apple            1 apple (182 g)    95 cal",
            "Applesauce      1 cup (246 g)       167 cal",
            "Apricot         1 apricot (35 g)    17 cal",
            "Avocado         1 avocado (200 g)   320 cal",
            "Banana          1 banana (125 g)    111 cal",
            "Blackberries    1 cup (144 g)       62 cal",
            "Blood Oranges   1 serving (140 g)   70 cal",
            "Blueberries     1 cup (148 g)      84 cal",
            "Cantaloupe      1 wedge (69 g)     23 cal",
            "Cherries        1 cherry (8 g)     4 cal",
            "BBQ Rib         1 rib (67 g)     142 cal",
            "Bean Burrito    1 burrito (190 g)     380 cal",
            "Big N’ Tasty    1 sandwich (232 g)    517 cal",
            "Bratwurst       1 piece (85 g)     283 cal"


                };
        public healthy()
        {
            InitializeComponent();
            
            
        }
      
        private void healthy_Load(object sender, EventArgs e)
        {
           
        }

        private void gunaLineTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaGroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
        }
        
        

        private void gunaVScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        private void remplir()
        {
            
        }
        private void cal_Click(object sender, EventArgs e)
        {
            nbClick += 1;
            if (nbClick == 1)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    Guna.UI.WinForms.GunaLineTextBox t = new Guna.UI.WinForms.GunaLineTextBox();
                    t.Size = new System.Drawing.Size(330, 10);
                    t.Location = new System.Drawing.Point(1, (cal.Controls.Count + 1) * 20);

                    t.BackColor = System.Drawing.SystemColors.Control;
                    t.Text = lst[i];
                    t.Enabled = false;
                    cal.Controls.Add(t);
                }
            }
        }

        private void gunaLineTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox8_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            float r = float.Parse(p.Text) / (float.Parse(Taille.Text) * float.Parse(Taille.Text));

            imc.Text = "" + r;


        }

        private void P_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            this.Close(); 

        }
    }
}
