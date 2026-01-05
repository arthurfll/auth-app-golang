using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace azure_function_app;

public class HelloWorldFunction
{
    private readonly ILogger<HelloWorldFunction> _logger;

    public HelloWorldFunction(ILogger<HelloWorldFunction> logger)
    {
        _logger = logger;
    }

    [Function("HelloWorldFunction")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}
