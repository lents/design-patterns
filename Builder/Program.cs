
using Patterns.Builder;

var message = SendSuccessMessage();
Console.WriteLine(message.Subject);
message = SendExcuseMessage();

Console.WriteLine(message.Subject);
message = SendGreetingMessage();

Console.WriteLine(message.Subject);

NotificationMessage SendSuccessMessage()
{
    var messanger = new NotificationMessageCreator(new SuccessDeliveryBuilder());
    return messanger.CreateMessage();
}

NotificationMessage SendExcuseMessage()
{
    var messanger = new NotificationMessageCreator(new ExcuseDeliveryBuilder());
    return messanger.CreateMessage();
}

NotificationMessage SendGreetingMessage()
{
    var messanger = new NotificationMessageCreator(new GreetingBuilder());
    return messanger.CreateMessage();
}