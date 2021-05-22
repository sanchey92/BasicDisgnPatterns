using System;

namespace DotnetDesignPatterns.Creational.Builder.BuilderParameter
{
    public class EmailService
    {
        private void SendEmailInternal(Email email)
        {
            //
        }
            
        public void SendEmail(Action<EmailBuilder> builder)
        {
            var email = new Email();
            builder(new EmailBuilder(email));
            SendEmailInternal(email);
        }
    }
}