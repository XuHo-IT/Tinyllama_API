using Microsoft.AspNetCore.Mvc;
using Tinyllama_API.BussinessObject;
using Tinyllama_API.DTOs;
using Tinyllama_API.Service;

namespace Tinyllama_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly OllamaChatService _chatService;

        public ChatController()
        {
            _chatService = new OllamaChatService();
        }

        [HttpPost("ask")]
        public async Task<IActionResult> Ask([FromBody] ChatRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Message))
                return BadRequest("Message is required.");

            var model = new ChatModel
            {
                Model = "tinyllama:latest",
                Messages = request.PreviousMessages ?? new List<Message>()
            };

            if (!model.Messages.Any())
            {
                model.Messages.Add(new Message
                {
                    Role = "system",
                    Content = @"You are XUho, an expert AI assistant in pawnshop operations. 
You answer clearly and concisely with real-world examples, bullet points, and guidance.
Use a friendly tone and always encourage users to ask follow-ups."
                });
            }

            string response = await _chatService.ChatAsync(model, request.Message);

            return Ok(new ChatResponse
            {
                Response = response,
                Conversation = model.Messages
            });
        }

    }
}
