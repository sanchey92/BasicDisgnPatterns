using DotnetDesignPatterns.Creational.Builder.BuilderParameter;

namespace DotnetDesignPatterns.Creational.Builder
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var emailService = new EmailService();
            emailService.SendEmail(builder =>
                builder.From("test string")
                    .To("test 2")
                    .Body("test 3"));
        }
    }
}