// using OneOf;

// static OneOf<TransactionSuccess, TransactionLimitExceeded, TransactionDuplicate, TransactionError> RunTransaction()
// {
//     // Some business logic to process a transaction
//     var transactionResult = new TransactionSuccess(12345);
//     // transactionResult = new TransactionLimitExceeded();
//     // transactionResult = new TransactionError("Insufficient funds.");
//     // transactionResult = new TransactionDuplicate();

//     return transactionResult;
// }

// static void HandleTransactionSuccess(TransactionSuccess result)
// {
//     Console.WriteLine($"Transaction completed successfully with ID: {result.TransactionId}");
// }
// static void HandleTransactionLimitExceeded(TransactionLimitExceeded result)
// {
//     Console.WriteLine("Transaction limit exceeded.");
// }
// static void HandleTransactionError(TransactionError result)
// {
//     Console.WriteLine($"Transaction failed: {result.ErrorMessage}");
// }

// var result = RunTransaction();

// result.Switch(
//     (TransactionSuccess success) => HandleTransactionSuccess(success),
//     HandleTransactionLimitExceeded,
//     (TransactionDuplicate duplicate) => Console.WriteLine($"Transaction is a duplicate with ID: {duplicate.TransactionId}"),
//     HandleTransactionError
// );

