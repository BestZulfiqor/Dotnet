using Domain.Enum;

namespace Domain.Entity;

public class Message
{
    public string Author { get; set; }
    public string Text { get; set; }
    public MessageType Type { get; set; }
    public DateTime Time { get; set; }
    public Message(string Author, string Text, MessageType Type)
    {
        this.Author = Author;
        this.Text = Text;
        this.Type = Type;
    }
    public override string ToString(){
        return $"Author: {Author}, Text: {Text}, MessageType: {Type}, Time: {Time}";
    }
}
