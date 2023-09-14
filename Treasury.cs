using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Drawing.Imaging;
using ScreenToPDF;

namespace Nadhemni
{
    public partial class Treasury : Form
    {private ArrayList IDDEsire_mylist =new ArrayList();//pour stocker les id des desires d'un utilisateur en particulier lors de la modification ou suppression
        private int id;

        ScreenCapture capScreen = new ScreenCapture();
        public Treasury()
        {
            InitializeComponent();
            add_updateDesire.Hide();
            desires_dataGridView.Hide();
            MessageBox.Show(sign_in.GetUserID().ToString());
        }

        private void add_Click1(object sender, EventArgs e)
        {
            desiresBox.Hide();
            done_update.Hide();
            done_delete.Hide();
            add_updateDesire.Text = "ADD A DESIRE";
            buy.Text = "Please select what do you want to buy :";
            buyy.DropDownStyle = ComboBoxStyle.DropDown;
            buyy.Items.Clear();
            buyy.Text = "";
            buyy.Items.Add("Coat");
            buyy.Items.Add("Jean");
            buyy.Items.Add("Shoes");
            buyy.Items.Add("Skirt");
            buyy.Items.Add("Sneakers");
            buyy.Items.Add("Socks");
            buyy.Items.Add("Sunglasses");
            buyy.Items.Add("Sweater");
            buyy.Items.Add("Trouser");
            cost.Text = "";
            cost.Enabled = false;
            savings.Text = "";
            savings.Enabled = false;
            daily.Checked = false;
            daily.Enabled = false;
            weekl.Checked = false;
            weekl.Enabled = false;
            monthly.Checked = false;
            monthly.Enabled = false;
            yearly.Checked = false;
            yearly.Enabled = false;
            day.Text = "";
            day.Enabled = false;
            week.Text = "";
            week.Enabled = false;
            month.Text = "";
            month.Enabled = false;
            year.Text = "";
            year.Enabled = false;
            ddl.Value = DateTime.Today;
            ddl.Enabled = false;
            add_updateDesire.Show();

        }

        private void delete_Click1(object sender, EventArgs e)
        {
            desiresBox.Hide();
            done_add.Hide();
            done_update.Hide();
            done_delete.Show();
            add_updateDesire.Text = "DELETE A DESIRE";
            buy.Text = "Please select what do you want to delete :";
            buyy.Items.Clear();
            buyy.Text = "";
            buyy.DropDownStyle = ComboBoxStyle.DropDownList;
            buyy.Text = "";
            cost.Text = "";
            cost.Enabled = false;
            savings.Text = "";
            savings.Enabled = false;
            daily.Checked = false;
            daily.Enabled = false;
            weekl.Checked = false;
            weekl.Enabled = false;
            monthly.Checked = false;
            monthly.Enabled = false;
            yearly.Checked = false;
            yearly.Enabled = false;
            day.Text = "";
            day.Enabled = false;
            week.Text = "";
            week.Enabled = false;
            month.Text = "";
            month.Enabled = false;
            year.Text = "";
            year.Enabled = false;
            ddl.Value = DateTime.Today;
            ddl.Enabled = false;
            add_updateDesire.Show();
            buyy.Sorted = false;
            IDDEsire_mylist.Clear();

            Desire d = new Desire();
            var desires = from x in Register_Form.dbnadhemni.Desire
                          where x.Id_user == sign_in.GetUserID()
                          select new
                          {
                              x.id_Desire,
                              x.Choice

                          };
            foreach (var item in desires)
            {
                IDDEsire_mylist.Add(item.id_Desire);
                buyy.Items.Add(item.Choice);
            }

            if (buyy.Items.Count == 0)//si l'utilisateur n'a aucun desire donc il n'a rien à supprimer, alors je l'informe qu'il doit ajouter un afin de pouvoir le supprimer à tout moment
            {
                MessageBox.Show("You don't have any desire !\nPlease add one before !");
            }

        }

