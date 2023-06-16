namespace Patterns.Builder
{
    public class GreetingBuilder : NotificationMessageBuilder
    {
        public override void DefineSubject()
        {
            Message.Subject = "Welcome to our shop";
        }
        public override void DefineBody()
        {
            Message.Body = "We are glad to see you in our shop!";
        }
        public override void DefineFooter()
        {
            Message.Footer = "Your favorite shop";
        }        
    }
}