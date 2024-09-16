namespace MediatorPattern;

public interface IChatRoom
{
    public void AddParticipant(Participant participant);

    public void SendMessage(string message, string senderId);
}
