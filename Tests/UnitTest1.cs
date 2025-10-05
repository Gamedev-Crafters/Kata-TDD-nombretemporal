namespace Tests;

public class Tests {
	[Test]
	public void OneReturnsOne()
	{
		Assert.That(1, Is.EqualTo(FizzBuzz.Convert(1)));
	}
}

public class FizzBuzz
{
	public static int Convert(int i)
	{
		return 1;
	}
}