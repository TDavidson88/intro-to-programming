


namespace Banking.Domains;

public class Account
{
    public decimal _openingBalance = 5000;  
    public Account()
    {
    }

    public void Deposit(decimal amountToDeposit)
    {
        _openingBalance += amountToDeposit;
    }

    public decimal GetBalance()
    {
        return _openingBalance;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        _openingBalance -= amountToWithdraw;
    }
}