using Tinyllama_API.BussinessObject;
using Tinyllama_API.Reponse;

namespace Tinyllama_API.Service
{
    public class OllamaApiClient : IDisposable
    {
        private readonly HttpClient _client;

        public OllamaApiClient()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:11434")
            };
        }

        public async Task<OllamaResponse> GenerateChatAsync(ChatModel model)
        {
            var payload = new
            {
                model = model.Model,
                messages = model.Messages.Select(m => new { role = m.Role, content = m.Content }),
                stream = false
            };

            var response = await _client.PostAsJsonAsync("/api/chat", payload);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<OllamaResponse>();
        }

        public void Dispose() => _client.Dispose();
    }
}
