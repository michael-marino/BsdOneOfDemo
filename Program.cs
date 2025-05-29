static TransactionResult RunTransaction()
{
    // Some business logic to process a transaction
    var transactionResult = new TransactionResult
    {
        Success = true,
        TransactionId = 12345,
        Message = "Transaction completed successfully.",
        ErrorType = null
    };

    // Simulate a condition where the transaction fails
    // var transactionResult = new TransactionResult
    // {
    //     Success = false,
    //     Message = "Insufficient funds.",
    //     ErrorType = ErrorCode.GeneralError
    // };

    return transactionResult;
}

static void HandleTransactionResult(TransactionResult result)
{
    if (result.Success)
    {
        Console.WriteLine($"Transaction completed successfully with ID: {result.TransactionId}");
    }
    else
    {
        Console.WriteLine($"Transaction failed: {result.Message}");
        if (result.ErrorType.HasValue)
        {
            Console.WriteLine($"Error Type: {result.ErrorType}");
        }
    }
}

var result = RunTransaction();

HandleTransactionResult(result);