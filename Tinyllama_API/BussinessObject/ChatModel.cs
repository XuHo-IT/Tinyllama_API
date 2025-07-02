namespace Tinyllama_API.BussinessObject
{
    public class ChatModel
    {
        public string Model { get; set; } = "tinyllama:latest";
        public List<Message> Messages { get; set; } = new();
    }
}