        private void update_Click1(object sender, EventArgs e)
        {
            buyy.SelectedIndex = -1;
            desiresBox.Hide();
            done_add.Hide();
            done_delete.Hide();
            done_update.Show();
            add_updateDesire.Text = "UPDATE A DESIRE";
            buy.Text = "Please select what do you want to update :";
            buyy.DropDownStyle = ComboBoxStyle.DropDownList;
            buyy.Text = "";
            cost.Text = "";
            cost.Enabled = false;
            savings.Text = "";
            savings.Enabled = false;
            daily.Checked = false;
            daily.Enabled = false;
            weekl.Checked = false;
            weekl.Enabled = false;
            monthly.Checked = false;
            monthly.Enabled = false;
            yearly.Checked = false;
            yearly.Enabled = false;
            day.Text = "";
            day.Enabled = false;
            week.Text = "";
            week.Enabled = false;
            month.Text = "";
            month.Enabled = false;
            year.Text = "";
            year.Enabled = false;
            ddl.Value = DateTime.Today;
            ddl.Enabled = false;
            add_updateDesire.Show();
            buyy.Sorted = false;
            IDDEsire_mylist.Clear();
            Desire d = new Desire();
            var desires = from x in Register_Form.dbnadhemni.Desire
                          where x.Id_user == sign_in.GetUserID()
                          select new
                          {  x.id_Desire,
                              x.Choice

                          };
            buyy.Items.Clear();
            foreach (var item in desires)
            {
                IDDEsire_mylist.Add(item.id_Desire);
                buyy.Items.Add(item.Choice);

            }

            if (buyy.Items.Count == 0)//si l'utilisateur n'a aucun desire donc il n'a rien à modifier, alors je l'informe qu'il doit ajouter un afin de pouvoir le modifier à tout moment
            {
                MessageBox.Show("You don't have any desire !\nPlease add one before !");
            }

        }

        private void Treasury_Load(object sender, EventArgs e)
        {
            

        }

        private void desiresBox_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parents h = new Parents();
            h.Show();
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
            var result = MessageBox.Show("Are you sure to delete your account ?", "Removal Process..",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                BeautyTb b = new BeautyTb();
                var bb = from x1 in Register_Form.dbnadhemni.BeautyTb
                             where x1.Id_user == sign_in.GetUserID()
                             select x1;
                foreach (var item1 in bb)
                    Register_Form.dbnadhemni.BeautyTb.DeleteOnSubmit(item1);

                Bill bi = new Bill();
                var bil = from x2 in Register_Form.dbnadhemni.Bill
                             where x2.Id_user == sign_in.GetUserID()
                             select x2;
                foreach (var item2 in bil)
                    Register_Form.dbnadhemni.Bill.DeleteOnSubmit(item2);

                DrinkWater u = new DrinkWater();
                var dw = from x3 in Register_Form.dbnadhemni.DrinkWater
                             where x3.Id_user == sign_in.GetUserID()
                             select x3;
                foreach (var item3 in dw)
                    Register_Form.dbnadhemni.DrinkWater.DeleteOnSubmit(item3);

                Drugs drug = new Drugs();
                var dru = from x4 in Register_Form.dbnadhemni.Drugs
                         where x4.id_user == sign_in.GetUserID()
                         select x4;
                foreach (var item4 in dru)
                    Register_Form.dbnadhemni.Drugs.DeleteOnSubmit(item4);

                Event ev = new Event();
                var eve = from x5 in Register_Form.dbnadhemni.Event
                         where x5.Id_user == sign_in.GetUserID()
                         select x5;
                foreach (var item5 in eve)
                    Register_Form.dbnadhemni.Event.DeleteOnSubmit(item5);

                Family fam = new Family();
                var fami = from x6 in Register_Form.dbnadhemni.Family
                         where x6.Id_user == sign_in.GetUserID()
                         select x6;
                foreach (var item6 in fami)
                Register_Form.dbnadhemni.Family.DeleteOnSubmit(item6); 
                
                RDV rd = new RDV();
                var rdd = from x7 in Register_Form.dbnadhemni.RDV
                         where x7.id_user == sign_in.GetUserID()
                         select x7;
                foreach (var item7 in rdd)
                    Register_Form.dbnadhemni.RDV.DeleteOnSubmit(item7);

                TimeTable time = new TimeTable();
                var timet = from x8 in Register_Form.dbnadhemni.TimeTable
                         where x8.id_user == sign_in.GetUserID()
                         select x8;
                foreach (var item8 in timet)
                    Register_Form.dbnadhemni.TimeTable.DeleteOnSubmit(item8);

                Users user = new Users();
                var uu = from x9 in Register_Form.dbnadhemni.Users
                            where x9.Id_user == sign_in.GetUserID()
                            select x9;
                foreach (var item9 in uu)
                    Register_Form.dbnadhemni.Users.DeleteOnSubmit(item9);

                Register_Form.dbnadhemni.SubmitChanges();
                MessageBox.Show("We hope we see you again !");
                this.Hide();
                sign_in s = new sign_in();
                s.Show();
            }
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

