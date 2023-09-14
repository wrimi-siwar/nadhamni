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
    public partial class planning : Form
    {
        public planning()
        {
            InitializeComponent();
        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaLineTextBox t1 = new Guna.UI.WinForms.GunaLineTextBox();
            t1.Size = new System.Drawing.Size(100, 10);
            t1.Location = new System.Drawing.Point(300,30);
            t1.BackColor = System.Drawing.SystemColors.Control;
            menu.Controls.Add(t1);
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaLineTextBox t1 = new Guna.UI.WinForms.GunaLineTextBox();
            t1.Size = new System.Drawing.Size(100, 10);
            t1.Location = new System.Drawing.Point(300, 30);
            t1.BackColor = System.Drawing.SystemColors.Control;
            menu.Controls.Add(t1);
        }
    }
}
