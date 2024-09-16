namespace MediatorPattern;

public class ChatRoom : IChatRoom
{
    Dictionary<string, Participant> participants = [];

    public void AddParticipant(Participant participant)
    {
        if (!participants.ContainsKey(participant.Id))
            participants.Add(participant.Id, participant);

        participant.ChatRoom = this;
    }

    public void SendMessage(string message, string senderId)
    {
        foreach (Participant participant in participants.Values)
        {
            if (participant.Id != senderId)
                participant.Receive(message, participants[senderId].Name);
        }
    }
}
