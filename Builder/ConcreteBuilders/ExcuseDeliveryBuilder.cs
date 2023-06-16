namespace Patterns.Builder
{
    public class ExcuseDeliveryBuilder : NotificationMessageBuilder
    {
        public override void DefineSubject()
        {
            Message.Subject = "Your order is delayed!";
        }
        public override void DefineBody()
        {
            Message.Body = "We are very sorry to inform, that your order can't be delivered in time.";
        }
        public override void DefineFooter()
        {
            Message.Footer = "Contact us by phone. Your favorite shop";
        }        
    }
}