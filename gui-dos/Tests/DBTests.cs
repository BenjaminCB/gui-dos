using System;
using FsCheck;
using FsCheck.Xunit;
using Xunit;
using Xunit.Abstractions;

namespace gui_dos
{
    public class TestClass
    {
        public Func<int, bool> FuncToTest = (xs) => true;
        public Func<int, bool> FuncToFail = (xs) => false;
        private readonly ITestOutputHelper testOutputHelper;
        public TestClass(ITestOutputHelper testOutput)
        {
            testOutputHelper = testOutput;
        }
        [Fact]
        public void Test1()
        {
            Prop.ForAll(FuncToTest).VerboseCheckThrowOnFailure(testOutputHelper);

        }
        [Fact]
        public void Test2()
        {
            Prop.ForAll(FuncToFail).VerboseCheckThrowOnFailure(testOutputHelper);
        }

    }
    public class OutputHelper : ITestOutputHelper
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public void WriteLine(string format, params object[] args)
        {
            throw new NotImplementedException();
        }
    }


}

