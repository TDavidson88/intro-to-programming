
using Banking.Domains;
namespace Banking.Tests.Accounts;
public class MakingWithdrawals
{
    [Theory]
    [InlineData(100.10)]
    [InlineData(200.20)]
    public void MakingAWithdrawalDecreasesBalance(decimal amountToWithdraw)
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        // var amountToWithdraw = 100.10M;
        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
    }

    [Fact]
    public void CanWithdrawAllMoney()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        account.Withdraw(openingBalance);
        Assert.Equal(0, account.GetBalance());
    }

    [Fact(Skip = "will do it later")]

    public void OverdraftNotAllowed()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = openingBalance + .01M;
        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance, account.GetBalance());
    }

    [Fact]
    public void WhenOverDraftMethodThrows()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = openingBalance + .01M;
        Assert.Throws<AccountOverdraftException>(() => account.Withdraw(amountToWithdraw));
    }

    [Fact]

    public void WhenOverDraftBalanceIsNotReducedNotAllowed()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = openingBalance + .01M;
        try
        {
            account.Withdraw(amountToWithdraw);
        }
        catch (AccountTransactionException)
        {
            // ignored
        }
        Assert.Equal(openingBalance, account.GetBalance());
    }

    [Fact]

    public void CannotMakeWithdrawalWithNegativeNumbers()

    {
        var account = new Account();

        Assert.Throws<AccountNegativeTransactionAmountException>(() => account.Withdraw(-3));
    }
}
