
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

    [Fact(Skip = "will do it later")]

    public void OverdraftNotAllowed()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = openingBalance + .01M;
        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance, account.GetBalance());
    }
}
