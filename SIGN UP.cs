﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Facebook;
using System.Security.Policy;
using System.Dynamic;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web;
using FBDialogDemo;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Plus.v1;
using System.Threading;
using Google.Apis.Util.Store;
using Google.Apis.Services;
using Google.Apis.Plus.v1.Data;

namespace Nadhemni
{
    public partial class Register_Form : Form
    {
        public static NadhemniDBDataContext dbnadhemni = new NadhemniDBDataContext();
        private String path = "";
        public Register_Form()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            hide_pwd.Hide();
            hide_vpwd.Hide();
            birthdate_txt.Value = DateTime.Today;
            deleteProfilePicture.Hide();
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


        private void date_naiss_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sexe_f_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void google_Click(object sender, EventArgs e)
        {

        }

        private void contiinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (cmb_situation.SelectedIndex == 0)
            {
                Parents p = new Parents();
                p.Show();
            }
            else if (cmb_situation.SelectedIndex == 1)
            {
                Couple cp = new Couple();
                cp.Show();
            }
            else if (cmb_situation.SelectedIndex == 2)
            {
                Married mr = new Married();
                mr.Show();
            }
            else if (cmb_situation.SelectedIndex == 3)
            {
                Divorced dv = new Divorced();
                dv.Show();
            }
            else
            {
                depart dv = new depart();
                dv.Show();
            }

        }


        private void register_Click(object sender, EventArgs e)
        {
            this.Hide();
            sign_in sn = new sign_in();
            sn.Show();
        }

        private void registerr_Click(object sender, EventArgs e)
        {

        }

        private void acceptchb_OnChange(object sender, EventArgs e)
        {
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void register_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            sign_in form = new sign_in();
            form.Show();
        }

        private void Errvpassword_Click(object sender, EventArgs e)
        {

        }
        public void reinitialisation_des_champs()
        {
            first_name.Text = "";
            last_name.Text = "";
            birthdate_txt.Value = DateTime.Today;
            cmb_profession.SelectedItem = null;
            male.Checked = false;
            female.Checked = false;
            cmb_situation.SelectedItem = null;
            address_txt.Text = "";
            cmb_country.SelectedItem = null;
            phone_txt.Text = "";
            cmb_city.SelectedItem = null;
            email_txt.Text = "";
            password_txt.Text = "";
            password_txt.isPassword = true;
            vpassword_txt.Text = "";
            vpassword_txt.isPassword = true;
            hide_pwd.Hide();
            hide_vpwd.Hide();
            accept_checkbox.Checked = false;

        }
        public static Boolean verifAlpha(String ch) //méthode qui assure que toute la chaîne ne contient que des lettres
        {
            Boolean test = true;
            if (ch.Equals("") || ch.Equals(" "))
                test = false;
            else
            {
                for (int i = 0; i < ch.Length; i++)
                {
                    if (!Char.IsLetter(ch[i]))
                    {
                        test = false;
                        break;
                    }
                }
            }
            return test;
        }
        public Boolean verifDigit(String ch) //méthode qui assure que toute la chaîne ne contient que des chiffres
        {
            Boolean test = true;
            if (ch.Equals("") || ch.Equals(" "))
                test = false;
            else
            {
                for (int i = 0; i < ch.Length; i++)
                {
                    if (!Char.IsDigit(ch[i]))
                    {
                        test = false;
                        break;
                    }
                }
            }
            return test;
        }

        public static Boolean verifDigitOrAlpha(String ch)
        {
            Boolean test = true;
            if (ch.Equals("") || ch.Equals(" "))
                test = false;
            else
            {
                for (int i = 0; i < ch.Length; i++)
                {
                    if (!Char.IsLetterOrDigit(ch[i]))
                    {
                        test = false;
                        break;
                    }
                }
            }
            return test;

        }