        private void buyy_TextChanged(object sender, EventArgs e)
        {
            if (add_updateDesire.Text == "ADD A DESIRE" )
            {
                cost.Enabled = true;
                savings.Enabled = true;
                daily.Enabled = true;
                weekl.Enabled = true;
                monthly.Enabled = true;
                yearly.Enabled = true;
                ddl.Enabled = true;
            }
        }

        private void buyy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (add_updateDesire.Text == "UPDATE A DESIRE")//si l'utilisateur a choisi d'ajouter ou de modifierv un desir 
            {
                cost.Enabled = true;
                savings.Enabled = true;
                daily.Enabled = true;
                weekl.Enabled = true;
                monthly.Enabled = true;
                yearly.Enabled = true;
                ddl.Enabled = true;
            }

            if (add_updateDesire.Text == "UPDATE A DESIRE" || add_updateDesire.Text == "DELETE A DESIRE")
            {
                int index = buyy.SelectedIndex;
                id = (int)IDDEsire_mylist[index];

                Desire d = new Desire();
                var desires = from x in Register_Form.dbnadhemni.Desire
                              where x.Id_user == sign_in.GetUserID() && x.id_Desire==id
                              select new
                              {  
                                  x.Cost,
                                  x.Savings,
                                  x.Frequency,
                                  x.Deadline

                              };
                foreach (var item in desires)
                {
                    cost.Text = item.Cost.ToString();
                    savings.Text = item.Savings.ToString();
                    if (item.Frequency.ToString().Contains("day"))
                    {if (add_updateDesire.Text == "UPDATE A DESIRE")
                            day.Enabled = true;

                        daily.Checked = true;
                        String ch = "";
                        for (int i = 0; i < item.Frequency.ToString().Length; i++)//pour récupérer seulement le montant
                        {
                            if (!Char.IsDigit(item.Frequency.ToString()[i]) && item.Frequency.ToString()[i]!='.')
                            {
                                break;
                            }
                            else
                                ch = ch + item.Frequency.ToString()[i];
                        }
                        day.Text = ch;
                    }
                    else if (item.Frequency.ToString().Contains("week"))
                    {
                        if (add_updateDesire.Text == "UPDATE A DESIRE")
                                week.Enabled = true;

                        weekl.Checked = true;
                        String ch = "";
                        for (int i = 0; i < item.Frequency.ToString().Length; i++)//pour récupérer seulement le montant
                        {
                            if (!Char.IsDigit(item.Frequency.ToString()[i]) && item.Frequency.ToString()[i] != '.')
                            {
                                break;
                            }
                            else
                                ch = ch + item.Frequency.ToString()[i];
                        }
                        week.Text = ch;
                    }
                    else if (item.Frequency.ToString().Contains("month"))
                    {   if (add_updateDesire.Text == "UPDATE A DESIRE")
                            month.Enabled = true;

                        monthly.Checked = true;
                        String ch = "";
                        for (int i = 0; i < item.Frequency.ToString().Length; i++)//pour récupérer seulement le montant
                        {
                            if (!Char.IsDigit(item.Frequency.ToString()[i]) && item.Frequency.ToString()[i] != '.')
                            {
                                break;
                            }
                            else
                                ch = ch + item.Frequency.ToString()[i];
                        }
                        month.Text = ch;
                    }
                    else
                    {  if (add_updateDesire.Text == "UPDATE A DESIRE")
                            year.Enabled = true;
                        
                        yearly.Checked = true;
                        String ch = "";
                        for (int i = 0; i < item.Frequency.ToString().Length; i++)//pour récupérer seulement le montant
                        {
                            if (!Char.IsDigit(item.Frequency.ToString()[i]) && item.Frequency.ToString()[i] != '.')
                            {
                                break;
                            }
                            else
                                ch = ch + item.Frequency.ToString()[i];
                        }
                        year.Text = ch;
                    }
                    ddl.Value = item.Deadline.Date;
                }



            }
        }

