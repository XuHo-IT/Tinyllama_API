using Tinyllama_API.BussinessObject;

namespace Tinyllama_API.DTOs
{
    public class ChatResponse
    {
        public string Response { get; set; }
        public List<Message> Conversation { get; set; }
    }
}
