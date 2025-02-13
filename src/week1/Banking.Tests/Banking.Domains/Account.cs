
namespace Banking.Domains;

public class Account
{
    public decimal _currentBalance = 5000;  

    public bool IsGoldAccount { get; set; } 
    public Account()
    {
    }

    public void Deposit(decimal amountToDeposit)
    {
        var bonus = 0M;
        if (IsGoldAccount)
        {
            bonus = amountToDeposit * 0.20M;
        }
        CheckTransactionAmount(amountToDeposit);
        _currentBalance += amountToDeposit;
    }


    public decimal GetBalance()
    {
        return _currentBalance;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        CheckTransactionAmount(amountToWithdraw);
        if (_currentBalance >= amountToWithdraw)
        {
            _currentBalance -= amountToWithdraw;
        }
        else
        {
            throw new AccountOverdraftException();
        }

    }

    private void CheckTransactionAmount(decimal amountToDeposit)
    {
        if (amountToDeposit < 0)
        {
            throw new AccountNegativeTransactionAmountException();
        }
    }
}