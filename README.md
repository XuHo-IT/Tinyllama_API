🦙 TinyLLaMA_API – Lightweight Ollama Chat API
This project is a minimal chat API powered by the tinyllama:latest model from Ollama. 
It is optimized for low resource usage and performs efficiently with less CPU and memory consumption compared to other larger models.

✨ Features
Lightweight and fast with tinyllama:latest
Simple chat endpoint
Supports system prompts for behavior customization
Easy to integrate into any frontend or desktop app


▶️ Getting Started
First, make sure the model is pulled and served:
```bash
ollama run tinyllama / ollama pull tinyllama
```
Once started, Ollama serves a local HTTP API at
```bash
http://localhost:11434.
```

🛠️ Customization
You can personalize the assistant’s behavior by modifying the system prompt by yourself.
