using AI.Portfolio.Assistant.Api.Models;

namespace AI.Portfolio.Assistant.Api.AI;

/// <summary>
/// Orchestrates a single chat turn: decide which MCP context is needed, gather it, build
/// the final prompt, call Grok, and return the answer with its sources.
/// </summary>
public interface IChatService
{
    Task<ChatResponse> AskAsync(ChatRequest request, CancellationToken cancellationToken = default);
}
