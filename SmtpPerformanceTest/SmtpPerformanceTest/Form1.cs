using System;
using System.Diagnostics;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using MailSafer;
using MailSafer.Logger;
using MailSafer.Storage;

namespace SmtpPerformanceTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            const string DIRECTORYNAME = "TempMails";
            string logFile = String.Format("log-{0}.txt", DateTime.Now.ToString());

            LogText.Clear();

            string host = ServerText.Text;
            int port = Convert.ToInt32(PortNumeric.Value);
            string user = UsernameText.Text;
            string pw = PasswordText.Text;

            string from = Sender.Text;
            string to = Receipient.Text;
            string subject = "TestMessage " + DateTime.Now;

            Stopwatch watch = new Stopwatch();
            var delivery = new MailAuthDelivery(host, port, user, pw);

            string directory = Helper.AssemblyDirectory + "\\" + DIRECTORYNAME;
            Directory.CreateDirectory(directory);
            FileSystemMailStorage storage = new FileSystemMailStorage(directory);
            Log4NetMailLogger logger = new Log4NetMailLogger();

            MailClient client = new MailClient(delivery, storage, logger);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(from);
            mail.To.Add(new MailAddress(to));
            mail.Subject = subject;
            mail.Body = Helper.RandomString(Convert.ToInt32(MessageSize.Value));

            StringBuilder logStringBUilder = new StringBuilder();
            string header = "Date,Number,Duration";
            logStringBUilder.AppendLine(header);

            for (int i = 1; i <= NumberOfMessages.Value; i++)
            {
                mail.Subject += " " + i;
                watch.Start();
                client.Send(mail);
                watch.Stop();
                Debug.WriteLine(watch.ElapsedMilliseconds);

                string logText = String.Format("{0},{1},{2}", DateTime.Now, i, watch.ElapsedMilliseconds);
                logStringBUilder.AppendLine(logText);
                LogText.Text += (logText + Environment.NewLine).Replace(",", "     ");

                Application.DoEvents(); // AYE

                watch.Reset();
            }

            if (LogFile.Checked)
            {
                File.AppendAllText(Helper.AssemblyDirectory + "\\" + logFile, logStringBUilder.ToString());
            }
        }
    }
}
