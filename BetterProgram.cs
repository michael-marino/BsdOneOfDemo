// static ITransactionResult RunTransaction()
// {
//     // Some business logic to process a transaction
//     var transactionResult = new TransactionSuccess(12345);
//     // transactionResult = new TransactionLimitExceeded();
//     // transactionResult = new TransactionError("Insufficient funds.");
//     // transactionResult = new TransactionDuplicate();

//     return transactionResult;
// }

// static void HandleTransactionResult(ITransactionResult result)
// {
//     if (result is TransactionSuccess success)
//     {
//         Console.WriteLine($"Transaction completed successfully with ID: {success.TransactionId}");
//     }
//     else if (result is TransactionLimitExceeded)
//     {
//         Console.WriteLine("Transaction limit exceeded.");
//     }
//     else if (result is TransactionError error)
//     {
//         Console.WriteLine($"Transaction failed: {error.ErrorMessage}");
//     }
// }

// var result = RunTransaction();

// HandleTransactionResult(result);