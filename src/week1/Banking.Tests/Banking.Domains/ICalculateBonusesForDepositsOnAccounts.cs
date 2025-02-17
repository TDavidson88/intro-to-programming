namespace Banking.Domains;


public interface ICalculateBonusesForDepositsOnAccounts
{
    decimal CalculateBonusForDeposit(decimal balance, decimal depositAmount);
}