        public static Boolean verifDeadline(DateTime d)
        {
            DateTime today = DateTime.Today;
            Boolean test = true;

            if (d.Equals(today) || d.CompareTo(today) < 0) //si l'utilisateur n'a sélectionné aucune date donc la date d'aujourd'hui est restée sélectionnée ou la date séléctionnée est inférieure à celle d'aujourd'hui (le deadline est déjà dépassé)
            {

                test = false;
            }

            return test;
        }
        public Boolean verifBirthDate(DateTime d)
        {
            DateTime today = DateTime.Today;
            Boolean test = true;

            if (d.Equals(today)) //si l'utilisateur n'a sélectionné aucune date donc la date d'aujourd'hui est restée sélectionnée
            {
                ErrBirthdate.Text = "Please select your birthdate !";
                birthdate_txt.ForeColor = System.Drawing.Color.Salmon;
                test = false;
            }
            else
            {//Sinon

                if (d.CompareTo(today) > 0)//si la date sélectionnée est supérieure à la date courante
                {
                    ErrBirthdate.Text = "Please select a valid birthdate !";
                    birthdate_txt.ForeColor = System.Drawing.Color.Salmon;
                    test = false;
                }
            }
            return test;
        }

        public static String conversion_virgule_en_point(String chh)
        {
            String ch = chh.Replace(',', '.');

            return ch;
        }
        public static Boolean verifDecimal(String ch1)
        {
            Boolean testDecimal = true; int nbrpoint = 0;
            if (ch1.Equals("") || ch1.Equals(" "))
                testDecimal = false;
            else
            {

                if (ch1[0] == '.') // ça veut dire ".1935" devient "0.1935"
                {
                    Char ch = '0';
                    ch1 = ch + ch1;
                }
                else if (ch1[(ch1.Length) - 1] == '.')// ça veut dire "1935." devient "1935.0"
                {
                    Char ch = '0';
                    ch1 = ch1 + ch;
                }

                for (int i = 0; i < ch1.Length; i++)
                {
                    if (!Char.IsDigit(ch1[i]) && ch1[i] != '.')// si le caractère actuel est # d'un chiffre ou d'un point
                    {
                        testDecimal = false;
                        break;
                    }
                    if (ch1[i] == '.')
                        nbrpoint++;

                }
                if (nbrpoint > 1)//la chaine ne doit contenir qu'un seul point
                    testDecimal = false;
            }
            return testDecimal;
        }
        public static Boolean verifEmail(String ch) //fonction qui vérifie que l'email saisi est correct (il contient un @ suivi par un point)
        {
            Boolean test = true, trouver_at = false, trouver_point = false;
            if (ch.Equals("") || ch.Equals(" "))
                test = false;
            else
            {
                int i;
                for (i = 0; i < ch.Length; i++)
                {
                    if (ch[i] == '@')
                    {
                        trouver_at = true;
                        break;
                    }
                }
                if (trouver_at)
                {
                    for (int j = i; j < ch.Length; j++)
                    {
                        if (ch[j] == '.')
                        {
                            trouver_point = true;
                            break;
                        }

                    }
                }
            }
            if (!trouver_at || !trouver_point)
                test = false;


            return test;
        }

        public Boolean verifPSWD(String ch)//une fonction qui vérifie que le mot de passe saisi dans le champ Password et celui saisi dans le champ verify password sont identiques
        {
            Boolean test = true;
            if (ch.Equals("") || ch.Equals(" "))
            {
                test = false;
            }
            else
            {
                if (!ch.Equals(password_txt.Text))
                    test = false;
            }
            return test;

        }

