namespace SlowPerformanceMonitor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.choiceBroswer = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtDaysToMonitor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtUrl = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.toggleIsSignInRequired = new MetroFramework.Controls.MetroToggle();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtManualSignInTime = new MetroFramework.Controls.MetroTextBox();
            this.txtSlowPerformanceReoccurrenceThreshold = new MetroFramework.Controls.MetroTextBox();
            this.txtPageLoadThreshold = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtSleepTime = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.txtPasswords = new MetroFramework.Controls.MetroTextBox();
            this.lbPasswords = new MetroFramework.Controls.MetroLabel();
            this.txtLoginName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.txtSmtpPort = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txtSmtpAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txtMsg = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txtSubject = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtCc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtFrom = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtTo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lbMsg = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(754, 250);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.choiceBroswer);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.txtDaysToMonitor);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.txtUrl);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(746, 208);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Home";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // choiceBroswer
            // 
            this.choiceBroswer.FormattingEnabled = true;
            this.choiceBroswer.ItemHeight = 23;
            this.choiceBroswer.Items.AddRange(new object[] {
            "IE",
            "Chrome",
            "FireFox",
            "Edge"});
            this.choiceBroswer.Location = new System.Drawing.Point(87, 97);
            this.choiceBroswer.Name = "choiceBroswer";
            this.choiceBroswer.Size = new System.Drawing.Size(121, 29);
            this.choiceBroswer.TabIndex = 4;
            this.choiceBroswer.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(0, 107);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Broswer type:";
            // 
            // txtDaysToMonitor
            // 
            // 
            // 
            // 
            this.txtDaysToMonitor.CustomButton.Image = null;
            this.txtDaysToMonitor.CustomButton.Location = new System.Drawing.Point(7, 1);
            this.txtDaysToMonitor.CustomButton.Name = "";
            this.txtDaysToMonitor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDaysToMonitor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDaysToMonitor.CustomButton.TabIndex = 1;
            this.txtDaysToMonitor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDaysToMonitor.CustomButton.UseSelectable = true;
            this.txtDaysToMonitor.CustomButton.Visible = false;
            this.txtDaysToMonitor.Lines = new string[0];
            this.txtDaysToMonitor.Location = new System.Drawing.Point(243, 154);
            this.txtDaysToMonitor.MaxLength = 32767;
            this.txtDaysToMonitor.Name = "txtDaysToMonitor";
            this.txtDaysToMonitor.PasswordChar = '\0';
            this.txtDaysToMonitor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDaysToMonitor.SelectedText = "";
            this.txtDaysToMonitor.SelectionLength = 0;
            this.txtDaysToMonitor.SelectionStart = 0;
            this.txtDaysToMonitor.ShortcutsEnabled = true;
            this.txtDaysToMonitor.Size = new System.Drawing.Size(29, 23);
            this.txtDaysToMonitor.TabIndex = 3;
            this.txtDaysToMonitor.UseSelectable = true;
            this.txtDaysToMonitor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDaysToMonitor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 158);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(235, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "How many days you\'d preffer monitor:";
            // 
            // txtUrl
            // 
            // 
            // 
            // 
            this.txtUrl.CustomButton.Image = null;
            this.txtUrl.CustomButton.Location = new System.Drawing.Point(637, 1);
            this.txtUrl.CustomButton.Name = "";
            this.txtUrl.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUrl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUrl.CustomButton.TabIndex = 1;
            this.txtUrl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUrl.CustomButton.UseSelectable = true;
            this.txtUrl.CustomButton.Visible = false;
            this.txtUrl.Lines = new string[0];
            this.txtUrl.Location = new System.Drawing.Point(87, 49);
            this.txtUrl.MaxLength = 32767;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.PasswordChar = '\0';
            this.txtUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrl.SelectedText = "";
            this.txtUrl.SelectionLength = 0;
            this.txtUrl.SelectionStart = 0;
            this.txtUrl.ShortcutsEnabled = true;
            this.txtUrl.Size = new System.Drawing.Size(659, 23);
            this.txtUrl.TabIndex = 3;
            this.txtUrl.UseSelectable = true;
            this.txtUrl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUrl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 53);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "URLs:";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.toggleIsSignInRequired);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.txtManualSignInTime);
            this.metroTabPage2.Controls.Add(this.txtSlowPerformanceReoccurrenceThreshold);
            this.metroTabPage2.Controls.Add(this.txtPageLoadThreshold);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.txtSleepTime);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(746, 208);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Options";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // toggleIsSignInRequired
            // 
            this.toggleIsSignInRequired.AutoSize = true;
            this.toggleIsSignInRequired.Location = new System.Drawing.Point(303, 159);
            this.toggleIsSignInRequired.Name = "toggleIsSignInRequired";
            this.toggleIsSignInRequired.Size = new System.Drawing.Size(80, 17);
            this.toggleIsSignInRequired.TabIndex = 4;
            this.toggleIsSignInRequired.Text = "Off";
            this.toggleIsSignInRequired.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Location = new System.Drawing.Point(0, 157);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(146, 19);
            this.metroLabel8.TabIndex = 3;
            this.metroLabel8.Text = "Is sign-in required?";
            // 
            // txtManualSignInTime
            // 
            // 
            // 
            // 
            this.txtManualSignInTime.CustomButton.Image = null;
            this.txtManualSignInTime.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.txtManualSignInTime.CustomButton.Name = "";
            this.txtManualSignInTime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtManualSignInTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtManualSignInTime.CustomButton.TabIndex = 1;
            this.txtManualSignInTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtManualSignInTime.CustomButton.UseSelectable = true;
            this.txtManualSignInTime.CustomButton.Visible = false;
            this.txtManualSignInTime.Lines = new string[0];
            this.txtManualSignInTime.Location = new System.Drawing.Point(303, 121);
            this.txtManualSignInTime.MaxLength = 32767;
            this.txtManualSignInTime.Name = "txtManualSignInTime";
            this.txtManualSignInTime.PasswordChar = '\0';
            this.txtManualSignInTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtManualSignInTime.SelectedText = "";
            this.txtManualSignInTime.SelectionLength = 0;
            this.txtManualSignInTime.SelectionStart = 0;
            this.txtManualSignInTime.ShortcutsEnabled = true;
            this.txtManualSignInTime.Size = new System.Drawing.Size(80, 23);
            this.txtManualSignInTime.TabIndex = 2;
            this.txtManualSignInTime.UseSelectable = true;
            this.txtManualSignInTime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtManualSignInTime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSlowPerformanceReoccurrenceThreshold
            // 
            // 
            // 
            // 
            this.txtSlowPerformanceReoccurrenceThreshold.CustomButton.Image = null;
            this.txtSlowPerformanceReoccurrenceThreshold.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.txtSlowPerformanceReoccurrenceThreshold.CustomButton.Name = "";
            this.txtSlowPerformanceReoccurrenceThreshold.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSlowPerformanceReoccurrenceThreshold.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSlowPerformanceReoccurrenceThreshold.CustomButton.TabIndex = 1;
            this.txtSlowPerformanceReoccurrenceThreshold.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSlowPerformanceReoccurrenceThreshold.CustomButton.UseSelectable = true;
            this.txtSlowPerformanceReoccurrenceThreshold.CustomButton.Visible = false;
            this.txtSlowPerformanceReoccurrenceThreshold.Lines = new string[0];
            this.txtSlowPerformanceReoccurrenceThreshold.Location = new System.Drawing.Point(303, 92);
            this.txtSlowPerformanceReoccurrenceThreshold.MaxLength = 32767;
            this.txtSlowPerformanceReoccurrenceThreshold.Name = "txtSlowPerformanceReoccurrenceThreshold";
            this.txtSlowPerformanceReoccurrenceThreshold.PasswordChar = '\0';
            this.txtSlowPerformanceReoccurrenceThreshold.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSlowPerformanceReoccurrenceThreshold.SelectedText = "";
            this.txtSlowPerformanceReoccurrenceThreshold.SelectionLength = 0;
            this.txtSlowPerformanceReoccurrenceThreshold.SelectionStart = 0;
            this.txtSlowPerformanceReoccurrenceThreshold.ShortcutsEnabled = true;
            this.txtSlowPerformanceReoccurrenceThreshold.Size = new System.Drawing.Size(80, 23);
            this.txtSlowPerformanceReoccurrenceThreshold.TabIndex = 2;
            this.txtSlowPerformanceReoccurrenceThreshold.UseSelectable = true;
            this.txtSlowPerformanceReoccurrenceThreshold.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSlowPerformanceReoccurrenceThreshold.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPageLoadThreshold
            // 
            // 
            // 
            // 
            this.txtPageLoadThreshold.CustomButton.Image = null;
            this.txtPageLoadThreshold.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.txtPageLoadThreshold.CustomButton.Name = "";
            this.txtPageLoadThreshold.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPageLoadThreshold.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPageLoadThreshold.CustomButton.TabIndex = 1;
            this.txtPageLoadThreshold.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPageLoadThreshold.CustomButton.UseSelectable = true;
            this.txtPageLoadThreshold.CustomButton.Visible = false;
            this.txtPageLoadThreshold.Lines = new string[0];
            this.txtPageLoadThreshold.Location = new System.Drawing.Point(303, 63);
            this.txtPageLoadThreshold.MaxLength = 32767;
            this.txtPageLoadThreshold.Name = "txtPageLoadThreshold";
            this.txtPageLoadThreshold.PasswordChar = '\0';
            this.txtPageLoadThreshold.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPageLoadThreshold.SelectedText = "";
            this.txtPageLoadThreshold.SelectionLength = 0;
            this.txtPageLoadThreshold.SelectionStart = 0;
            this.txtPageLoadThreshold.ShortcutsEnabled = true;
            this.txtPageLoadThreshold.Size = new System.Drawing.Size(80, 23);
            this.txtPageLoadThreshold.TabIndex = 2;
            this.txtPageLoadThreshold.UseSelectable = true;
            this.txtPageLoadThreshold.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPageLoadThreshold.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.Location = new System.Drawing.Point(0, 125);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(146, 19);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Manual sign-in time:";
            // 
            // txtSleepTime
            // 
            // 
            // 
            // 
            this.txtSleepTime.CustomButton.Image = null;
            this.txtSleepTime.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.txtSleepTime.CustomButton.Name = "";
            this.txtSleepTime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSleepTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSleepTime.CustomButton.TabIndex = 1;
            this.txtSleepTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSleepTime.CustomButton.UseSelectable = true;
            this.txtSleepTime.CustomButton.Visible = false;
            this.txtSleepTime.Lines = new string[0];
            this.txtSleepTime.Location = new System.Drawing.Point(303, 34);
            this.txtSleepTime.MaxLength = 32767;
            this.txtSleepTime.Name = "txtSleepTime";
            this.txtSleepTime.PasswordChar = '\0';
            this.txtSleepTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSleepTime.SelectedText = "";
            this.txtSleepTime.SelectionLength = 0;
            this.txtSleepTime.SelectionStart = 0;
            this.txtSleepTime.ShortcutsEnabled = true;
            this.txtSleepTime.Size = new System.Drawing.Size(80, 23);
            this.txtSleepTime.TabIndex = 2;
            this.txtSleepTime.UseSelectable = true;
            this.txtSleepTime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSleepTime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(0, 96);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(263, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Slow performance reoccurrence threshold:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Location = new System.Drawing.Point(0, 67);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(146, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Page load threshold: ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(0, 38);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Sleep time:";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.txtPasswords);
            this.metroTabPage3.Controls.Add(this.lbPasswords);
            this.metroTabPage3.Controls.Add(this.txtLoginName);
            this.metroTabPage3.Controls.Add(this.metroLabel16);
            this.metroTabPage3.Controls.Add(this.txtSmtpPort);
            this.metroTabPage3.Controls.Add(this.metroLabel15);
            this.metroTabPage3.Controls.Add(this.txtSmtpAddress);
            this.metroTabPage3.Controls.Add(this.metroLabel14);
            this.metroTabPage3.Controls.Add(this.txtMsg);
            this.metroTabPage3.Controls.Add(this.metroLabel13);
            this.metroTabPage3.Controls.Add(this.txtSubject);
            this.metroTabPage3.Controls.Add(this.metroLabel12);
            this.metroTabPage3.Controls.Add(this.txtCc);
            this.metroTabPage3.Controls.Add(this.metroLabel11);
            this.metroTabPage3.Controls.Add(this.txtFrom);
            this.metroTabPage3.Controls.Add(this.metroLabel10);
            this.metroTabPage3.Controls.Add(this.txtTo);
            this.metroTabPage3.Controls.Add(this.metroLabel9);
            this.metroTabPage3.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(746, 208);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Emails";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            this.metroTabPage3.Click += new System.EventHandler(this.MetroTabPage3_Click);
            // 
            // txtPasswords
            // 
            // 
            // 
            // 
            this.txtPasswords.CustomButton.Image = null;
            this.txtPasswords.CustomButton.Location = new System.Drawing.Point(225, 1);
            this.txtPasswords.CustomButton.Name = "";
            this.txtPasswords.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPasswords.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPasswords.CustomButton.TabIndex = 1;
            this.txtPasswords.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPasswords.CustomButton.UseSelectable = true;
            this.txtPasswords.CustomButton.Visible = false;
            this.txtPasswords.Lines = new string[0];
            this.txtPasswords.Location = new System.Drawing.Point(499, 102);
            this.txtPasswords.MaxLength = 32767;
            this.txtPasswords.Name = "txtPasswords";
            this.txtPasswords.PasswordChar = '●';
            this.txtPasswords.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswords.SelectedText = "";
            this.txtPasswords.SelectionLength = 0;
            this.txtPasswords.SelectionStart = 0;
            this.txtPasswords.ShortcutsEnabled = true;
            this.txtPasswords.Size = new System.Drawing.Size(247, 23);
            this.txtPasswords.TabIndex = 5;
            this.txtPasswords.UseSelectable = true;
            this.txtPasswords.UseSystemPasswordChar = true;
            this.txtPasswords.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPasswords.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPasswords.Click += new System.EventHandler(this.MetroTextBox15_Click);
            // 
            // lbPasswords
            // 
            this.lbPasswords.AutoSize = true;
            this.lbPasswords.Location = new System.Drawing.Point(400, 106);
            this.lbPasswords.Name = "lbPasswords";
            this.lbPasswords.Size = new System.Drawing.Size(71, 19);
            this.lbPasswords.TabIndex = 4;
            this.lbPasswords.Text = "Passwords:";
            this.lbPasswords.Click += new System.EventHandler(this.MetroLabel17_Click);
            // 
            // txtLoginName
            // 
            // 
            // 
            // 
            this.txtLoginName.CustomButton.Image = null;
            this.txtLoginName.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.txtLoginName.CustomButton.Name = "";
            this.txtLoginName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLoginName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLoginName.CustomButton.TabIndex = 1;
            this.txtLoginName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLoginName.CustomButton.UseSelectable = true;
            this.txtLoginName.CustomButton.Visible = false;
            this.txtLoginName.Lines = new string[0];
            this.txtLoginName.Location = new System.Drawing.Point(500, 73);
            this.txtLoginName.MaxLength = 32767;
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.PasswordChar = '\0';
            this.txtLoginName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoginName.SelectedText = "";
            this.txtLoginName.SelectionLength = 0;
            this.txtLoginName.SelectionStart = 0;
            this.txtLoginName.ShortcutsEnabled = true;
            this.txtLoginName.Size = new System.Drawing.Size(246, 23);
            this.txtLoginName.TabIndex = 5;
            this.txtLoginName.UseSelectable = true;
            this.txtLoginName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLoginName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLoginName.Click += new System.EventHandler(this.MetroTextBox14_Click);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(400, 78);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(81, 19);
            this.metroLabel16.TabIndex = 4;
            this.metroLabel16.Text = "Login name:";
            this.metroLabel16.Click += new System.EventHandler(this.MetroLabel16_Click);
            // 
            // txtSmtpPort
            // 
            // 
            // 
            // 
            this.txtSmtpPort.CustomButton.Image = null;
            this.txtSmtpPort.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.txtSmtpPort.CustomButton.Name = "";
            this.txtSmtpPort.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSmtpPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSmtpPort.CustomButton.TabIndex = 1;
            this.txtSmtpPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSmtpPort.CustomButton.UseSelectable = true;
            this.txtSmtpPort.CustomButton.Visible = false;
            this.txtSmtpPort.Lines = new string[0];
            this.txtSmtpPort.Location = new System.Drawing.Point(501, 44);
            this.txtSmtpPort.MaxLength = 32767;
            this.txtSmtpPort.Name = "txtSmtpPort";
            this.txtSmtpPort.PasswordChar = '\0';
            this.txtSmtpPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSmtpPort.SelectedText = "";
            this.txtSmtpPort.SelectionLength = 0;
            this.txtSmtpPort.SelectionStart = 0;
            this.txtSmtpPort.ShortcutsEnabled = true;
            this.txtSmtpPort.Size = new System.Drawing.Size(245, 23);
            this.txtSmtpPort.TabIndex = 5;
            this.txtSmtpPort.UseSelectable = true;
            this.txtSmtpPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSmtpPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSmtpPort.Click += new System.EventHandler(this.MetroTextBox13_Click);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(400, 49);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(76, 19);
            this.metroLabel15.TabIndex = 4;
            this.metroLabel15.Text = "SMTP port:";
            this.metroLabel15.Click += new System.EventHandler(this.MetroLabel15_Click);
            // 
            // txtSmtpAddress
            // 
            // 
            // 
            // 
            this.txtSmtpAddress.CustomButton.Image = null;
            this.txtSmtpAddress.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.txtSmtpAddress.CustomButton.Name = "";
            this.txtSmtpAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSmtpAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSmtpAddress.CustomButton.TabIndex = 1;
            this.txtSmtpAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSmtpAddress.CustomButton.UseSelectable = true;
            this.txtSmtpAddress.CustomButton.Visible = false;
            this.txtSmtpAddress.Lines = new string[0];
            this.txtSmtpAddress.Location = new System.Drawing.Point(501, 15);
            this.txtSmtpAddress.MaxLength = 32767;
            this.txtSmtpAddress.Name = "txtSmtpAddress";
            this.txtSmtpAddress.PasswordChar = '\0';
            this.txtSmtpAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSmtpAddress.SelectedText = "";
            this.txtSmtpAddress.SelectionLength = 0;
            this.txtSmtpAddress.SelectionStart = 0;
            this.txtSmtpAddress.ShortcutsEnabled = true;
            this.txtSmtpAddress.Size = new System.Drawing.Size(245, 23);
            this.txtSmtpAddress.TabIndex = 5;
            this.txtSmtpAddress.UseSelectable = true;
            this.txtSmtpAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSmtpAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSmtpAddress.Click += new System.EventHandler(this.MetroTextBox12_Click);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(400, 19);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(95, 19);
            this.metroLabel14.TabIndex = 4;
            this.metroLabel14.Text = "SMTP address:";
            this.metroLabel14.Click += new System.EventHandler(this.MetroLabel14_Click);
            // 
            // txtMsg
            // 
            // 
            // 
            // 
            this.txtMsg.CustomButton.Image = null;
            this.txtMsg.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txtMsg.CustomButton.Name = "";
            this.txtMsg.CustomButton.Size = new System.Drawing.Size(71, 71);
            this.txtMsg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMsg.CustomButton.TabIndex = 1;
            this.txtMsg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMsg.CustomButton.UseSelectable = true;
            this.txtMsg.CustomButton.Visible = false;
            this.txtMsg.Lines = new string[0];
            this.txtMsg.Location = new System.Drawing.Point(56, 132);
            this.txtMsg.MaxLength = 32767;
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.PasswordChar = '\0';
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMsg.SelectedText = "";
            this.txtMsg.SelectionLength = 0;
            this.txtMsg.SelectionStart = 0;
            this.txtMsg.ShortcutsEnabled = true;
            this.txtMsg.Size = new System.Drawing.Size(311, 73);
            this.txtMsg.TabIndex = 3;
            this.txtMsg.UseSelectable = true;
            this.txtMsg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMsg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(-4, 136);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(63, 19);
            this.metroLabel13.TabIndex = 2;
            this.metroLabel13.Text = "Message:";
            // 
            // txtSubject
            // 
            // 
            // 
            // 
            this.txtSubject.CustomButton.Image = null;
            this.txtSubject.CustomButton.Location = new System.Drawing.Point(289, 1);
            this.txtSubject.CustomButton.Name = "";
            this.txtSubject.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubject.CustomButton.TabIndex = 1;
            this.txtSubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubject.CustomButton.UseSelectable = true;
            this.txtSubject.CustomButton.Visible = false;
            this.txtSubject.Lines = new string[0];
            this.txtSubject.Location = new System.Drawing.Point(56, 103);
            this.txtSubject.MaxLength = 32767;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.PasswordChar = '\0';
            this.txtSubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubject.SelectedText = "";
            this.txtSubject.SelectionLength = 0;
            this.txtSubject.SelectionStart = 0;
            this.txtSubject.ShortcutsEnabled = true;
            this.txtSubject.Size = new System.Drawing.Size(311, 23);
            this.txtSubject.TabIndex = 3;
            this.txtSubject.UseSelectable = true;
            this.txtSubject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(-4, 107);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(54, 19);
            this.metroLabel12.TabIndex = 2;
            this.metroLabel12.Text = "Subject:";
            // 
            // txtCc
            // 
            // 
            // 
            // 
            this.txtCc.CustomButton.Image = null;
            this.txtCc.CustomButton.Location = new System.Drawing.Point(289, 1);
            this.txtCc.CustomButton.Name = "";
            this.txtCc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCc.CustomButton.TabIndex = 1;
            this.txtCc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCc.CustomButton.UseSelectable = true;
            this.txtCc.CustomButton.Visible = false;
            this.txtCc.Lines = new string[0];
            this.txtCc.Location = new System.Drawing.Point(57, 74);
            this.txtCc.MaxLength = 32767;
            this.txtCc.Name = "txtCc";
            this.txtCc.PasswordChar = '\0';
            this.txtCc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCc.SelectedText = "";
            this.txtCc.SelectionLength = 0;
            this.txtCc.SelectionStart = 0;
            this.txtCc.ShortcutsEnabled = true;
            this.txtCc.Size = new System.Drawing.Size(311, 23);
            this.txtCc.TabIndex = 3;
            this.txtCc.UseSelectable = true;
            this.txtCc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(-4, 78);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(27, 19);
            this.metroLabel11.TabIndex = 2;
            this.metroLabel11.Text = "Cc:";
            // 
            // txtFrom
            // 
            // 
            // 
            // 
            this.txtFrom.CustomButton.Image = null;
            this.txtFrom.CustomButton.Location = new System.Drawing.Point(289, 1);
            this.txtFrom.CustomButton.Name = "";
            this.txtFrom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFrom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFrom.CustomButton.TabIndex = 1;
            this.txtFrom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFrom.CustomButton.UseSelectable = true;
            this.txtFrom.CustomButton.Visible = false;
            this.txtFrom.Lines = new string[0];
            this.txtFrom.Location = new System.Drawing.Point(56, 45);
            this.txtFrom.MaxLength = 32767;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.PasswordChar = '\0';
            this.txtFrom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFrom.SelectedText = "";
            this.txtFrom.SelectionLength = 0;
            this.txtFrom.SelectionStart = 0;
            this.txtFrom.ShortcutsEnabled = true;
            this.txtFrom.Size = new System.Drawing.Size(311, 23);
            this.txtFrom.TabIndex = 3;
            this.txtFrom.UseSelectable = true;
            this.txtFrom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFrom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(-4, 49);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(44, 19);
            this.metroLabel10.TabIndex = 2;
            this.metroLabel10.Text = "From:";
            // 
            // txtTo
            // 
            // 
            // 
            // 
            this.txtTo.CustomButton.Image = null;
            this.txtTo.CustomButton.Location = new System.Drawing.Point(288, 1);
            this.txtTo.CustomButton.Name = "";
            this.txtTo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTo.CustomButton.TabIndex = 1;
            this.txtTo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTo.CustomButton.UseSelectable = true;
            this.txtTo.CustomButton.Visible = false;
            this.txtTo.Lines = new string[0];
            this.txtTo.Location = new System.Drawing.Point(57, 16);
            this.txtTo.MaxLength = 32767;
            this.txtTo.Name = "txtTo";
            this.txtTo.PasswordChar = '\0';
            this.txtTo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTo.SelectedText = "";
            this.txtTo.SelectionLength = 0;
            this.txtTo.SelectionStart = 0;
            this.txtTo.ShortcutsEnabled = true;
            this.txtTo.Size = new System.Drawing.Size(310, 23);
            this.txtTo.TabIndex = 3;
            this.txtTo.UseSelectable = true;
            this.txtTo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(-4, 20);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(25, 19);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "To:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lbMsg);
            this.metroPanel1.Controls.Add(this.metroLink1);
            this.metroPanel1.Controls.Add(this.metroTile3);
            this.metroPanel1.Controls.Add(this.metroTile2);
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 319);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(754, 108);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.ForeColor = System.Drawing.Color.Red;
            this.lbMsg.Location = new System.Drawing.Point(4, 11);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(0, 0);
            this.lbMsg.TabIndex = 6;
            this.lbMsg.UseCustomForeColor = true;
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(4, 82);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(351, 23);
            this.metroLink1.TabIndex = 5;
            this.metroLink1.Text = "https://github.com/Chunlong101/SlowPerformanceMonitor";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.MetroLink1_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(633, 11);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(120, 94);
            this.metroTile3.TabIndex = 4;
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.MetroTile3_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(507, 11);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(120, 94);
            this.metroTile2.TabIndex = 3;
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.MetroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(378, 11);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(123, 94);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.MetroTile1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Slow Performance Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroComboBox choiceBroswer;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtDaysToMonitor;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtUrl;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroToggle toggleIsSignInRequired;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtManualSignInTime;
        private MetroFramework.Controls.MetroTextBox txtSlowPerformanceReoccurrenceThreshold;
        private MetroFramework.Controls.MetroTextBox txtPageLoadThreshold;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtSleepTime;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox txtSubject;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtCc;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtFrom;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtTo;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtPasswords;
        private MetroFramework.Controls.MetroLabel lbPasswords;
        private MetroFramework.Controls.MetroTextBox txtLoginName;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox txtSmtpPort;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox txtSmtpAddress;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txtMsg;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel lbMsg;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}

