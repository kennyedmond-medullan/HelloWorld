using NUnit.Framework;
using System;
using HelloWorld;

namespace HelloWorldTest
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void TestCase ()
		{
			Assert.AreEqual ("Hello World!", HelloWorld.Program.CreateMessage ());
		}
	}
}

