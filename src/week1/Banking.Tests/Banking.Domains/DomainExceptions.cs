

namespace Banking.Domains;

public class AccountOverdraftException : AccountTransactionException;
public class AccountTransactionException : ArgumentOutOfRangeException;
public class  AccountNegativeTransactionAmountException: AccountTransactionException;

