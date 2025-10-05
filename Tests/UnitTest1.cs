namespace Tests;

public class Tests {
	[Test]
	public void OneConvertsToOne()
	{
		Assert.That("1", Is.EqualTo(FizzBuzz.Convert(1)));
	}
}

public class FizzBuzz
{
	public static string Convert(int i)
	{
		return "1";
	}
}