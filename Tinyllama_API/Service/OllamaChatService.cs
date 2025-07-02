using Tinyllama_API.BussinessObject;

namespace Tinyllama_API.Service
{
    public class OllamaChatService
    {
        public async Task<string> ChatAsync(ChatModel model, string userMessage)
        {
            using var ollama = new OllamaApiClient();

            model.Messages.Add(new Message { Role = "user", Content = userMessage });

            var result = await ollama.GenerateChatAsync(model);

            model.Messages.Add(new Message { Role = "assistant", Content = result.Message.Content });

            return result.Message.Content;
        }
    }
}