        private void contiinue_Click_1(object sender, EventArgs e)
        {
            int i = 0;//ce compteur va nous renseigner après si les champs sont tous remplis correctement ou pas

            if (!verifAlpha(first_name.Text))
            {
                i = 1;
                ErrFirstName.Text = "Please enter a correct first name !";
                first_name.Text = "";
                first_name.ForeColor = System.Drawing.Color.Salmon;

            }
            else
            {
                ErrFirstName.Text = "";
                first_name.ForeColor = System.Drawing.Color.Black;

            }

            if (!verifAlpha(last_name.Text))
            {
                i = 1;
                ErrLastName.Text = "Please enter a correct last name !";
                last_name.Text = "";
                last_name.ForeColor = System.Drawing.Color.Salmon;
            }
            else
            {
                ErrLastName.Text = "";
                last_name.ForeColor = System.Drawing.Color.Black;

            }
            if (!verifBirthDate(birthdate_txt.Value.Date))
            {
                i = 1;
                birthdate_txt.ForeColor = System.Drawing.Color.Salmon;
            }
            else
            {
                ErrBirthdate.Text = "";
                birthdate_txt.ForeColor = System.Drawing.Color.Black;
            }

            if (cmb_profession.SelectedItem == null)
            {
                ErrProfession.Text = "Pleaser select your profession !";
                i = 1;
            }
            else
            {
                ErrProfession.Text = "";
            }

            if ((!male.Checked) && (!female.Checked))
            {
                i = 1;
                ErrGender.Text = "Please select your gender !";
            }
            else
            {
                ErrGender.Text = "";

            }

            if (cmb_situation.SelectedItem == null)
            {
                ErrSituation.Text = "Pleaser select your situation !";
                i = 1;
            }
            else
            {
                ErrSituation.Text = "";
            }

            if (address_txt.Text == "" || address_txt.Text == " ")
            {
                i = 1;
                ErrAddress.Text = "Please enter your address correctly !";
                address_txt.Text = "";
                address_txt.ForeColor = System.Drawing.Color.Salmon;
            }
            else
            {
                ErrAddress.Text = "";
                address_txt.ForeColor = System.Drawing.Color.Black;
            }

            if (cmb_country.SelectedItem == null)
            {
                ErrCountry.Text = "Pleaser select your country so you can find your city too !";
                i = 1;
            }
            else
            {
                ErrCountry.Text = "";

            }

            if (!verifDigit(phone_txt.Text))
            {
                i = 1;
                ErrPhone.Text = "Please enter a correct phone number !";
                phone_txt.Text = "";
                phone_txt.ForeColor = System.Drawing.Color.Salmon;

            }
            else
            {
                ErrPhone.Text = "";
                phone_txt.ForeColor = System.Drawing.Color.Black;

            }

            if (cmb_city.SelectedItem == null)
            {
                ErrCity.Text = "Pleaser select your city !";
                i = 1;
            }
            else
            {
                ErrCity.Text = "";
            }

            if (!verifEmail(email_txt.Text))
            {
                i = 1;
                ErrEmail.Text = "Please enter a correct email address !";
                email_txt.Text = "";
                email_txt.ForeColor = System.Drawing.Color.Salmon;
            }
            else
            {
                ErrEmail.Text = "";
                email_txt.ForeColor = System.Drawing.Color.Black;
            }

            if (!verifDigitOrAlpha(login_txt.Text))
            {
                i = 1;
                ErrLogin.Text = "Please enter a correct username ! (Only letters and figures)";
                login_txt.Text = "";
                login_txt.ForeColor = System.Drawing.Color.Salmon;
            }
            else
            {
                ErrLogin.Text = "";
                login_txt.ForeColor = System.Drawing.Color.Black;
            }

            if (password_txt.Text.Equals("") || password_txt.Text.Equals(" "))
            {
                i = 1;
                ErrPassword.Text = "Please enter a password !";
                password_txt.Text = "";
                password_txt.ForeColor = System.Drawing.Color.Salmon;
            }
            else
            {
                ErrPassword.Text = "";
                password_txt.ForeColor = System.Drawing.Color.Black;

            }
            if (!verifPSWD(vpassword_txt.Text))
            {
                i = 1;
                Errvpassword.Text = "Please enter the same password written before !";
                vpassword_txt.Text = "";
                vpassword_txt.ForeColor = System.Drawing.Color.Salmon;
            }
            else
            {
                Errvpassword.Text = "";
                vpassword_txt.ForeColor = System.Drawing.Color.Black;
            }

            if (!accept_checkbox.Checked)
            {
                i = 1;
                ErrCheckbox.Text = "The Terms of Service must be accepted !";
            }
            else
            {
                ErrCheckbox.Text = "";
            }

            if (i == 0)//si tous les champs sont correctement remplis
            {
                try
                {//1: créer une instance
                    Users u = new Users();
                    //2: initialisation des propriétes
                    u.ProfilePicture = path;
                    u.Login = login_txt.Text;
                    u.Password = password_txt.Text;
                    u.Email = email_txt.Text;
                    u.LastName = last_name.Text;
                    u.FirstName = first_name.Text;
                    u.DBth = birthdate_txt.Value;
                    u.Profession = cmb_profession.SelectedItem.ToString();
                    if (male.Checked)
                        u.Gender = male.Text;
                    else u.Gender = female.Text;
                    u.Situation = cmb_situation.SelectedItem.ToString();
                    u.Address = address_txt.Text;
                    u.Country = cmb_country.SelectedItem.ToString();
                    u.City = cmb_city.SelectedItem.ToString();
                    u.Phone = phone_txt.Text;
                    //3: insertion de l'object u dans la table (Users)
                    dbnadhemni.Users.InsertOnSubmit(u);
                    //4: mettre à jour la base de données
                    dbnadhemni.SubmitChanges();
                    MessageBox.Show("Insertion successful ...");

                    if (cmb_situation.SelectedItem.ToString() == "Single")
                    {
                        this.Hide();
                        Parents p = new Parents();
                        p.Show();
                    }
                    else if (cmb_situation.SelectedItem.ToString() == "Couple")
                    {
                        this.Hide();
                        Couple c = new Couple();
                        c.Show();
                    }
                    else if (cmb_situation.SelectedItem.ToString() == "Married")
                    {
                        this.Hide();
                        Married m = new Married();
                        m.Show();
                    }
                    else
                    {
                        this.Hide();
                        Divorced d = new Divorced();
                        d.Show();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void _pwd_Click(object sender, EventArgs e)
        {

        }

        private void show_pwd_Click(object sender, EventArgs e)
        {
            show_pwd.Hide();
            hide_pwd.Show();
            password_txt.isPassword = false;
        }

        private void hide_pwd_Click(object sender, EventArgs e)
        {
            hide_pwd.Hide();
            show_pwd.Show();
            password_txt.isPassword = true;
        }

        private void show_vpwd_Click(object sender, EventArgs e)
        {
            show_vpwd.Hide();
            hide_vpwd.Show();
            vpassword_txt.isPassword = false;


        }

        private void hide_vpwd_Click(object sender, EventArgs e)
        {
            hide_vpwd.Hide();
            show_vpwd.Show();
            vpassword_txt.isPassword = true;

        }

        private void cmb_city_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cmb_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_country.SelectedIndex == 0)
            {
                cmb_city.Items.Clear();
                cmb_city.Items.Add("Paris");
                cmb_city.Items.Add("Lyon");
                cmb_city.Items.Add("Bordeaux");
                cmb_city.Items.Add("Marseille");
                cmb_city.Items.Add("Toulouse");
                cmb_city.Items.Add("Strasbourg");
                cmb_city.Items.Add("Nice");
                cmb_city.Items.Add("Montpellier");
                cmb_city.Items.Add("Dijon");
            }
            else if (cmb_country.SelectedIndex == 1)
            {
                cmb_city.Items.Clear();
                cmb_city.Items.Add("Toronto");
                cmb_city.Items.Add("Montréal");
                cmb_city.Items.Add("Ottawa");
                cmb_city.Items.Add("Québec");
                cmb_city.Items.Add("Oshawa");
                cmb_city.Items.Add("Prince George");
            }
            else if (cmb_country.SelectedIndex == 2)
            {
                cmb_city.Items.Clear();
                cmb_city.Items.Add("New York");
                cmb_city.Items.Add("San Francisco");
                cmb_city.Items.Add("Chicago");
                cmb_city.Items.Add("Los Angeles");
                cmb_city.Items.Add("Portland");
                cmb_city.Items.Add("Boston");
            }
            else if (cmb_country.SelectedIndex == 3)
            {
                cmb_city.Items.Clear();
                cmb_city.Items.Add("Manchester");
                cmb_city.Items.Add("Liverpool");
                cmb_city.Items.Add("Brighton");
                cmb_city.Items.Add("Oxford");
            }

            else if (cmb_country.SelectedIndex == 4)
            {
                cmb_city.Items.Clear();
                cmb_city.Items.Add("Manouba");
                cmb_city.Items.Add("Ben Arous");
                cmb_city.Items.Add("Tunis");
                cmb_city.Items.Add("Sousse");
                cmb_city.Items.Add("Mehdia");
                cmb_city.Items.Add("Djerba");
            }
        }

        private void email_txt_OnValueChanged(object sender, EventArgs e)
        {

        }



        private void password_keyDown(object sender, KeyEventArgs e)
        {
            int numbers = 0, letters = 0;
            if (password_txt.Text == "")
                security_level.Text = "";
            if (e.KeyCode != Keys.Space)
            {
                for (int i = 0; i < password_txt.Text.Length; i++)
                {
                    if (Char.IsDigit(password_txt.Text[i]))
                        numbers++;
                    else if (Char.IsLetter(password_txt.Text[i]))
                        letters++;
                }
            }
            if ((numbers == 2 && letters == 0) || (numbers == 0 && letters == 2))
                security_level.Text = "LOW";
            else if (numbers > 1 && numbers < 5 && letters > 5 && letters < 8)
                security_level.Text = "MEDIUM";
            else if (numbers > 4 && letters > 7)
                security_level.Text = "HIGH";


        }

        private void login_existance_keyDown(object sender, KeyEventArgs e)
        {
            var user = from x in Register_Form.dbnadhemni.Users
                       where x.Login == login_txt.Text
                       select x;

            Boolean trouve = false;

            foreach (var item in user)
                trouve = true;

            if (trouve)
            {
                login_existance.Text = "USED";
                securityExistance.BackgroundImage = Nadhemni.Properties.Resources.effacer_50;
            }
            else
            {
                login_existance.Text = "UNUSED";
                securityExistance.BackgroundImage = Nadhemni.Properties.Resources.coche_50;
            }

        }

        private void phone_txt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void password_txt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void facebook_Click(object sender, EventArgs e)
        {
            FBDialog fbd = new FBDialog("266583961204055", "user_photos,user_videos");
          
            switch (fbd.ShowDialog(this))
            {
                case DialogResult.Abort:    // There was an error
                    // Get the error information
                     MessageBox.Show("There was an error or the user denied access! See log window for more information!", "Error: An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DialogResult.Cancel:   // User clicked cancel or closed the dialog
                    MessageBox.Show("The user clicked cancel or closed the dialog!", "Error: Interupted by user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DialogResult.OK:   // Logon successfull
                    MessageBox.Show("User login was successfull!", "Successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Users u = new Users();
                    var userss = (from x in Register_Form.dbnadhemni.Users
                                  orderby x.Id_user descending
                                  select x.Id_user).First();

                   
                    String ch=userss.ToString();
                    int id = int.Parse(ch)+1;
                    //set iduser bel id
                    Job j = new Job();
                   this.Hide();
                    j.Show();
                    break;
                default:
                    break;
            }
        }
        public static string GetLogoutURL(string AccessToken)
        {
            var fb = new FacebookClient();
            var logoutUrl = fb.GetLogoutUrl(new { access_token = AccessToken, next = "https://www.facebook.com/connect/login_success.html" });
            return logoutUrl.ToString();
        }
        private void google_Click_1(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void select_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Select your profile picture";
            fd.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
            fd.ShowDialog();
            path = fd.FileName;
            if (!path.Equals(""))
            {
                profile_picture.Image = Image.FromFile(path);
                deleteProfilePicture.Show();
            }
        }

        private void deleteProfilePicture_Click(object sender, EventArgs e)
        {
            profile_picture.Image = null;
            deleteProfilePicture.Hide();

        }

        private void tweeter_Click(object sender, EventArgs e)
        {
            var result =MessageBox.Show("Are you sure to delete your account ?", "Removal Process..",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Users u = new Users();
                var userss = from x in Register_Form.dbnadhemni.Users
                             where x.Id_user == sign_in.GetUserID()
                             select x;
                foreach (var item in userss)

                    Register_Form.dbnadhemni.Users.DeleteOnSubmit(item);

                Register_Form.dbnadhemni.SubmitChanges();
                MessageBox.Show("We hope we see you again !");
                this.Hide();
                sign_in s = new sign_in();
                s.Show();
            }
        }
    }
}