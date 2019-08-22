using MetroFramework.Forms;
using System;
using System.Diagnostics;
using Core;
using System.Configuration;

namespace SlowPerformanceMonitor
{
    public partial class Form1 : MetroForm
    {
        private NLog.Logger log = Core.Logging.Logger.GetLogger(typeof(Form1));
        private Properties.Settings settings = Properties.Settings.Default;
        private Core.Properties.Settings coreSettings = Core.Properties.Settings.Default;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //
                // Loading config from %appdata%
                //
                txtUrl.Text = settings.Url;
                choiceBroswer.SelectedIndex = settings.BroswerType - 1;
                txtDaysToMonitor.Text = settings.MonitorDays.ToString();

                txtSleepTime.Text = settings.TimeSpanToSleepInSeconds.ToString();
                txtPageLoadThreshold.Text = settings.SlowPerformancePageLoadThreshold.ToString();
                txtSlowPerformanceReoccurrenceThreshold.Text = settings.SlowPerformanceReoccurrenceThreshold.ToString();
                toggleIsSignInRequired.Checked = settings.IsSignInRequired;
                txtManualSignInTime.Text = settings.ManuallySignInTimeInSeconds.ToString();

                txtTo.Text = settings.EmailToEmailAddress;
                txtFrom.Text = settings.EmailFromEmailAddress;
                txtCc.Text = settings.EmailCcEmailAddress;
                txtSubject.Text = settings.EmailSubject;
                txtMsg.Text = settings.EmailBody;
                txtSmtpAddress.Text = settings.EmailSmtpAddress;
                txtSmtpPort.Text = settings.EmailSmtpPort.ToString();
                txtLoginName.Text = settings.EmailSenderLoginName;
                txtPasswords.Text = settings.EmailSenderLoginPasswords;
            }
            catch (Exception ex)
            {
                log.Error(ex, "Something went wrong, pls check the config file");
                lbMsg.Text = "Something went wrong, pls check the config file";
            }
        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                //
                // Updating SlowPerformanceMonitor settings
                //
                settings.Url = txtUrl.Text;
                settings.BroswerType = choiceBroswer.SelectedIndex + 1;
                settings.MonitorDays = Convert.ToInt32(txtDaysToMonitor.Text);

                settings.TimeSpanToSleepInSeconds = Convert.ToInt32(txtSleepTime.Text);
                settings.SlowPerformancePageLoadThreshold = Convert.ToInt32(txtPageLoadThreshold.Text);
                settings.SlowPerformanceReoccurrenceThreshold = Convert.ToInt32(txtSlowPerformanceReoccurrenceThreshold.Text);
                settings.IsSignInRequired = toggleIsSignInRequired.Checked;
                settings.ManuallySignInTimeInSeconds = Convert.ToInt32(txtManualSignInTime.Text);

                settings.EmailToEmailAddress = txtTo.Text;
                settings.EmailFromEmailAddress = txtFrom.Text;
                settings.EmailCcEmailAddress = txtCc.Text;
                settings.EmailSubject = txtSubject.Text;
                settings.EmailBody = txtMsg.Text;
                settings.EmailSmtpAddress = txtSmtpAddress.Text;
                settings.EmailSmtpPort = Convert.ToInt32(txtSmtpPort.Text);
                settings.EmailSenderLoginName = txtLoginName.Text;
                settings.EmailSenderLoginPasswords = txtPasswords.Text;

                settings.Save();
                log.Info("SlowPerformanceMonitor settings have been saved to %appdata%");

                //
                // Updating Kevin App.config
                //
                var config = ConfigurationManager.OpenExeConfiguration(@"Kevin.exe");

                config.AppSettings.Settings["Url"].Value = txtUrl.Text;
                config.AppSettings.Settings["BroswerType"].Value = (choiceBroswer.SelectedIndex + 1).ToString();
                config.AppSettings.Settings["MonitorDays"].Value = txtDaysToMonitor.Text;
                config.AppSettings.Settings["TimeSpanToSleepInSeconds"].Value = txtSleepTime.Text;
                config.AppSettings.Settings["SlowPerformancePageLoadThreshold"].Value = txtPageLoadThreshold.Text;
                config.AppSettings.Settings["SlowPerformanceReoccurrenceThreshold"].Value = txtSlowPerformanceReoccurrenceThreshold.Text;
                config.AppSettings.Settings["IsSignInRequired"].Value = toggleIsSignInRequired.Checked.ToString();
                config.AppSettings.Settings["ManuallySignInTimeInSeconds"].Value = txtManualSignInTime.Text;

                config.AppSettings.Settings["EmailFromEmailAddress"].Value = txtFrom.Text;
                config.AppSettings.Settings["EmailToEmailAddress"].Value = txtTo.Text;
                config.AppSettings.Settings["EmailCcEmailAddress"].Value = txtCc.Text;
                config.AppSettings.Settings["EmailSubject"].Value = txtSubject.Text;
                config.AppSettings.Settings["EmailBody"].Value = txtMsg.Text;
                config.AppSettings.Settings["EmailSmtpAddress"].Value = txtSmtpAddress.Text;
                config.AppSettings.Settings["EmailSmtpPort"].Value = txtSmtpPort.Text;
                config.AppSettings.Settings["EmailSenderLoginName"].Value = txtLoginName.Text;
                config.AppSettings.Settings["EmailSenderLoginPasswords"].Value = txtPasswords.Text;

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                log.Info("Kevin app.config has been updated");

                Process.Start("Kevin.exe");
                this.Close();
            }
            catch (Exception ex)
            {
                log.Error(ex, "Something went wrong, pls check the config file");
                lbMsg.Text = "Something went wrong, pls check the config file";
            }
        }

        private void MetroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void MetroTextBox15_Click(object sender, EventArgs e)
        {

        }

        private void MetroTextBox12_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel16_Click(object sender, EventArgs e)
        {

        }

        private void MetroTextBox14_Click(object sender, EventArgs e)
        {

        }

        private void MetroTextBox13_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel15_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel17_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel14_Click(object sender, EventArgs e)
        {

        }

        private void MetroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@".\Logs");
            }
            catch (Exception ex)
            {
                log.Error(ex, "Something went wrong, pls check the config file");
                lbMsg.Text = "Something went wrong, pls check the config file";
            }
        }

        private void MetroTile3_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@".\Logs");
            }
            catch (Exception ex)
            {
                log.Error(ex, "Something went wrong, pls check the config file");
                lbMsg.Text = "Something went wrong, pls check the config file";
            }
        }

        private void MetroLink1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"https://github.com/Chunlong101/SlowPerformanceMonitor");
            }
            catch (Exception ex)
            {
                log.Error(ex, "Something went wrong, pls check the config file");
                lbMsg.Text = "Something went wrong, pls check the config file";
            }
        }
    }
}
