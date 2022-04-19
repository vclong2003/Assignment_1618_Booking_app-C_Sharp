namespace ASM_1618_Mark3
{
    partial class BookingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingScreen));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.customerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.customerAge = new Guna.UI2.WinForms.Guna2TextBox();
            this.customerAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.customerIdCard = new Guna.UI2.WinForms.Guna2TextBox();
            this.roomTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.roomNumberComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.durationTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bookButton = new Guna.UI2.WinForms.Guna2Button();
            this.quitButton = new Guna.UI2.WinForms.Guna2Button();
            this.managerLoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comfirmPopup = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.LoginPopup = new Guna.UI2.WinForms.Guna2Panel();
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.usernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.comfirmPopup.SuspendLayout();
            this.LoginPopup.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2GradientPanel1.Controls.Add(this.LoginPopup);
            this.guna2GradientPanel1.Controls.Add(this.comfirmPopup);
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2GradientPanel1.Controls.Add(this.managerLoginButton);
            this.guna2GradientPanel1.Controls.Add(this.quitButton);
            this.guna2GradientPanel1.Controls.Add(this.bookButton);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.durationTextBox);
            this.guna2GradientPanel1.Controls.Add(this.roomNumberComboBox);
            this.guna2GradientPanel1.Controls.Add(this.roomTypeComboBox);
            this.guna2GradientPanel1.Controls.Add(this.flowLayoutPanel1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(147)))), ((int)(((byte)(152)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1050, 552);
            this.guna2GradientPanel1.TabIndex = 0;
            this.guna2GradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.customerName);
            this.flowLayoutPanel1.Controls.Add(this.customerAge);
            this.flowLayoutPanel1.Controls.Add(this.customerAddress);
            this.flowLayoutPanel1.Controls.Add(this.customerIdCard);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(163, 106);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(308, 312);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // customerName
            // 
            this.customerName.BackColor = System.Drawing.Color.Transparent;
            this.customerName.BorderColor = System.Drawing.Color.Transparent;
            this.customerName.BorderRadius = 15;
            this.customerName.BorderThickness = 0;
            this.customerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerName.DefaultText = "";
            this.customerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerName.DisabledState.Parent = this.customerName;
            this.customerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerName.FocusedState.Parent = this.customerName;
            this.customerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerName.HoverState.Parent = this.customerName;
            this.customerName.Location = new System.Drawing.Point(4, 15);
            this.customerName.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.customerName.Name = "customerName";
            this.customerName.PasswordChar = '\0';
            this.customerName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.customerName.PlaceholderText = "Name";
            this.customerName.SelectedText = "";
            this.customerName.ShadowDecoration.Parent = this.customerName;
            this.customerName.Size = new System.Drawing.Size(304, 38);
            this.customerName.TabIndex = 4;
            this.customerName.TextChanged += new System.EventHandler(this.guna2TextBox4_TextChanged);
            // 
            // customerAge
            // 
            this.customerAge.BorderColor = System.Drawing.Color.Transparent;
            this.customerAge.BorderRadius = 15;
            this.customerAge.BorderThickness = 0;
            this.customerAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerAge.DefaultText = "";
            this.customerAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerAge.DisabledState.Parent = this.customerAge;
            this.customerAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerAge.FocusedState.Parent = this.customerAge;
            this.customerAge.ForeColor = System.Drawing.Color.Black;
            this.customerAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerAge.HoverState.Parent = this.customerAge;
            this.customerAge.Location = new System.Drawing.Point(4, 83);
            this.customerAge.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.customerAge.Name = "customerAge";
            this.customerAge.PasswordChar = '\0';
            this.customerAge.PlaceholderForeColor = System.Drawing.Color.Black;
            this.customerAge.PlaceholderText = "Age";
            this.customerAge.SelectedText = "";
            this.customerAge.ShadowDecoration.Parent = this.customerAge;
            this.customerAge.Size = new System.Drawing.Size(61, 38);
            this.customerAge.TabIndex = 5;
            this.customerAge.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // customerAddress
            // 
            this.customerAddress.BorderColor = System.Drawing.Color.Transparent;
            this.customerAddress.BorderRadius = 15;
            this.customerAddress.BorderThickness = 0;
            this.customerAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerAddress.DefaultText = "";
            this.customerAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerAddress.DisabledState.Parent = this.customerAddress;
            this.customerAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerAddress.FocusedState.Parent = this.customerAddress;
            this.customerAddress.ForeColor = System.Drawing.Color.Black;
            this.customerAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerAddress.HoverState.Parent = this.customerAddress;
            this.customerAddress.Location = new System.Drawing.Point(4, 151);
            this.customerAddress.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.customerAddress.Multiline = true;
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.PasswordChar = '\0';
            this.customerAddress.PlaceholderForeColor = System.Drawing.Color.Black;
            this.customerAddress.PlaceholderText = "Address";
            this.customerAddress.SelectedText = "";
            this.customerAddress.ShadowDecoration.Parent = this.customerAddress;
            this.customerAddress.Size = new System.Drawing.Size(304, 79);
            this.customerAddress.TabIndex = 6;
            // 
            // customerIdCard
            // 
            this.customerIdCard.BorderColor = System.Drawing.Color.Transparent;
            this.customerIdCard.BorderRadius = 15;
            this.customerIdCard.BorderThickness = 0;
            this.customerIdCard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerIdCard.DefaultText = "";
            this.customerIdCard.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerIdCard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerIdCard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerIdCard.DisabledState.Parent = this.customerIdCard;
            this.customerIdCard.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerIdCard.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerIdCard.FocusedState.Parent = this.customerIdCard;
            this.customerIdCard.ForeColor = System.Drawing.Color.Black;
            this.customerIdCard.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerIdCard.HoverState.Parent = this.customerIdCard;
            this.customerIdCard.Location = new System.Drawing.Point(4, 260);
            this.customerIdCard.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.customerIdCard.Name = "customerIdCard";
            this.customerIdCard.PasswordChar = '\0';
            this.customerIdCard.PlaceholderForeColor = System.Drawing.Color.Black;
            this.customerIdCard.PlaceholderText = "ID Card";
            this.customerIdCard.SelectedText = "";
            this.customerIdCard.ShadowDecoration.Parent = this.customerIdCard;
            this.customerIdCard.Size = new System.Drawing.Size(185, 38);
            this.customerIdCard.TabIndex = 7;
            // 
            // roomTypeComboBox
            // 
            this.roomTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.roomTypeComboBox.BorderRadius = 15;
            this.roomTypeComboBox.BorderThickness = 0;
            this.roomTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomTypeComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.roomTypeComboBox.FocusedState.Parent = this.roomTypeComboBox;
            this.roomTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roomTypeComboBox.ForeColor = System.Drawing.Color.Black;
            this.roomTypeComboBox.FormattingEnabled = true;
            this.roomTypeComboBox.HoverState.Parent = this.roomTypeComboBox;
            this.roomTypeComboBox.ItemHeight = 30;
            this.roomTypeComboBox.ItemsAppearance.Parent = this.roomTypeComboBox;
            this.roomTypeComboBox.Location = new System.Drawing.Point(735, 123);
            this.roomTypeComboBox.Name = "roomTypeComboBox";
            this.roomTypeComboBox.ShadowDecoration.Parent = this.roomTypeComboBox;
            this.roomTypeComboBox.Size = new System.Drawing.Size(179, 36);
            this.roomTypeComboBox.TabIndex = 1;
            this.roomTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // roomNumberComboBox
            // 
            this.roomNumberComboBox.BackColor = System.Drawing.Color.Transparent;
            this.roomNumberComboBox.BorderRadius = 15;
            this.roomNumberComboBox.BorderThickness = 0;
            this.roomNumberComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomNumberComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.roomNumberComboBox.FocusedState.Parent = this.roomNumberComboBox;
            this.roomNumberComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roomNumberComboBox.ForeColor = System.Drawing.Color.Black;
            this.roomNumberComboBox.FormattingEnabled = true;
            this.roomNumberComboBox.HoverState.Parent = this.roomNumberComboBox;
            this.roomNumberComboBox.ItemHeight = 30;
            this.roomNumberComboBox.ItemsAppearance.Parent = this.roomNumberComboBox;
            this.roomNumberComboBox.Location = new System.Drawing.Point(735, 191);
            this.roomNumberComboBox.Name = "roomNumberComboBox";
            this.roomNumberComboBox.ShadowDecoration.Parent = this.roomNumberComboBox;
            this.roomNumberComboBox.Size = new System.Drawing.Size(98, 36);
            this.roomNumberComboBox.TabIndex = 2;
            this.roomNumberComboBox.Click += new System.EventHandler(this.roomNumberComboBox_Click);
            // 
            // durationTextBox
            // 
            this.durationTextBox.BackColor = System.Drawing.Color.Transparent;
            this.durationTextBox.BorderColor = System.Drawing.Color.Transparent;
            this.durationTextBox.BorderRadius = 15;
            this.durationTextBox.BorderThickness = 0;
            this.durationTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.durationTextBox.DefaultText = "";
            this.durationTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.durationTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.durationTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.durationTextBox.DisabledState.Parent = this.durationTextBox;
            this.durationTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.durationTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.durationTextBox.FocusedState.Parent = this.durationTextBox;
            this.durationTextBox.ForeColor = System.Drawing.Color.Black;
            this.durationTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.durationTextBox.HoverState.Parent = this.durationTextBox;
            this.durationTextBox.Location = new System.Drawing.Point(735, 257);
            this.durationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.PasswordChar = '\0';
            this.durationTextBox.PlaceholderText = "days";
            this.durationTextBox.SelectedText = "";
            this.durationTextBox.ShadowDecoration.Parent = this.durationTextBox;
            this.durationTextBox.Size = new System.Drawing.Size(71, 44);
            this.durationTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(380, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 60);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hotel Booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(612, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 9, 0, 9);
            this.label2.Size = new System.Drawing.Size(94, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Room Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(653, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 9, 0, 9);
            this.label3.Size = new System.Drawing.Size(53, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "Room";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(560, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 11, 0, 11);
            this.label4.Size = new System.Drawing.Size(146, 42);
            this.label4.TabIndex = 10;
            this.label4.Text = "Staying for (days):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookButton
            // 
            this.bookButton.BackColor = System.Drawing.Color.Transparent;
            this.bookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bookButton.BorderRadius = 18;
            this.bookButton.CheckedState.Parent = this.bookButton;
            this.bookButton.CustomImages.Parent = this.bookButton;
            this.bookButton.FillColor = System.Drawing.Color.DodgerBlue;
            this.bookButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bookButton.ForeColor = System.Drawing.Color.White;
            this.bookButton.HoverState.Parent = this.bookButton;
            this.bookButton.Location = new System.Drawing.Point(457, 452);
            this.bookButton.Name = "bookButton";
            this.bookButton.ShadowDecoration.Parent = this.bookButton;
            this.bookButton.Size = new System.Drawing.Size(127, 45);
            this.bookButton.TabIndex = 11;
            this.bookButton.Text = "Book";
            this.bookButton.Visible = false;
            this.bookButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Transparent;
            this.quitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.quitButton.BorderRadius = 14;
            this.quitButton.CheckedState.Parent = this.quitButton;
            this.quitButton.CustomImages.Parent = this.quitButton;
            this.quitButton.FillColor = System.Drawing.Color.Red;
            this.quitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quitButton.ForeColor = System.Drawing.Color.White;
            this.quitButton.HoverState.Parent = this.quitButton;
            this.quitButton.Location = new System.Drawing.Point(963, 505);
            this.quitButton.Name = "quitButton";
            this.quitButton.ShadowDecoration.Parent = this.quitButton;
            this.quitButton.Size = new System.Drawing.Size(74, 35);
            this.quitButton.TabIndex = 12;
            this.quitButton.Text = "Quit";
            this.quitButton.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // managerLoginButton
            // 
            this.managerLoginButton.BackColor = System.Drawing.Color.Transparent;
            this.managerLoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.managerLoginButton.BorderRadius = 14;
            this.managerLoginButton.CheckedState.Parent = this.managerLoginButton;
            this.managerLoginButton.CustomImages.Parent = this.managerLoginButton;
            this.managerLoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.managerLoginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.managerLoginButton.ForeColor = System.Drawing.Color.White;
            this.managerLoginButton.HoverState.Parent = this.managerLoginButton;
            this.managerLoginButton.Location = new System.Drawing.Point(813, 505);
            this.managerLoginButton.Name = "managerLoginButton";
            this.managerLoginButton.ShadowDecoration.Parent = this.managerLoginButton;
            this.managerLoginButton.Size = new System.Drawing.Size(144, 35);
            this.managerLoginButton.TabIndex = 13;
            this.managerLoginButton.Text = "Manager Login";
            this.managerLoginButton.Click += new System.EventHandler(this.managerLoginButton_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(709, 308);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(390, 196);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 14;
            this.guna2PictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comfirmPopup
            // 
            this.comfirmPopup.BackColor = System.Drawing.Color.White;
            this.comfirmPopup.Controls.Add(this.label7);
            this.comfirmPopup.Controls.Add(this.guna2Button2);
            this.comfirmPopup.Controls.Add(this.guna2Button1);
            this.comfirmPopup.Controls.Add(this.label5);
            this.comfirmPopup.Location = new System.Drawing.Point(223, 80);
            this.comfirmPopup.Name = "comfirmPopup";
            this.comfirmPopup.ShadowDecoration.Parent = this.comfirmPopup;
            this.comfirmPopup.Size = new System.Drawing.Size(599, 367);
            this.comfirmPopup.TabIndex = 15;
            this.comfirmPopup.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(200, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Confirm Information";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Button1.BorderRadius = 14;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(491, 311);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(90, 35);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Text = "Edit";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Button2.BorderRadius = 14;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(381, 311);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(104, 35);
            this.guna2Button2.TabIndex = 15;
            this.guna2Button2.Text = "Confirm";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
            // 
            // LoginPopup
            // 
            this.LoginPopup.BackColor = System.Drawing.Color.Transparent;
            this.LoginPopup.BorderRadius = 25;
            this.LoginPopup.BorderThickness = 1;
            this.LoginPopup.Controls.Add(this.label6);
            this.LoginPopup.Controls.Add(this.passwordTextBox);
            this.LoginPopup.Controls.Add(this.usernameTextBox);
            this.LoginPopup.Controls.Add(this.guna2Button4);
            this.LoginPopup.Controls.Add(this.loginButton);
            this.LoginPopup.FillColor = System.Drawing.Color.White;
            this.LoginPopup.Location = new System.Drawing.Point(333, 36);
            this.LoginPopup.Margin = new System.Windows.Forms.Padding(0);
            this.LoginPopup.Name = "LoginPopup";
            this.LoginPopup.ShadowDecoration.Parent = this.LoginPopup;
            this.LoginPopup.Size = new System.Drawing.Size(373, 468);
            this.LoginPopup.TabIndex = 16;
            this.LoginPopup.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginButton.BorderRadius = 14;
            this.loginButton.CheckedState.Parent = this.loginButton;
            this.loginButton.CustomImages.Parent = this.loginButton;
            this.loginButton.FillColor = System.Drawing.Color.DodgerBlue;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.HoverState.Parent = this.loginButton;
            this.loginButton.Location = new System.Drawing.Point(133, 366);
            this.loginButton.Name = "loginButton";
            this.loginButton.ShadowDecoration.Parent = this.loginButton;
            this.loginButton.Size = new System.Drawing.Size(101, 35);
            this.loginButton.TabIndex = 14;
            this.loginButton.Text = "Login";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Button4.BorderRadius = 14;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(156, 417);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(57, 35);
            this.guna2Button4.TabIndex = 15;
            this.guna2Button4.Text = "Back";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderColor = System.Drawing.Color.Black;
            this.usernameTextBox.BorderRadius = 15;
            this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextBox.DefaultText = "";
            this.usernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.DisabledState.Parent = this.usernameTextBox;
            this.usernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextBox.FocusedState.Parent = this.usernameTextBox;
            this.usernameTextBox.ForeColor = System.Drawing.Color.Black;
            this.usernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextBox.HoverState.Parent = this.usernameTextBox;
            this.usernameTextBox.Location = new System.Drawing.Point(57, 142);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.PlaceholderText = "Username";
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.ShadowDecoration.Parent = this.usernameTextBox;
            this.usernameTextBox.Size = new System.Drawing.Size(267, 44);
            this.usernameTextBox.TabIndex = 16;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderColor = System.Drawing.Color.Black;
            this.passwordTextBox.BorderRadius = 15;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.DefaultText = "";
            this.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.DisabledState.Parent = this.passwordTextBox;
            this.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.FocusedState.Parent = this.passwordTextBox;
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.HoverState.Parent = this.passwordTextBox;
            this.passwordTextBox.Location = new System.Drawing.Point(57, 221);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.PlaceholderText = "Password";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.ShadowDecoration.Parent = this.passwordTextBox;
            this.passwordTextBox.Size = new System.Drawing.Size(267, 44);
            this.passwordTextBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 41);
            this.label6.TabIndex = 18;
            this.label6.Text = "Login";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "This is just a placeholder, I will do it later!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 552);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.comfirmPopup.ResumeLayout(false);
            this.comfirmPopup.PerformLayout();
            this.LoginPopup.ResumeLayout(false);
            this.LoginPopup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox customerName;
        private Guna.UI2.WinForms.Guna2TextBox customerAge;
        private Guna.UI2.WinForms.Guna2TextBox customerAddress;
        private Guna.UI2.WinForms.Guna2TextBox customerIdCard;
        private Guna.UI2.WinForms.Guna2TextBox durationTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox roomNumberComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox roomTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button bookButton;
        private Guna.UI2.WinForms.Guna2Button managerLoginButton;
        private Guna.UI2.WinForms.Guna2Button quitButton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel comfirmPopup;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel LoginPopup;
        private Guna.UI2.WinForms.Guna2TextBox usernameTextBox;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

