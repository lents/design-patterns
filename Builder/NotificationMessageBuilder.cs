namespace Patterns.Builder
{
    public abstract class NotificationMessageBuilder
    {
        protected NotificationMessage Message { get; private set; }
        public NotificationMessageBuilder()
        {
            Message = new NotificationMessage();
        }
        public abstract void DefineSubject();
        public abstract void DefineBody();
        public abstract void DefineFooter();
        public NotificationMessage GetMessage()
        {
            return Message;
        }
    }
}