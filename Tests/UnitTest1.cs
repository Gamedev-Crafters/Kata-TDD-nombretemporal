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
}

public class FizzBuzz
{
	public static string Convert(int i)
	{
		return i.ToString();
	}
}