

namespace Banking.Domains;

public class AccountTransactionException : ArgumentOutOfRangeException;
public class AccountOverdraftException : AccountTransactionException;
public class AccountNegativeTransactionAmountException : AccountTransactionException;
