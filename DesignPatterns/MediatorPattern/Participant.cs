namespace MediatorPattern;

public class Participant
{
    public string Id { get; set; }
    public string Name { get; set; }

    public IChatRoom ChatRoom { get; set; }

    public Participant(string id, string name, IChatRoom chatRoom)
    {
        Id = id;
        Name = name;
        ChatRoom = chatRoom;
    }

    public void Send(string message)
    {
        ChatRoom.SendMessage(message, Id);
    }

    public virtual void Receive(string message, string sender)
    {
        
    }
}
