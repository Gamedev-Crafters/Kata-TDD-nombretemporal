using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Tests;

public class Tests {
	[SetUp]
	public void Setup() { }

	[Test]
	public void asdfjhsakdhjf() {
		Assert.AreEqual(false, IsLeapYear(1997));
	}

	private bool IsLeapYear(int i)
	{
		throw new NotImplementedException();
	}
}