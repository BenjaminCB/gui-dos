using System;
using FsCheck;
using FsCheck.Xunit;
using Xunit;
using Xunit.Abstractions;
using gui_dos;
using Bunit;
namespace gui_dos.Tests
{
    
        public class TestClass
        {
            public Order shit;
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
            [Fact]
            public void HelloWorldComponentRendersCorrectly()
            {
                // Arrange
                using var ctx = new TestContext();

                // Act
                var cut = ctx.RenderComponent<gui_dos.Shared.CartComp>();

                // Assert
                cut.MarkupMatches("< MudText Align = 'Align.Center' >< strong > Din indkøbskurv er tom.</ strong ></ MudText >");
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
        public class Order
        {
            public string name;
            string id;
        }
        //class Program
        //{

        //    static void Main(string[] args)
        //    {
        //        ITestOutputHelper helper = new OutputHelper();

        //        TestClass testClass = new TestClass(helper);
        //        testClass.Test1();
        //    }
        //}
    

}
