using System.Net.Mail;

namespace SmtpPerformanceTest
{
    public class MailAuthDelivery : MailSafer.Delivery.IMailDelivery
    {
        private readonly string _host;
        private readonly int _port;
        private readonly string _user;
        private readonly string _pass;

        public MailAuthDelivery(string host, int port, string user, string pass)
        {
            _host = host;
            _port = port;
            _user = user;
            _pass = pass;
        }

        public void Send(MailMessage mailMessage)
        {
            using (var smtp = CreateSmtpClient())
            {
                smtp.Send(mailMessage);
            }
        }


        private SmtpClient CreateSmtpClient()
        {
            if (!string.IsNullOrEmpty(_host) && _port != 0)
            {
                var client = new SmtpClient(_host, _port);
                client.Credentials = new System.Net.NetworkCredential(_user, _pass);

                return client;
            }

            if (!string.IsNullOrEmpty(_host))
            {
                var client = new SmtpClient(_host);
                client.Credentials = new System.Net.NetworkCredential(_user, _pass);

                return client;
            }

            return new SmtpClient();
        }
    }
}