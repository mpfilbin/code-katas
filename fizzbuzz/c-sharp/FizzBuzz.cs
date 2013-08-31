using NUnit.Framework;

[TestFixture]
public class FizzBuzz
{
    [Test]
    public void PassingInOneShouldReturnOne()
    {
        var result = FizzBuzzCalc(1);
        Assert.AreEqual("1", result);
    }

    [Test]
    public void PassingInTwoShouldReturnTwo()
    {
        var result = FizzBuzzCalc(2);
        Assert.AreEqual("2", result);
    }

    [Test]
    public void PassingInThreeShouldReturnFizz()
    {
        var result = FizzBuzzCalc(3);
        Assert.AreEqual("Fizz", result);
    }

    [Test]
    public void PassingInSixShouldReturnFizz()
    {
        var result = FizzBuzzCalc(6);
        Assert.AreEqual("Fizz", result);
    }

    [Test]
    public void PassingInFiveShouldReturnBuzz()
    {
        var result = FizzBuzzCalc(5);
        Assert.AreEqual("Buzz", result);
    }

    [Test]
    public void PassingIn15ShouldReturnFizzBuzz()
    {
        var result = FizzBuzzCalc(15);
        Assert.AreEqual("Fizz Buzz", result);
    }

    public string FizzBuzzCalc(int value)
    {
        var output = value.ToString();

        if (value % 15 == 0)
        {
            output = "Fizz Buzz";
        }
        else if (value % 3 == 0)
        {
            output = "Fizz";
        }
        else if (value % 5 == 0)
        {
            output = "Buzz";
        }

        return output;
    }
}
