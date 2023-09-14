namespace Nadhemni
{
    partial class depart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(depart));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.gunaCircleButton2 = new Guna.UI.WinForms.GunaCircleButton();
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sideMenu = new System.Windows.Forms.Panel();
            this.gunaImageButton3 = new Guna.UI.WinForms.GunaImageButton();
            this.logo = new Guna.UI.WinForms.GunaImageButton();
            this.gunaGradientButton8 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaGradientButton5 = new Guna.UI.WinForms.GunaGradientButton();
            this.events = new Guna.UI.WinForms.GunaGradientButton();
            this.beauty = new Guna.UI.WinForms.GunaGradientButton();
            this.Pets = new Guna.UI.WinForms.GunaGradientButton();
            this.Job = new Guna.UI.WinForms.GunaGradientButton();
            this.Health = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelHeader.SuspendLayout();
            this.sideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.Silver;
            this.panelHeader.Controls.Add(this.gunaCircleButton2);
            this.bunifuTransition1.SetDecoration(this.panelHeader, BunifuAnimatorNS.DecorationType.None);
            this.panelHeader.Location = new System.Drawing.Point(1, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(925, 30);
            this.panelHeader.TabIndex = 49;
            // 
            // gunaCircleButton2
            // 
            this.gunaCircleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaCircleButton2.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton2.AnimationSpeed = 0.03F;
            this.gunaCircleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaCircleButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaCircleButton2.BorderColor = System.Drawing.Color.Black;
            this.bunifuTransition1.SetDecoration(this.gunaCircleButton2, BunifuAnimatorNS.DecorationType.None);
            this.gunaCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton2.ForeColor = System.Drawing.SystemColors.Window;
            this.gunaCircleButton2.Image = null;
            this.gunaCircleButton2.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleButton2.Location = new System.Drawing.Point(889, 3);
            this.gunaCircleButton2.Name = "gunaCircleButton2";
            this.gunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.gunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton2.OnHoverImage = null;
            this.gunaCircleButton2.OnPressedColor = System.Drawing.Color.DarkRed;
            this.gunaCircleButton2.Size = new System.Drawing.Size(33, 24);
            this.gunaCircleButton2.TabIndex = 12;
            this.gunaCircleButton2.Text = "X";
            this.gunaCircleButton2.Click += new System.EventHandler(this.gunaCircleButton2_Click);
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.panelHeader;
            this.bunifuDragControl3.Vertical = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cat.jpg");
            this.imageList1.Images.SetKeyName(1, "dog.jpg");
            this.imageList1.Images.SetKeyName(2, "parrot.jpg");
            this.imageList1.Images.SetKeyName(3, "rabbit.jpg");
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = null;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sideMenu
            // 
            this.sideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sideMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sideMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sideMenu.Controls.Add(this.gunaImageButton3);
            this.sideMenu.Controls.Add(this.logo);
            this.sideMenu.Controls.Add(this.gunaGradientButton8);
            this.sideMenu.Controls.Add(this.gunaImageButton1);
            this.sideMenu.Controls.Add(this.gunaGradientButton5);
            this.sideMenu.Controls.Add(this.events);
            this.sideMenu.Controls.Add(this.beauty);
            this.sideMenu.Controls.Add(this.Pets);
            this.sideMenu.Controls.Add(this.Job);
            this.sideMenu.Controls.Add(this.Health);
            this.sideMenu.Controls.Add(this.gunaGradientButton1);
            this.bunifuTransition1.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.sideMenu.Location = new System.Drawing.Point(-2, 1);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(166, 648);
            this.sideMenu.TabIndex = 50;
            // 
            // gunaImageButton3
            // 
            this.gunaImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton3.BackgroundImage")));
            this.gunaImageButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.gunaImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.gunaImageButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton3.Image = null;
            this.gunaImageButton3.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton3.Location = new System.Drawing.Point(12, 42);
            this.gunaImageButton3.Name = "gunaImageButton3";
            this.gunaImageButton3.OnHoverImage = null;
            this.gunaImageButton3.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton3.Size = new System.Drawing.Size(20, 26);
            this.gunaImageButton3.TabIndex = 20;
            this.gunaImageButton3.Click += new System.EventHandler(this.gunaImageButton3_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logo.Image = null;
            this.logo.ImageSize = new System.Drawing.Size(64, 64);
            this.logo.Location = new System.Drawing.Point(38, 36);
            this.logo.Name = "logo";
            this.logo.OnHoverImage = null;
            this.logo.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.logo.Size = new System.Drawing.Size(114, 89);
            this.logo.TabIndex = 12;
            // 
            // gunaGradientButton8
            // 
            this.gunaGradientButton8.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton8.AnimationSpeed = 0.03F;
            this.gunaGradientButton8.BaseColor1 = System.Drawing.Color.Transparent;
            this.gunaGradientButton8.BaseColor2 = System.Drawing.Color.Transparent;
            this.gunaGradientButton8.BorderColor = System.Drawing.Color.Black;
            this.bunifuTransition1.SetDecoration(this.gunaGradientButton8, BunifuAnimatorNS.DecorationType.None);
            this.gunaGradientButton8.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton8.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.gunaGradientButton8.ForeColor = System.Drawing.Color.Black;
            this.gunaGradientButton8.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton8.Image")));
            this.gunaGradientButton8.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton8.Location = new System.Drawing.Point(3, 407);
            this.gunaGradientButton8.Name = "gunaGradientButton8";
            this.gunaGradientButton8.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaGradientButton8.OnHoverBaseColor2 = System.Drawing.Color.Transparent;
            this.gunaGradientButton8.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton8.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton8.OnHoverImage = null;
            this.gunaGradientButton8.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton8.Size = new System.Drawing.Size(190, 39);
            this.gunaGradientButton8.TabIndex = 19;
            this.gunaGradientButton8.Text = "Bills";
            this.gunaGradientButton8.Click += new System.EventHandler(this.gunaGradientButton8_Click);
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.BackgroundImage")));
            this.gunaImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.gunaImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = null;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(3, 464);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(33, 34);
            this.gunaImageButton1.TabIndex = 7;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // gunaGradientButton5
            // 
            this.gunaGradientButton5.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton5.AnimationSpeed = 0.03F;
            this.gunaGradientButton5.BaseColor1 = System.Drawing.Color.Transparent;
            this.gunaGradientButton5.BaseColor2 = System.Drawing.Color.Transparent;
            this.gunaGradientButton5.BorderColor = System.Drawing.Color.Black;
            this.bunifuTransition1.SetDecoration(this.gunaGradientButton5, BunifuAnimatorNS.DecorationType.None);
            this.gunaGradientButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.gunaGradientButton5.ForeColor = System.Drawing.Color.Black;
            this.gunaGradientButton5.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton5.Image")));
            this.gunaGradientButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton5.Location = new System.Drawing.Point(3, 368);
            this.gunaGradientButton5.Name = "gunaGradientButton5";
            this.gunaGradientButton5.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaGradientButton5.OnHoverBaseColor2 = System.Drawing.Color.Transparent;
            this.gunaGradientButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton5.OnHoverImage = null;
            this.gunaGradientButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton5.Size = new System.Drawing.Size(190, 39);
            this.gunaGradientButton5.TabIndex = 18;
            this.gunaGradientButton5.Text = "Peggy Bank";
            this.gunaGradientButton5.Click += new System.EventHandler(this.gunaGradientButton5_Click);
            // 
            // events
            // 
            this.events.AnimationHoverSpeed = 0.07F;
            this.events.AnimationSpeed = 0.03F;
            this.events.BaseColor1 = System.Drawing.Color.Transparent;
            this.events.BaseColor2 = System.Drawing.Color.Transparent;
            this.events.BorderColor = System.Drawing.Color.Black;
            this.bunifuTransition1.SetDecoration(this.events, BunifuAnimatorNS.DecorationType.None);
            this.events.DialogResult = System.Windows.Forms.DialogResult.None;
            this.events.FocusedColor = System.Drawing.Color.Empty;
            this.events.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.events.ForeColor = System.Drawing.Color.Black;
            this.events.Image = ((System.Drawing.Image)(resources.GetObject("events.Image")));
            this.events.ImageSize = new System.Drawing.Size(20, 20);
            this.events.Location = new System.Drawing.Point(3, 329);
            this.events.Name = "events";
            this.events.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.events.OnHoverBaseColor2 = System.Drawing.Color.Transparent;
            this.events.OnHoverBorderColor = System.Drawing.Color.Black;
            this.events.OnHoverForeColor = System.Drawing.Color.White;
            this.events.OnHoverImage = null;
            this.events.OnPressedColor = System.Drawing.Color.Black;
            this.events.Size = new System.Drawing.Size(190, 39);
            this.events.TabIndex = 17;
            this.events.Text = "Events";
            this.events.Click += new System.EventHandler(this.events_Click);
            // 
            // beauty
            // 
            this.beauty.AnimationHoverSpeed = 0.07F;
            this.beauty.AnimationSpeed = 0.03F;
            this.beauty.BaseColor1 = System.Drawing.Color.Transparent;
            this.beauty.BaseColor2 = System.Drawing.Color.Transparent;
            this.beauty.BorderColor = System.Drawing.Color.Black;
            this.bunifuTransition1.SetDecoration(this.beauty, BunifuAnimatorNS.DecorationType.None);
            this.beauty.DialogResult = System.Windows.Forms.DialogResult.None;
            this.beauty.FocusedColor = System.Drawing.Color.Empty;
            this.beauty.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.beauty.ForeColor = System.Drawing.Color.Black;
            this.beauty.Image = ((System.Drawing.Image)(resources.GetObject("beauty.Image")));
            this.beauty.ImageSize = new System.Drawing.Size(20, 20);
            this.beauty.Location = new System.Drawing.Point(3, 290);
            this.beauty.Name = "beauty";
            this.beauty.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.beauty.OnHoverBaseColor2 = System.Drawing.Color.Transparent;
            this.beauty.OnHoverBorderColor = System.Drawing.Color.Black;
            this.beauty.OnHoverForeColor = System.Drawing.Color.White;
            this.beauty.OnHoverImage = null;
            this.beauty.OnPressedColor = System.Drawing.Color.Black;
            this.beauty.Size = new System.Drawing.Size(190, 39);
            this.beauty.TabIndex = 16;
            this.beauty.Text = "Beauty";
            this.beauty.Click += new System.EventHandler(this.beauty_Click_1);
            // 
            // Pets
            // 
            this.Pets.AnimationHoverSpeed = 0.07F;
            this.Pets.AnimationSpeed = 0.03F;
            this.Pets.BaseColor1 = System.Drawing.Color.Transparent;
            this.Pets.BaseColor2 = System.Drawing.Color.Transparent;
            this.Pets.BorderColor = System.Drawing.Color.Black;
            this.bunifuTransition1.SetDecoration(this.Pets, BunifuAnimatorNS.DecorationType.None);
            this.Pets.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Pets.FocusedColor = System.Drawing.Color.Empty;
            this.Pets.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.Pets.ForeColor = System.Drawing.Color.Black;
            this.Pets.Image = ((System.Drawing.Image)(resources.GetObject("Pets.Image")));
            this.Pets.ImageSize = new System.Drawing.Size(20, 20);
            this.Pets.Location = new System.Drawing.Point(3, 251);
            this.Pets.Name = "Pets";
            this.Pets.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pets.OnHoverBaseColor2 = System.Drawing.Color.Transparent;
            this.Pets.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Pets.OnHoverForeColor = System.Drawing.Color.White;
            this.Pets.OnHoverImage = null;
            this.Pets.OnPressedColor = System.Drawing.Color.Black;
            this.Pets.Size = new System.Drawing.Size(190, 39);
            this.Pets.TabIndex = 15;
            this.Pets.Text = "Pets";
            this.Pets.Click += new System.EventHandler(this.Beauty_Click);
            // 
            // Job
            // 
            this.Job.AnimationHoverSpeed = 0.07F;
            this.Job.AnimationSpeed = 0.03F;
            this.Job.BaseColor1 = System.Drawing.Color.Transparent;
            this.Job.BaseColor2 = System.Drawing.Color.Transparent;
            this.Job.BorderColor = System.Drawing.Color.Black;
            this.bunifuTransition1.SetDecoration(this.Job, BunifuAnimatorNS.DecorationType.None);
            this.Job.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Job.FocusedColor = System.Drawing.Color.Empty;
            this.Job.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.Job.ForeColor = System.Drawing.Color.Black;
            this.Job.Image = ((System.Drawing.Image)(resources.GetObject("Job.Image")));
            this.Job.ImageSize = new System.Drawing.Size(20, 20);
            this.Job.Location = new System.Drawing.Point(3, 212);
            this.Job.Name = "Job";
            this.Job.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Job.OnHoverBaseColor2 = System.Drawing.Color.Transparent;
            this.Job.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Job.OnHoverForeColor = System.Drawing.Color.White;
            this.Job.OnHoverImage = null;
            this.Job.OnPressedColor = System.Drawing.Color.Black;
            this.Job.Size = new System.Drawing.Size(190, 39);
            this.Job.TabIndex = 14;
            this.Job.Text = "Job";
            this.Job.Click += new System.EventHandler(this.Job_Click);
            // 
            // Health
            // 
            this.Health.AnimationHoverSpeed = 0.07F;
            this.Health.AnimationSpeed = 0.03F;
            this.Health.BaseColor1 = System.Drawing.Color.Transparent;
            this.Health.BaseColor2 = System.Drawing.Color.Transparent;
            this.Health.BorderColor = System.Drawing.Color.Black;
            this.bunifuTransition1.SetDecoration(this.Health, BunifuAnimatorNS.DecorationType.None);
            this.Health.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Health.FocusedColor = System.Drawing.Color.Empty;
            this.Health.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.Health.ForeColor = System.Drawing.Color.Black;
            this.Health.Image = ((System.Drawing.Image)(resources.GetObject("Health.Image")));
            this.Health.ImageSize = new System.Drawing.Size(20, 20);
            this.Health.Location = new System.Drawing.Point(3, 173);
            this.Health.Name = "Health";
            this.Health.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Health.OnHoverBaseColor2 = System.Drawing.Color.Transparent;
            this.Health.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Health.OnHoverForeColor = System.Drawing.Color.White;
            this.Health.OnHoverImage = null;
            this.Health.OnPressedColor = System.Drawing.Color.Black;
            this.Health.Size = new System.Drawing.Size(190, 39);
            this.Health.TabIndex = 13;
            this.Health.Text = "Health";
            this.Health.Click += new System.EventHandler(this.Health_Click);
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.bunifuTransition1.SetDecoration(this.gunaGradientButton1, BunifuAnimatorNS.DecorationType.None);
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton1.Image")));
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(3, 134);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(190, 39);
            this.gunaGradientButton1.TabIndex = 12;
            this.gunaGradientButton1.Text = "Family";
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // depart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(927, 500);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.sideMenu);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "depart";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.depart_Load);
            this.panelHeader.ResumeLayout(false);
            this.sideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton3;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Guna.UI.WinForms.GunaImageButton logo;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton8;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton5;
        private Guna.UI.WinForms.GunaGradientButton events;
        private Guna.UI.WinForms.GunaGradientButton beauty;
        private Guna.UI.WinForms.GunaGradientButton Pets;
        private Guna.UI.WinForms.GunaGradientButton Job;
        private Guna.UI.WinForms.GunaGradientButton Health;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private System.Windows.Forms.Panel panelHeader;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private System.Windows.Forms.ImageList imageList1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel sideMenu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}