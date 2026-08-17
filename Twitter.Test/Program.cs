using TwitterClone.Domain.Entities;


//var notification = new Notification("Like");

//var message = notification.GetMessage();

//Console.WriteLine(message);


//var notification = new LikeNotification(Guid.NewGuid());

//var message = notification.GetMessage();

//Console.WriteLine(message);


//var notification = new FreiendRequestNotification(Guid.NewGuid());

//var message = notification.GetMessage();

//Console.WriteLine(message);



//var notification = new CommentNotification(Guid.NewGuid());

//var message = notification.GetMessage();

//Console.WriteLine(message);


//var notification = new MentionNotification(Guid.NewGuid());

//var message = notification.GetMessage();

//Console.WriteLine(message);

var notification = new List<Notification>
{
    new LikeNotification(Guid.NewGuid()),
    new CommentNotification(Guid.NewGuid()),

    new FreiendRequestNotification(Guid.NewGuid()),
    new MentionNotification(Guid.NewGuid()),
    new SystemNotification("Thsi is system message")
};


foreach(var message  in notification)
{
    Console.WriteLine(message.GetMessage());
}