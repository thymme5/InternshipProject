using System.Net.Mail;
using VerklaringVanOntvangst.Properties;
namespace VerklaringVanOntvangst
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
        try
        {
            if (txtboxName.Text == null || txtboxBody.Text == null || txtboxSubject.Text == null || radioBtnSuggestion == null) 
            {
                MessageBox.Show("Gelieve alle velden in te vullen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MailAddress from = new MailAddress("feedbackinfano@outlook.com", txtboxName.Text);
                MailAddress to = new MailAddress("Thymme5@outlook.com", "Thymme");
                List<MailAddress> cc = new List<MailAddress>();
                cc.Add(new MailAddress("feedbackinfano@outlook.com", txtboxName.Text));
                SendEmail(txtboxSubject.Text, from, to, cc);

                DialogResult d = MessageBox.Show("Bedankt voor uw feedback!", "Feedback Verzonden", MessageBoxButtons.OK);

                if (d == DialogResult.OK)
                {
                    Close();
                }
            }
        }
        catch
        {
            MessageBox.Show("Oeps! er ging iets mis.", "Error", MessageBoxButtons.OK);
        }
        }
        protected void SendEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc, List<MailAddress> _bcc = null!)
        {
            string radioBtnResult = "";

            bool isChecked = radioBtnSuggestion.Checked;
            if (isChecked)  
                radioBtnResult = radioBtnSuggestion.Text.ToString();
            else
                radioBtnResult = radiobtnProblem.Text.ToString();

            string Text = "";
            SmtpClient mailClient = new SmtpClient("smtp.office365.com");
            MailMessage msgMail;
            mailClient.Credentials = new System.Net.NetworkCredential("feedbackinfano@outlook.com", "infanoFeedback123"); //credentials are purely for respresenational purpose - I couldn't be bothered to encrypt it. 
            mailClient.TargetName = "STARTTLS/smtp.office365.com";
            mailClient.Port = 587;
            mailClient.EnableSsl = true;
            Text =  radioBtnResult + "<br>" + txtboxBody.Text;
            msgMail = new MailMessage();
            msgMail.From = _from;
            msgMail.To.Add(_to);
            foreach (MailAddress addr in _cc)
            {
                msgMail.CC.Add(addr);
            }
            if (_bcc != null)
            {
                foreach (MailAddress addr in _bcc)
                {
                    msgMail.Bcc.Add(addr);
                }
            }
            msgMail.Subject = txtboxName.Text + ": " + _subject;
            msgMail.Body = Text;
            msgMail.IsBodyHtml = true;
            mailClient.Send(msgMail);
            msgMail.Dispose();
        }
    }
}
