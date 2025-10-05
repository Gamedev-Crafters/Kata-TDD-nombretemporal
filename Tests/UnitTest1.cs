namespace Tests;

public class Tests {
	[SetUp]
	public void Setup() { }

	[Test]
	public void Test1() {
		Assert.Pass();
	}

	[Test]
	public void OneReturnsOne()
	{
		FizzBuzz fizzBuzz = new FizzBuzz();
		Assert.AreEqual(fizzBuzz.Convert(1), 1);
	}
	
}

public class FizzBuzz
{
	public int Convert(int i)
	{
		return 1;
	}
}