public interface ITransactionResult;

public record TransactionSuccess(long TransactionId) : ITransactionResult;
public record TransactionLimitExceeded : ITransactionResult;
public record TransactionError(string ErrorMessage) : ITransactionResult;
public record TransactionDuplicate(long TransactionId) : ITransactionResult;
