using System;
using System.Collections.Generic;
using FsCheck;
using FsCheck.Xunit;
using Xunit;
using Xunit.Abstractions;
using Bunit;
using Microsoft.VisualStudio.CodeCoverage;
using gui_dos;
using gui_dos.Forms;
using gui_dos.Models;
using gui_dos.Pages;
using Microsoft.EntityFrameworkCore;
using gui_dos.Data;

namespace gui_dos.Tests
{
    
    public class TestClass
        {
        public List<GiftBasket> genericGiftBaskets;
        public Order genericOrder;
        public OrderForm genericOrderForm;
        public CheckOut checkOutPage;
        public gui_dos.Data.IsvaerftetDbContext testDb;
        
            
        
        public Func<int, bool> FuncToTest = (xs) => true;
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
        public void TestStripOrder()
        {
            genericGiftBaskets = new List<Models.GiftBasket>();
            genericOrder = new Models.Order(genericGiftBaskets);
            genericOrderForm = new OrderForm();
            genericOrderForm.FirstName = "Firstname";
            genericOrderForm.LastName = "Lastname";
            genericOrderForm.PhoneNumber = "00000000";
            genericOrderForm.Email = "a@a.a";
            genericOrderForm.Comment = "comment";
            genericOrder.FillInformation(genericOrderForm);

            genericOrder.StripInformation();
            Assert.Equal("",genericOrder.FirstName);
            Assert.Equal("", genericOrder.LastName);
            Assert.Equal("", genericOrder.Email);
            Assert.Equal("", genericOrder.PhoneNumber);
            Assert.Equal("comment", genericOrder.Comment);

        }
        [Fact]
        public void testDatabaseDoesNotChangeOrder()
        {
            
            genericGiftBaskets = new List<Models.GiftBasket>();
            genericOrder = new Models.Order(genericGiftBaskets);
            genericOrderForm = new OrderForm
            {
                FirstName = "Firstname",
                LastName = "Lastname",
                PhoneNumber = "00000000",
                Email = "a@a.a",
                Comment = "comment"
            };
            genericOrder.FillInformation(genericOrderForm);
            
            
            testDb.Orders.Add(genericOrder);
            Order datebaseOrder = testDb.Orders.Find("Firstname");
            Assert.Equal(genericOrder, datebaseOrder);

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
