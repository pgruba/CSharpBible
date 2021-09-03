using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP.BuilderWithParameter
{
    /*
     * Solution to force users to use builder in specific way
     * We don't want to expose 'SendEmialInternal' method to the users, we use it internaly
     */

    public class MailService
    {
        public string SendEmail(Action<EmailBuilder> builder)
        {
            var email = new Email();
            builder(new EmailBuilder(email));
            return SendEmailInternal(email);
        }

        private string SendEmailInternal(Email email)
            => $"Email sent to {email.To}";
    }

    // Internal types or members are accessible only within files in the same assembly
    public class Email
    {
        public string From;
        public string To;
        public string Subject;
        public string Body;
    }

    /// <summary>
    /// Email builder class
    /// </summary>
    public class EmailBuilder
    {
        private Email email;

        public EmailBuilder(Email email) => this.email = email;

        public EmailBuilder From(string from)
        {
            email.From = from;
            return this;
        }

        public EmailBuilder To(string to)
        {
            email.To = to;
            return this;
        }

        public EmailBuilder Body(string body)
        {
            email.Body = body;
            return this;
        }
    }
}