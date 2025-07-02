using Tinyllama_API.BussinessObject;

namespace Tinyllama_API.DTOs
{
    public class ChatRequest
    {
        public string Message { get; set; }
        public List<Message>? PreviousMessages { get; set; }
    }
}
