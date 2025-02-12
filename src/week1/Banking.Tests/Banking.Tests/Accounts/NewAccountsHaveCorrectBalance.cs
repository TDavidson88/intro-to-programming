

using Banking.Domains;

namespace Banking.Tests.Accounts;
public class NewAccountsHaveCorrectBalance
{
    [Fact]
    public void BalanceIsCorrect()
    {
        var correctOpeningBalance = 5000M;
        
        var myAccount = new Account();
        var yourAccount = new Account();

        var myBalance= myAccount.GetBalance();
        decimal yourBalance = yourAccount.GetBalance();

        Assert.Equal(correctOpeningBalance, myBalance);
        Assert.Equal(correctOpeningBalance, yourBalance);

    }

    [Fact]
    public void MakingADepositIncreasesBalance()
    {

        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100.10M;

        Assert.Equal(openingBalance, account._openingBalance);

        account.Deposit(amountToDeposit);

        var newBalance = account.GetBalance();

        
        Assert.Equal(amountToDeposit + openingBalance, account.GetBalance());
    }
}
