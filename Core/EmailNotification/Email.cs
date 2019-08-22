using Core.Properties;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Linq;

namespace Core.EmailNotification
{
    /// <summary>
    /// Provide email notification functions, such as send an email. 
    /// </summary>
    public class Email
    {
        private static NLog.Logger log = Core.Logging.Logger.GetLogger(typeof(Email));

        /// <summary>
        /// Send an email using  parameters from config file.  
        /// </summary>
        /// <returns>How many recipients/audiences should receive the email, -1 means failed to send the email.</returns>
        public static int SendEmail()
        {
            int fb = -1;

            try
            {
                log.Info("Reading email parameters from config file");

                var emailFromName = Settings.Default.EmailFromName;
                var emailFromEmailAddress = Settings.Default.EmailFromEmailAddress;
                var emailToName = Settings.Default.EmailToName;
                var emailToEmailAddress = Settings.Default.EmailToEmailAddress;
                var emailCcName = Settings.Default.EmailCcName;
                var emailCcEmailAddress = Settings.Default.EmailCcEmailAddress;
                var emailSubject = Settings.Default.EmailSubject;
                var emailBody = Settings.Default.EmailBody;
                var emailSmtpAddress = Settings.Default.EmailSmtpAddress;
                var emailSmtpPort = Settings.Default.EmailSmtpPort;
                var emailSenderLoginName = Settings.Default.EmailSenderLoginName;
                var emailSenderLoginPasswords = Settings.Default.EmailSenderLoginPasswords;
                var emailISenderLoginPasswordsEncrypted = Settings.Default.EmailIsSenderLoginPasswordsEncrypted;

                fb = SendEmail(emailFromName, emailFromEmailAddress, emailToName, emailToEmailAddress, emailCcName, emailCcEmailAddress, emailSubject, emailBody, emailSmtpAddress, emailSmtpPort, emailSenderLoginName, emailSenderLoginPasswords, emailISenderLoginPasswordsEncrypted);

                return fb;
            }
            catch (Exception ex)
            {
                log.Warn(ex, "Email cannot be sent, pls check the log file");
                return -1;
            }
        }

        /// <summary>
        /// Send an email using parameters such as from, to, subject, etc. 
        /// </summary>
        /// <returns>How many recipients/audiences should receive the email, -1 means failed to send the email.</returns>
        public static int SendEmail(string emailFromName, string emailFromEmailAddress, string emailToName, string emailToEmailAddress, string emailCcName,
            string emailCcEmailAddress, string emailSubject, string emailBody, string emailSmtpAddress, int emailSmtpPort, string emailSenderLoginName, string emailSenderLoginPasswords, bool emailISenderLoginPasswordsEncrypted)
        {
            int fb = -1;

            try
            {
                log.Info("Email parameters has been filled, '{0}':'{1}' will send an email to '{2}':'{3}', CC '{4}':'{5}', subject is '{6}', body is '{7}', smtp address is '{8}', smtp port is '{9}', login name is '{10}', is password encrypted '{11}'",
                    emailFromName, emailFromEmailAddress, emailToName, emailToEmailAddress, emailCcName, emailCcEmailAddress, emailSubject, emailBody, emailSmtpAddress, emailSmtpPort, emailSenderLoginName, emailISenderLoginPasswordsEncrypted);

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(emailFromName, emailFromEmailAddress));

                var targetAudienceTo = emailToEmailAddress.Split(';');

                foreach (var i in targetAudienceTo)
                {
                    message.To.Add(new MailboxAddress(i));
                }

                var targetAudienceCc = emailCcEmailAddress.Split(';');

                foreach (var i in targetAudienceCc)
                {
                    message.Cc.Add(new MailboxAddress(i));
                }

                fb = targetAudienceTo.Count() + targetAudienceCc.Count();

                message.Subject = emailSubject;

                message.Body = new TextPart("plain")
                {
                    Text = emailBody
                };

                using (var client = new SmtpClient())
                {
                    client.Connect(emailSmtpAddress, emailSmtpPort);

                    client.Authenticate(emailSenderLoginName, emailSenderLoginPasswords);

                    client.Send(message);

                    client.Disconnect(true);

                    log.Info("Email has been sent, '{0}' recipients will be getting it", fb);

                    return fb;
                }
            }
            catch (Exception ex)
            {
                log.Warn(ex, "Email cannot be sent, pls check the log file");
                return -1;
            }
        }
    }
}
