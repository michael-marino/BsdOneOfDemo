public class TransactionResult
{
    public bool Success { get; set; }
    public long? TransactionId { get; set; }
    public string? Message { get; set; }
    public ErrorCode? ErrorType { get; set; }
}

public enum ErrorCode
{
    GeneralError,
    ServiceUnavailable,
    LimitExceeded,
    DuplicateTransaction,
}