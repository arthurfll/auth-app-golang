using Azure;
using Azure.Data.Tables;

namespace azure_function_app;

public record Note : ITableEntity
{
  public required string RowKey { get; set; }
  public required string PartitionKey { get; set; }
  public required string Name { get; set; }
  public ETag ETag { get; set; } = ETag.All;
  public DateTimeOffset? Timestamp { get; set; }
}