        private void daily_CheckedChanged(object sender, EventArgs e)
        {
            if (daily.Checked && add_updateDesire.Text != "DELETE A DESIRE")
               
                day.Enabled = true;
            else
            {
                day.Text = "";
                day.Enabled = false;

            }

        }

        private void weekl_CheckedChanged(object sender, EventArgs e)
        {
            if (weekl.Checked && add_updateDesire.Text != "DELETE A DESIRE")
                week.Enabled = true;
            else
            {
                week.Text = "";
                week.Enabled = false;

            }
        }

        private void monthly_CheckedChanged(object sender, EventArgs e)
        {
            if (monthly.Checked && add_updateDesire.Text != "DELETE A DESIRE")
                month.Enabled = true;

            else
            {
               month.Text = "";
                month.Enabled = false;

            }
        }

        private void yearly_CheckedChanged(object sender, EventArgs e)
        {
            if (yearly.Checked && add_updateDesire.Text != "DELETE A DESIRE")
                year.Enabled = true;
            else
            {
                year.Text = "";
                year.Enabled = false;
              
            }
        }
       
        private void done_Click(object sender, EventArgs e)
        {
            Boolean test = false;
            String newcost="", newsavings="", newday="", newweek="", newmonth="", newyear="";
            if ( (buyy.SelectedItem == null) && (!Register_Form.verifAlpha(buyy.Text)) )
                MessageBox.Show("Please select or write your choice !");
            else
            {
                 newcost=Register_Form.
                    conversion_virgule_en_point(cost.Text);//que ce soit l'utilisateur saisit un décimal avec point ou virgule sa chaine va etre acceptée
                
                if (!Register_Form.verifDecimal(newcost))
                {
                    MessageBox.Show("Please enter how much does your desire cost !");
                }
                else
                {
                     newsavings = Register_Form.conversion_virgule_en_point(savings.Text);//que ce soit l'utilisateur saisit un décimal avec point ou virgule sa chaine va etre acceptée

                    if (!Register_Form.verifDecimal(newsavings))
                    {
                        MessageBox.Show("Please enter how much did you save up to now !");
                    }
                    else
                    {
                        if (!daily.Checked && !weekl.Checked && !monthly.Checked && !yearly.Checked)
                        {
                            MessageBox.Show("Please choose how frequently are you saving money !");
                        }
                        else
                        {
                            if (daily.Checked)
                            {
                                 newday = Register_Form.conversion_virgule_en_point(day.Text);//que ce soit l'utilisateur saisit un décimal avec point ou virgule sa chaine va etre acceptée

                                if (!Register_Form.verifDecimal(newday))

                                    MessageBox.Show("Please enter how much do you save per a day !");
                                else test = true;
                            }

                            else if (weekl.Checked)
                            {
                                 newweek = Register_Form.conversion_virgule_en_point(week.Text);//que ce soit l'utilisateur saisit un décimal avec point ou virgule sa chaine va etre acceptée

                                if (!Register_Form.verifDecimal(newweek))

                                    MessageBox.Show("Please enter how much do you save per a week !");
                                else test = true;
                            }
                            else if (monthly.Checked)
                            {
                                newmonth = Register_Form.conversion_virgule_en_point(month.Text);//que ce soit l'utilisateur saisit un décimal avec point ou virgule sa chaine va etre acceptée

                                if (!Register_Form.verifDecimal(newmonth))

                                    MessageBox.Show("Please enter how much do you save per a month !");
                                else test = true;
                            }
                            else
                            {
                                newyear = Register_Form.conversion_virgule_en_point(year.Text);//que ce soit l'utilisateur saisit un décimal avec point ou virgule sa chaine va etre acceptée

                                if (!Register_Form.verifDecimal(newyear))

                                    MessageBox.Show("Please enter how much do you save per a year !");
                                else test = true;
                            }
                            if (test)
                            {
                                if (!Register_Form.verifDeadline(ddl.Value.Date))
                                {
                                    MessageBox.Show("This deadline is already missed !\nPlease put a correct one !");
                                }

                                else
                                {
                                    try
                                    {//1: créer une instance
                                        Desire d = new Desire();
                                        //2: initialisation des propriétes
                                        System.Globalization.NumberStyles style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands; ;
                                        System.Globalization.CultureInfo provider= new CultureInfo("en-US"); 
                                        d.Id_user = sign_in.GetUserID();
                                        d.Choice = buyy.Text.ToString();
                                                                             
                                        d.Cost = decimal.Parse(newcost,style,provider); 
                                        d.Savings = decimal.Parse(newsavings,style,provider);

                                        if (daily.Checked)
                                            d.Frequency = newday + per_day.Text;
                                        else if (weekl.Checked)
                                            d.Frequency = newweek + per_week.Text;
                                        else if (monthly.Checked)
                                            d.Frequency = newmonth + per_month.Text;
                                        else
                                            d.Frequency = newyear + per_year.Text;
                                        d.Deadline = ddl.Value.Date;

                                        //3: insertion de l'object d dans la table (Desire)
                                        Register_Form.dbnadhemni.Desire.InsertOnSubmit(d);

                                        //4: mettre à jour la base de données
                                        Register_Form.dbnadhemni.SubmitChanges();

                                        MessageBox.Show("Insertion successful !");
                                        desires_dataGridView.DataSource = null;
                                        Desire d2 = new Desire();
                                        var desires = from x in Register_Form.dbnadhemni.Desire
                                                      where x.Id_user == sign_in.GetUserID()
                                                      select new
                                                      {
                                                          x.Choice,
                                                          x.Cost,
                                                          x.Savings,
                                                          x.Frequency,
                                                          x.Deadline

                                                      };
                                        
                                        desires_dataGridView.DataSource = desires;

                                        if (desires_dataGridView == null)
                                            MessageBox.Show("You don't have any desire!\nYou can add one at any moment !");

                                        add_updateDesire.Hide();
                                        desiresBox.Show();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }

                        }
                    }
                }
            }

           

        }

        private void done_update_Click(object sender, EventArgs e)
        {

        }

        private void savings_TextChanged(object sender, EventArgs e)
        {

        }

        private void done_delete_Click(object sender, EventArgs e)
        {          
                if (buyy.SelectedItem == null)
                    MessageBox.Show("Please select a desire to delete !");
                else
                {
                    Desire d = new Desire();
                    var desires = from x in Register_Form.dbnadhemni.Desire
                                  where x.id_Desire == id
                                  select x;
                    foreach (var item in desires)
                    
                        Register_Form.dbnadhemni.Desire.DeleteOnSubmit(item);
                       
                    
                buyy.Items.Remove(buyy.SelectedItem);//suppression de desire de la liste déroulante
            
                Register_Form.dbnadhemni.SubmitChanges();
                MessageBox.Show("Removal successful !");

            desires_dataGridView.DataSource = null;
            Desire d1 = new Desire();
            var desiress = from x in Register_Form.dbnadhemni.Desire
                          where x.Id_user == sign_in.GetUserID()
                          select new
                          {
                              x.Choice,
                              x.Cost,
                              x.Savings,
                              x.Frequency,
                              x.Deadline

                          };

            desires_dataGridView.DataSource = desiress;

            if (desires_dataGridView == null)
                MessageBox.Show("You don't have any desire !\nYou can add one at any moment !");
            
            add_updateDesire.Hide();
            desiresBox.Show();
            }
        }

        private void list_buy_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void view_Click(object sender, EventArgs e)
        {
            desires_dataGridView.DataSource = null;
            Desire d = new Desire();
            var desires = from x in Register_Form.dbnadhemni.Desire
                          where x.Id_user == sign_in.GetUserID()
                          select new
                          {
                              x.Choice,
                              x.Cost,
                              x.Savings,
                              x.Frequency,
                              x.Deadline

                          };
           
                desires_dataGridView.DataSource = desires;
            


            if (desires_dataGridView==null)           
                MessageBox.Show("You don't have any desire!\nYou can add one at any moment !");
            desires_dataGridView.Show();


        }

        private void add_updateDesire_Click(object sender, EventArgs e)
        {

        }

        private void done_update_Click_1(object sender, EventArgs e)
        {
            Boolean test = false;
            String newcost = "", newsavings = "", newday = "", newweek = "", newmonth = "", newyear = "";

            if (buyy.SelectedItem==null)
                MessageBox.Show("Please select your choice !");
            else
            {
                newcost = Register_Form.conversion_virgule_en_point(cost.Text);//que ce soit l'utilisateur saisit un décimal avec point ou virgule sa chaine va etre acceptée

                if (!Register_Form.verifDecimal(newcost))
                {
                    MessageBox.Show("Please enter how much does your desire cost !");
                }
                else
                {
                    newsavings = Register_Form.conversion_virgule_en_point(savings.Text);//que ce soit l'utilisateur saisit un décimal avec point ou virgule sa chaine va etre acceptée

                    if (!Register_Form.verifDecimal(newsavings))
                    {
                        MessageBox.Show("Please enter how much did you save up to now !");
                    }
                    else
                    {
                        if (!daily.Checked && !weekl.Checked && !monthly.Checked && !yearly.Checked)
                        {
                            MessageBox.Show("Please choose how frequently are you saving money !");
                        }
                        else
                        {
                            if (daily.Checked)
                            {
                                newday = Register_Form.conversion_virgule_en_point(day.Text);//que ce soit l'utilisateur saisit un décimal avec point ou virgule sa chaine va etre acceptée

                                if (!Register_Form.verifDecimal(newday))

                                    MessageBox.Show("Please enter how much do you save per a day !");
                                else test = true;
                            }

                            else if (weekl.Checked)
                            {
                                newweek = Register_Form.conversion_virgule_en_point(week.Text);//que ce soit l'utilisateur saisit un décimal avec point ou virgule sa chaine va etre acceptée

                                if (!Register_Form.verifDecimal(newweek))

                                    MessageBox.Show("Please enter how much do you save per a week !");
                                else test = true;
                            }
                            else if (monthly.Checked)
                            {
                                newmonth = Register_Form.conversion_virgule_en_point(month.Text);//que ce soit l'utilisateur saisit un décimal avec point ou virgule sa chaine va etre acceptée

                                if (!Register_Form.verifDecimal(newmonth))

                                    MessageBox.Show("Please enter how much do you save per a month !");
                                else test = true;
                            }
                            else
                            {
                                newyear = Register_Form.conversion_virgule_en_point(year.Text);//que ce soit l'utilisateur saisit un décimal avec point ou virgule sa chaine va etre acceptée

                                if (!Register_Form.verifDecimal(newyear))

                                    MessageBox.Show("Please enter how much do you save per a year !");
                                else test = true;
                            }
                            if (test)
                            {
                                if (!Register_Form.verifDeadline(ddl.Value.Date))
                                {
                                    MessageBox.Show("This deadline is already missed !\nPlease put a correct one !");
                                }

                                else
                                {
                                    try
                                    {//1: récupérer l'objet à travers son nom
                                        Desire d = Register_Form.dbnadhemni.Desire.Single<Desire>(x => x.Id_user == sign_in.GetUserID() && x.id_Desire == id);
                                        //2: initialisation des propriétes
                                        System.Globalization.NumberStyles style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands; ;
                                        System.Globalization.CultureInfo provider = new CultureInfo("en-US");
                                        if (d == null)
                                            MessageBox.Show("This desire does not exist !");
                                        else
                                        {
                                                d.Choice = buyy.SelectedItem.ToString();

                                                d.Cost = decimal.Parse(newcost, style, provider);
                                                d.Savings = decimal.Parse(newsavings, style, provider);

                                                if (daily.Checked)
                                                   d.Frequency = newday + per_day.Text;
                                                else if (weekl.Checked)
                                                    d.Frequency = newweek + per_week.Text;
                                                else if (monthly.Checked)
                                                    d.Frequency = newmonth + per_month.Text;
                                                else
                                                    d.Frequency = newyear + per_year.Text;
                                                d.Deadline = ddl.Value.Date;


                                                //4: mettre à jour la base de données
                                                Register_Form.dbnadhemni.SubmitChanges();
                                            
                                                MessageBox.Show("Modification successful !");

                                            desires_dataGridView.DataSource = null;
                                            Desire d1 = new Desire();
                                           var desires = from x in Register_Form.dbnadhemni.Desire
                                                          where x.Id_user == sign_in.GetUserID()
                                                          select new
                                                          {
                                                              x.Choice,
                                                              x.Cost,
                                                              x.Savings,
                                                              x.Frequency,
                                                              x.Deadline

                                                          };

                                            desires_dataGridView.DataSource = desires;

                                            if (desires_dataGridView == null)
                                                MessageBox.Show("You don't have any desire!\nYou can add one at any moment !");

                                            add_updateDesire.Hide();
                                                desiresBox.Show();

                                            
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }

                        }
                    }
                }

            }


        }

        private void desires_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void captureScreen()
        {
            try
            {
                // Call the CaptureAndSave method from the ScreenCapture class 
                // And create a temporary file in desktop
                capScreen.CaptureAndSave(@"C:\Users\hp\Desktop\nadhemni.png", CaptureMode.Window, ImageFormat.Png);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }
        private void btnExport_Click()
        {
            // Call your captureScreen() function
            captureScreen();

            // Create new pdf document and page
            PdfSharp.Pdf.PdfDocument doc = new PdfSharp.Pdf.PdfDocument();
            
            PdfSharp.Pdf.PdfPage oPage = new PdfSharp.Pdf.PdfPage();

            // Add the page to the pdf document and add the captured image to it
            doc.Pages.Add(oPage);
            XGraphics xgr = XGraphics.FromPdfPage(oPage);
            XImage img = XImage.FromFile(@"C:\Users\hp\Desktop\nadhemni.png");
            if (img.PixelWidth > img.PixelHeight)
                oPage.Orientation = PdfSharp.PageOrientation.Landscape;
            else
                oPage.Orientation = PdfSharp.PageOrientation.Portrait;
            xgr.DrawImage(img, 0, 0);

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ("PDF File|*.pdf");
            DialogResult btnSave = saveFileDialog.ShowDialog();
            if (btnSave.Equals(DialogResult.OK))
            {
                doc.Save(saveFileDialog.FileName);
                doc.Close();
            }

            // I used the Dispose() function to be able to 
            // save the same form again, in case some values have changed.
            // When I didn't use the function, an GDI+ error occurred.
            img.Dispose();
        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void exportDataGridViewtoPDF(DataGridView dg, String formName,String filename)
        {
            
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfPTable = new PdfPTable(dg.Columns.Count);
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font textheader = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            //ADD HEADER
            foreach (DataGridViewColumn column in dg.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, textheader));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240,240,240);
                pdfPTable.AddCell(cell);
            }
            if (dg != null)
            {//ADD ROW
                foreach (DataGridViewRow row in dg.Rows)
                {
                    foreach (DataGridViewCell c in row.Cells)
                    {
                        if (c.Value != null)
                        pdfPTable.AddCell(new Phrase(c.Value.ToString(), text));
                    }
                }
            }
            else MessageBox.Show("You don't have any desire to print!\nPlease add one before!");
            var savefiledialog = new SaveFileDialog();
            savefiledialog.FileName = filename;
            savefiledialog.DefaultExt = ".pdf";
            if (savefiledialog.ShowDialog()==DialogResult.OK)
            {
                using(FileStream stream=new FileStream(savefiledialog.FileName,FileMode.Create))
                {
                    Document pdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdoc, stream);
                    pdoc.Open();
                    iTextSharp.text.Font myFont = FontFactory.GetFont(FontFactory.HELVETICA, 28f, iTextSharp.text.Font.BOLDITALIC, BaseColor.RED);
                    Paragraph para = new Paragraph(formName,myFont);
                    para.Alignment = Element.ALIGN_CENTER;                   
                    pdoc.Add(para);
                    pdoc.Add(new Paragraph(" "));
                    pdoc.Add(pdfPTable);
                    pdoc.Close();
                    stream.Close();

                }
            }

        }
    }
}