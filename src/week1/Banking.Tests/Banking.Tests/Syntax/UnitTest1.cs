namespace Banking.Tests;

public class UnitTest1
{

    string name = "bob";

    [Fact]
    public void DeclaringVariables()
    {
        var age = 0;

        var yourAge = 16.5;

        var myHourlyPay = 12.5M;

        Assert.Equal(0, age);

    }

    [Fact]
    public void AnotherThing()
    {
        Assert.Equal("bob", this.name);
    }
}
