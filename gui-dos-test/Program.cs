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
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System.Threading.Tasks;
using NUnit.Framework;
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
        public OrderPage orderPage;
        
            
        
        public Func<int, bool> FuncToTest = (xs) => true;
        public Func<string, bool> CheckSearchStrings = (xs) => true;
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
            Xunit.Assert.Equal("",genericOrder.FirstName);
            Xunit.Assert.Equal("", genericOrder.LastName);
            Xunit.Assert.Equal("", genericOrder.Email);
            Xunit.Assert.Equal("", genericOrder.PhoneNumber);
            Xunit.Assert.Equal("comment", genericOrder.Comment);

        }


        
        public Func<string, bool> FilterFuncFirstName = (s) => 
        {
            List<Models.GiftBasket> genericGiftBaskets = new List<Models.GiftBasket>();

            OrderForm orderForm = new OrderForm
            {
                FirstName = s,
                LastName = "Lastname",
                PhoneNumber = "00000000",
                Email = "a@a.a",
                Comment = "comment"
            };
            Order newOrder = new Order(genericGiftBaskets);
            newOrder.FillInformation(orderForm);
            OrderPage orderpage = new OrderPage();
            return orderpage.FilterFunc(newOrder, s); 
        };
        public Func<string, bool> FilterFuncLastName = (s) =>
        {
            List<Models.GiftBasket> genericGiftBaskets = new List<Models.GiftBasket>();

            OrderForm orderForm = new OrderForm
            {
                FirstName = "Firstname",
                LastName = s,
                PhoneNumber = "00000000",
                Email = "a@a.a",
                Comment = "comment"
            };
            Order newOrder = new Order(genericGiftBaskets);
            newOrder.FillInformation(orderForm);
            OrderPage orderpage = new OrderPage();
            return orderpage.FilterFunc(newOrder, s);
        };
        public Func<string, bool> FilterFuncPhoneNr = (s) =>
        {
            List<Models.GiftBasket> genericGiftBaskets = new List<Models.GiftBasket>();

            OrderForm orderForm = new OrderForm
            {
                FirstName = "Firstname",
                LastName = "Lastname",
                PhoneNumber = s,
                Email = "a@a.a",
                Comment = "comment"
            };
            Order newOrder = new Order(genericGiftBaskets);
            newOrder.FillInformation(orderForm);
            OrderPage orderpage = new OrderPage();
            return orderpage.FilterFunc(newOrder, s);
        };
        [Fact]
        public void FilterFuncFindsSearchstringFirstName()
        {
            Prop.ForAll(FilterFuncFirstName).VerboseCheckThrowOnFailure();


        }
        [Fact]
        public void FilterFuncFindsSearchstringLastName()
        {
            Prop.ForAll(FilterFuncLastName).VerboseCheckThrowOnFailure();

        }
        [Fact]
        public void FilterFuncFindsSearchstringPhoneNumber()
        {
            Prop.ForAll(FilterFuncPhoneNr).VerboseCheckThrowOnFailure();

        }
        /*[Fact]
        public void HelloWorldComponentRendersCorrectly()
        {
            // Arrange
            using var ctx = new TestContext();

            // Act
            var cut = ctx.RenderComponent<gui_dos.Shared.CartComp>();

            // Assert
            cut.MarkupMatches("< MudText Align = 'Align.Center' >< strong > Din indkøbskurv er tom.</ strong ></ MudText >");
        }*/
        /*[Fact]
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

        }*/
        [Fact]
        public async void EndToEndTest()
        {
            Tests endtoendTester = new Tests();
            Console.WriteLine("Shit");
            await endtoendTester.Main();
            Console.WriteLine("Shit worked");
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

    
    public class Tests
    {
        public async Task Main()
        {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Proxy = new Proxy { Bypass = "localhost:44367"},
            Headless = false,
        });;
        var context = await browser.NewContextAsync();
        // Open new page
        var page = await context.NewPageAsync();
        // Go to https://localhost:44367/
        await page.GotoAsync("https://localhost:44367/");
        // Click text=Webshop
        await page.ClickAsync("text=Webshop");
        // Assert.AreEqual("https://localhost:44367/shop", page.Url);
        // Click text=Menu Forside Webshop Log ind >> :nth-match(span, 2)
        await page.ClickAsync("text=Menu Forside Webshop Log ind >> :nth-match(span, 2)");
        // Assert.AreEqual("https://localhost:44367/shop", page.Url);
        // Click text=Webshop
        await page.ClickAsync("text=Webshop");
        // Assert.AreEqual("https://localhost:44367/shop", page.Url);
        // Click text=Lille gavekurv 300 kr. Se mere Bestil >> :nth-match(button, 2)
        await page.ClickAsync("text=Lille gavekurv 300 kr. Se mere Bestil >> :nth-match(button, 2)");
        // Click button:has-text("Tilføj til kurv")
        await page.ClickAsync("button:has-text(\"Tilføj til kurv\")");
        // Click button:has-text("Til bestilling")
        await page.RunAndWaitForNavigationAsync(async () =>
        {
            await page.ClickAsync("button:has-text(\"Til bestilling\")");
        }/*, new PageWaitForNavigationOptions
        {
            UrlString = "https://localhost:44367/checkout"
        }*/);
        // Click form div div >> :nth-match(div:has-text("Email"), 5)
        await page.ClickAsync("form div div >> :nth-match(div:has-text(\"Email\"), 5)");
        // Fill input[type="text"]
        await page.FillAsync("input[type=\"text\"]", "n@n.nn");
        // Click .mud-grid.mud-grid-spacing-xs-3 div:nth-child(2) .mud-input-control .mud-input-control-input-container .mud-input input
        await page.ClickAsync(".mud-grid.mud-grid-spacing-xs-3 div:nth-child(2) .mud-input-control .mud-input-control-input-container .mud-input input");
        // Fill .mud-grid.mud-grid-spacing-xs-3 div:nth-child(2) .mud-input-control .mud-input-control-input-container .mud-input input
        await page.FillAsync(".mud-grid.mud-grid-spacing-xs-3 div:nth-child(2) .mud-input-control .mud-input-control-input-container .mud-input input", "12345678");
        // Click .mud-grid-item.mud-grid-item-xs-6 .mud-input-control .mud-input-control-input-container .mud-input input
        await page.ClickAsync(".mud-grid-item.mud-grid-item-xs-6 .mud-input-control .mud-input-control-input-container .mud-input input");
        // Fill .mud-grid-item.mud-grid-item-xs-6 .mud-input-control .mud-input-control-input-container .mud-input input
        await page.FillAsync(".mud-grid-item.mud-grid-item-xs-6 .mud-input-control .mud-input-control-input-container .mud-input input", "1111");
        // Click div:nth-child(4) .mud-input-control .mud-input-control-input-container .mud-input input
        await page.ClickAsync("div:nth-child(4) .mud-input-control .mud-input-control-input-container .mud-input input");
        // Fill div:nth-child(4) .mud-input-control .mud-input-control-input-container .mud-input input
        await page.FillAsync("div:nth-child(4) .mud-input-control .mud-input-control-input-container .mud-input input", "1111");
        // Click text=Ønsket afhentnings datoDobbelt tjek at denne er rigitg >> input[type="text"]
        await page.ClickAsync("text=Ønsket afhentnings datoDobbelt tjek at denne er rigitg >> input[type=\"text\"]");
        // Click [aria-label="torsdag, 09 december 2021"]
        await page.ClickAsync("[aria-label=\"torsdag, 09 december 2021\"]");
        // Click text=Email Telefon nummer Fornavn Efternavn Ønsket afhentnings datoDobbelt tjek at de >> :nth-match(button, 2)
        await page.ClickAsync("text=Email Telefon nummer Fornavn Efternavn Ønsket afhentnings datoDobbelt tjek at de >> :nth-match(button, 2)");
        // Fill textarea[type="text"]
        await page.FillAsync("textarea[type=\"text\"]", "3");
        // Check input[type="checkbox"]
        await page.CheckAsync("input[type=\"checkbox\"]");
        // Click button:has-text("Bestil ordre")
        await page.ClickAsync("button:has-text(\"Bestil ordre\")");
        // Click button:has-text("Ja")
        await page.RunAndWaitForNavigationAsync(async () =>
        {
            await page.ClickAsync("button:has-text(\"Ja\")");
        }/*, new PageWaitForNavigationOptions
        {
            UrlString = "https://localhost:44367/shop"
        }*/);
            
    }
}
    }



