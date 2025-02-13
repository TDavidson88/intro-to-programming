using Banking.Domains;

namespace Banking.Tests.GoldAccounts;
public class GetBonusOnDeposits
{
    private decimal openingBalance = 5000;


    public void GetBonus()
    {
        var account = new Account();
        var amountToDeposit = 100M;
        var expectedBonus = 20M;
        var expectedNewBalance = openingBalance + amountToDeposit + expectedBonus;
        account.IsGoldAccount = true;
        account.Deposit(amountToDeposit);
        Assert.Equal(expectedNewBalance, account.GetBalance());
    }
}
