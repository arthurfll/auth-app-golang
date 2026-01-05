using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Azure.Identity;
using Azure.Data.Tables;

namespace azure_function_app;

public class GetAllNotesFunction
{
    private readonly ILogger<GetAllNotesFunction> _logger;

    public GetAllNotesFunction(ILogger<GetAllNotesFunction> logger)
    {
        _logger = logger;
    }

    [Function("GetAllNotesFunction")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
    {

        var credential = new ManagedIdentityCredential(
            clientId: Environment.GetEnvironmentVariable("AZURE_CLIENT_ID")
        );
        
        TableServiceClient serviceClient = new(
            endpoint: new Uri("https://arthurfll8059.table.core.windows.net/"),
            credential
        );

        TableClient client = serviceClient.GetTableClient(
            tableName: "notes"
        );

        var entities = client.Query<TableEntity>().ToList();



        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult(entities);
    }
}

