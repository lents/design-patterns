namespace Patterns.Builder
{
    public class SuccessDeliveryBuilder : NotificationMessageBuilder
    {
        public override void DefineSubject()
        {
            Message.Subject = "Your order is successfully delivered!";
        }
        public override void DefineBody()
        {
            Message.Body = "Your order is successfully delivered. Please rate the products in link";
        }
        public override void DefineFooter()
        {
            Message.Footer = "Your favorite shop";
        }        
    }
}