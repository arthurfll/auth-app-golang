using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace azure_function_app;

public class PostNoteFunction
{
    private readonly ILogger<PostNoteFunction> _logger;

    public PostNoteFunction(ILogger<PostNoteFunction> logger)
    {
        _logger = logger;
    }

    [Function("PostNoteFunction")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}


