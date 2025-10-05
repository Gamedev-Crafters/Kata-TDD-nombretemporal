namespace Tests;

public class Tests {
	
	[Test]
	public void OneConvertsToOne()
	{
		Assert.That("1", Is.EqualTo(FizzBuzz.Convert(1)));
	}

	[Test]
	public void TwoConvertsToTwo()
	{
		Assert.That("2", Is.EqualTo(FizzBuzz.Convert(2)));
	}

	[Test]

	public void ThreeConvertsToFizz()
	{
		Assert.That("Fizz", Is.EqualTo(FizzBuzz.Convert(3)));
	}
}

public class FizzBuzz
{
	public static string Convert(int number)
	{
		return number.ToString();
	}
}