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
	
	[Test]
	public void FourConvertsToFour()
	{
		Assert.That("4", Is.EqualTo(FizzBuzz.Convert(4)));
	}
	
	[Test]
	public void FiveConvertsToBuzz()
	{
		Assert.That("Buzz", Is.EqualTo(FizzBuzz.Convert(5)));
	}
	
	[Test]
	public void SixConvertsToFizz()
	{
		Assert.That("Fizz", Is.EqualTo(FizzBuzz.Convert(6)));
	}
	
	[Test]
	public void NineConvertsToFizz()
	{
		Assert.That("Fizz", Is.EqualTo(FizzBuzz.Convert(9)));
	}
	
	[Test]
	public void TenConvertsToBuzz()
	{
		Assert.That("Buzz", Is.EqualTo(FizzBuzz.Convert(10)));
	}
	
	
}


/*
 Write a function that takes positive integers and outputs their string representation.

	Your function should comply with the following additional rules:

If the number is a multiple of three, return the string "Fizz".
	If the number is a multiple of five, return the string "Buzz".
	If the number is a multiple of both three and five, return the string "FizzBuzz".	
*/
public class FizzBuzz
{
	public static string Convert(int number)
	{
		if (number % 3 == 0)
		{
			return "Fizz";
		}
		
		if (number == 5)
		{
			return "Buzz";
		}
		
		return number.ToString();
	}
}