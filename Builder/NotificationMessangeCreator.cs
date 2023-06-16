namespace Patterns.Builder
{
    public class NotificationMessageCreator
    {
        private NotificationMessageBuilder messageBuilder;

        public NotificationMessageCreator(NotificationMessageBuilder messageBuilder)
        {
            this.messageBuilder = messageBuilder;
        }
        public NotificationMessage CreateMessage()
        {
            messageBuilder.DefineSubject();
            messageBuilder.DefineBody();
            messageBuilder.DefineFooter();
            return messageBuilder.GetMessage();
        }
    }
}