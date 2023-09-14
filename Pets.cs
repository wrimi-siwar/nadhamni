using System;
using System.Collections;
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

    public partial class Pets : Form
    {
        private String[] AnimalName = { "Camelia", "Simba", "Thumper", "Coco" };

        public Pets()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            fillDatapets();
            historyPet.Hide();

        }
        private void Pets_Load(object sender, EventArgs e)
        {

        }

        private void fillDatapets()
        {
            //CONSTRUCT TEXT COLUMNS
            dataGridView1.ColumnCount = 1;
            dataGridView1.RowTemplate.Height = 80;
            //CONSTRUCT THE IMAGE COLUMN";
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();

            dataGridView1.Columns.Add(imgCol);
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch; // will do the trick

            //DATA
            //FIRST row
            Image img1 = Image.FromFile("../../img/cat.jpg");
            //THEN AD ROW DATA
            Object[] row = new Object[] { AnimalName[0], img1 };
            dataGridView1.Rows.Add(row);

            //2nd ROW
            Image img2 = Image.FromFile("../../img/dog.jpg");
            row = new Object[] { AnimalName[1], img2 };
            dataGridView1.Rows.Add(row);

            //3rd ROW
            Image img3 = Image.FromFile("../../img/rabbit.jpg");
            row = new Object[] { AnimalName[2], img3 };
            dataGridView1.Rows.Add(row);

            //4th ROW
            Image img4 = Image.FromFile("../../img/parrot.jpg");
            row = new Object[] { AnimalName[3], img4 };
            dataGridView1.Rows.Add(row);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
            string position = dataGridView1.SelectedRows[0].Cells["Position"].Value.ToString();
            string team = dataGridView1.SelectedRows[0].Cells["Team"].Value.ToString();
            Image img = (Image)dataGridView1.SelectedRows[0].Cells["Photo"].Value;
        }
        


        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {

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

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void gunaCirclePictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {

        }

        private void med_Click(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Reminder_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientCircleButton1_Click(object sender, EventArgs e)
        {
            historyPet.Hide();


            AddPetBox.Text = "Add New Pet";

            for (int i = 0; i < AnimalName.Length; i++)
            { AnimName.Items.Add(AnimalName[i]); }



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gunaCirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientCircleButton2_Click(object sender, EventArgs e)
        {
            historyPet.Hide();

            AddPetBox.Text = "Edit Pet";



        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientCircleButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete your pet's history");
        }
        private void gunaGradientCircleButton4_Click(object sender, EventArgs e)
        {

            historyPet.Show();

        }

        private void historyPet_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaImageButton3_Click_1(object sender, EventArgs e)
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

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaCircleButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Health_Click(object sender, EventArgs e)
        {
            this.Hide();
            heal1 h = new heal1();
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

        private void gunaGradientButton1_Click_1(object sender, EventArgs e)
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

        private void Beauty_Click(object sender, EventArgs e)
        {

        }

        private void Events_Click(object sender, EventArgs e)
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
    }
}
