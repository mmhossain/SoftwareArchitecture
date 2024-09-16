using Moq;
using Xunit;

namespace MediatorPattern.Tests;

public class ChatRoomTests
{
    [Fact]
    public void SendMessageTest()
    {
        // Arrange
        IChatRoom chatRoom = new ChatRoom();

        var mockParticipant1 = new Mock<Participant>("1", "Alice", chatRoom);
        var mockParticipant2 = new Mock<Participant>("2", "Bob", chatRoom);
        var mockParticipant3 = new Mock<Participant>("3", "David", chatRoom);

        chatRoom.AddParticipant(mockParticipant1.Object);
        chatRoom.AddParticipant(mockParticipant2.Object);
        chatRoom.AddParticipant(mockParticipant3.Object);

        // Act
        chatRoom.SendMessage("Hi Bob!", "1");
        chatRoom.SendMessage("Hi David!", "1");

        // Assert
        mockParticipant1.Verify(p => p.Receive(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
        mockParticipant2.Verify(p => p.Receive("Hi Bob!", "Alice"), Times.Once);
        mockParticipant3.Verify(p => p.Receive("Hi David!", "Alice"), Times.Once);
    }
}