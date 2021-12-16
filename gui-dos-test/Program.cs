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
    
    public class UnitTests
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
        public UnitTests(ITestOutputHelper testOutput)
        {
            testOutputHelper = testOutput;
        }
        [Fact]
        public void TestTestingFrameworkWorks()
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

        [Fact]
        public void FilterFuncFindsSearchstringFirstName()
        {
            Prop.ForAll(FilterFuncFirstName).VerboseCheckThrowOnFailure();
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
        public void FilterFuncFindsSearchstringLastName()
        {
            Prop.ForAll(FilterFuncLastName).VerboseCheckThrowOnFailure();
        }
        [Fact]
        public void FilterFuncFindsSearchstringPhoneNumber()
        {
            Prop.ForAll(FilterFuncPhoneNr).VerboseCheckThrowOnFailure();

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

    
    public class EndToEndTests
    {// These 3 variables should be set to the appropriate values. URL to the adress of the website,
     // and ORDERFIND to the appropriate order number and dates.
     // You should also set DATETOFIND to an apropriate value
        string URL = "https://localhost:44367/";
        string ORDERFIND = "text=26 Afventer Accepteret Afsluttet Afhentet 08-12-2021 31-01-2022 00:00 n n 0 kr";
        string NEXTMONTH = "januar 2022";
        string DATETOFIND = "mandag, 31 januar 2022";
        [Fact]
        public async void CreateProduct()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            var context = await browser.NewContextAsync();
            // Open new page
            var page = await browser.NewPageAsync(new BrowserNewPageOptions { IgnoreHTTPSErrors = true });
            // Go to https://localhost:44367/
            page.FileChooser += async (_, fileChooser) => {


                await fileChooser.SetFilesAsync("Den bedste kurv.jpeg");
            };
            await page.GotoAsync(URL);
            // Click text=Menu
            await page.ClickAsync("text=Menu");
    
            // Click button:has-text("Log ind")
            await page.ClickAsync("button:has-text(\"Log ind\")");
            // Assert.AreEqual("https://localhost:44367/admin/login", page.Url);
            // Click input[name="Input.UserName"]
            await page.ClickAsync("input[name=\"Input.UserName\"]");
            // Fill input[name="Input.UserName"]
            await page.FillAsync("input[name=\"Input.UserName\"]", "superuser");
            // Click input[name="Input.Password"]
            await page.ClickAsync("input[name=\"Input.Password\"]");
            // Fill input[name="Input.Password"]
            await page.FillAsync("input[name=\"Input.Password\"]", "superuser");
            // Click text=Log ind
            await page.ClickAsync("text=Log ind");
            // Assert.AreEqual("https://localhost:44367/", page.Url);
            // Click text=Menu
            await page.ClickAsync("text=Menu");
            // Click text=Produkter
            await page.ClickAsync("text=Produkter");
            // Assert.AreEqual("https://localhost:44367/product", page.Url);
            // Click button:has-text("Nyt produkt")
            await page.ClickAsync("button:has-text(\"Nyt produkt\")");
            // Assert.AreEqual("https://localhost:44367/product/insert", page.Url);
            // Click input[type="text"]
            await page.ClickAsync("input[type=\"text\"]");
            // Fill input[type="text"]
            await page.FillAsync("input[type=\"text\"]", "cool kurv");
            // Click textarea[type="text"]
            await page.ClickAsync("textarea[type=\"text\"]");
            // Fill textarea[type="text"]
            await page.FillAsync("textarea[type=\"text\"]", "cool kurv");
            // Click text=TagsTags skal være komma-separeret >> input[type="text"]
            await page.ClickAsync("text=TagsTags skal være komma-separeret >> input[type=\"text\"]");
            // Fill text=TagsTags skal være komma-separeret >> input[type="text"]
            await page.FillAsync("text=TagsTags skal være komma-separeret >> input[type=\"text\"]", "Chokolade");
            // Click input[type="file"]
            await page.ClickAsync("input[type=\"file\"]");
            // Upload Den bedste kurv.jpeg
            await page.SetInputFilesAsync("input[type=\"file\"]", new[] { "Den bedste kurv.jpeg" });

            // Click button:has-text("Opret")

            /*, new PageWaitForNavigationOptions
        {
            UrlString = "https://localhost:44367/product"
        }*/

            await System.Threading.Tasks.Task.Delay(1000);
            await page.ClickAsync("button:has-text(\"Opret\")");
        }

        [Fact]
        public async void OrderGiftbasket()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            var context = await browser.NewContextAsync();
            // Open new page
            var page = await browser.NewPageAsync(new BrowserNewPageOptions { IgnoreHTTPSErrors = true });
            // Go to https://localhost:44367/shop
            await page.GotoAsync(URL);
            
            // Click text=Menu
            await page.ClickAsync("text=Menu");
            // Click text=Webshop
            await page.ClickAsync("text=Webshop");
            // Double click text=Menu
            await page.DblClickAsync("text=Menu");
            // Click button:has-text("Bestil")
            await page.ClickAsync("button:has-text(\"Bestil\")");
            // Click button:has-text("Tilføj til kurv")
            await page.ClickAsync("button:has-text(\"Tilføj til kurv\")");
            // Click text=Se mere Bestil >> :nth-match(button, 2)
            await page.ClickAsync("text=Se mere Bestil >> :nth-match(button, 2)");
            // Click button:has-text("Tilføj til kurv")
            await page.ClickAsync("button:has-text(\"Tilføj til kurv\")");
            // Click button:has-text("Til bestilling")
            await page.RunAndWaitForNavigationAsync(async () =>
            {
                await page.ClickAsync("button:has-text(\"Til bestilling\")");
            });
            // Click input[type="text"]
            await page.ClickAsync("input[type=\"text\"]");
            // Fill input[type="text"]
            await page.FillAsync("input[type=\"text\"]", "n@nn.nn");
            // Click .mud-grid.mud-grid-spacing-xs-3 div:nth-child(2) .mud-input-control .mud-input-control-input-container .mud-input input
            await page.ClickAsync(".mud-grid.mud-grid-spacing-xs-3 div:nth-child(2) .mud-input-control .mud-input-control-input-container .mud-input input");
            // Fill .mud-grid.mud-grid-spacing-xs-3 div:nth-child(2) .mud-input-control .mud-input-control-input-container .mud-input input
            await page.FillAsync(".mud-grid.mud-grid-spacing-xs-3 div:nth-child(2) .mud-input-control .mud-input-control-input-container .mud-input input", "12345678");
            // Click .mud-grid-item.mud-grid-item-xs-6 .mud-input-control .mud-input-control-input-container .mud-input input
            await page.ClickAsync(".mud-grid-item.mud-grid-item-xs-6 .mud-input-control .mud-input-control-input-container .mud-input input");
            // Fill .mud-grid-item.mud-grid-item-xs-6 .mud-input-control .mud-input-control-input-container .mud-input input
            await page.FillAsync(".mud-grid-item.mud-grid-item-xs-6 .mud-input-control .mud-input-control-input-container .mud-input input", "n");
            // Click div:nth-child(4) .mud-input-control .mud-input-control-input-container .mud-input input
            await page.ClickAsync("div:nth-child(4) .mud-input-control .mud-input-control-input-container .mud-input input");
            // Fill div:nth-child(4) .mud-input-control .mud-input-control-input-container .mud-input input
            await page.FillAsync("div:nth-child(4) .mud-input-control .mud-input-control-input-container .mud-input input", "n");
            // Click text=Ønsket afhentnings datoDobbelt tjek at denne er rigitg >> input[type="text"]
            await page.ClickAsync("text=Ønsket afhentnings datoDobbelt tjek at denne er rigitg >> input[type=\"text\"]");
            // Click [aria-label="Go to next month januar 2022"]
            await page.ClickAsync("[aria-label=\"Go to next month " + NEXTMONTH + "\"]");
            // Click [aria-label="fredag, 21 januar 2022"]
            var locator = page.Locator("text=Bestil ordre");
            await locator.ScrollIntoViewIfNeededAsync();
            
            await page.ClickAsync("[aria-label=\"" + DATETOFIND + "\"]");
            // Check input[type="checkbox"]
            await page.CheckAsync("input[type=\"checkbox\"]");
            // Click textarea[type="text"]
            await page.ClickAsync("textarea[type=\"text\"]");
            // Fill textarea[type="text"]
            await page.FillAsync("textarea[type=\"text\"]", "hej");
            // Click button:has-text("Bestil ordre")
            await page.ClickAsync("button:has-text(\"Bestil ordre\")");
            // Click button:has-text("Ja")
            await page.RunAndWaitForNavigationAsync(async () =>
            {
                await page.ClickAsync("button:has-text(\"Ja\")");
            });
        }


        [Fact]
        public async void DeleteProduct()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            var context = await browser.NewContextAsync();
            // Open new page
            var page = await browser.NewPageAsync(new BrowserNewPageOptions { IgnoreHTTPSErrors = true });
            // Go to https://localhost:44367/shop
            await page.GotoAsync("https://localhost:44367/");
            
            // Click text=Menu
            await page.ClickAsync("text=Menu");
            // Click button:has-text("Log ind")
            await page.ClickAsync("button:has-text(\"Log ind\")");
            // Assert.AreEqual("https://localhost:44367/admin/login", page.Url);
            // Click input[name="Input.UserName"]
            await page.ClickAsync("input[name=\"Input.UserName\"]");
            // Fill input[name="Input.UserName"]
            await page.FillAsync("input[name=\"Input.UserName\"]", "superuser");
            // Click input[name="Input.Password"]
            await page.ClickAsync("input[name=\"Input.Password\"]");
            // Fill input[name="Input.Password"]
            await page.FillAsync("input[name=\"Input.Password\"]", "superuser");
            // Click text=Log ind
            await page.ClickAsync("text=Log ind");
            // Assert.AreEqual("https://localhost:44367/", page.Url);
            // Click text=Menu
            await page.ClickAsync("text=Menu");
            
            // Click text=Produkter
            await page.ClickAsync("text=Produkter");
            // Assert.AreEqual("https://localhost:44367/product", page.Url);
            // Click button:has-text("Slet")
            await page.ClickAsync("button:has-text(\"Slet\")");
            // Click button:has-text("Ja")
            await page.ClickAsync("button:has-text(\"Ja\")");
        }

        [Fact]
        public async void FinishOrder()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            var context = await browser.NewContextAsync();
            // Open new page
            var page = await browser.NewPageAsync(new BrowserNewPageOptions { IgnoreHTTPSErrors = true });
            // Go to https://localhost:44367/
            await page.GotoAsync(URL);
            
            // Click text=Menu
            await page.ClickAsync("text=Menu");
            // Click button:has-text("Log ind")
            await page.RunAndWaitForNavigationAsync(async () =>
            {
                await page.ClickAsync("button:has-text(\"Log ind\")");
            }/*, new PageWaitForNavigationOptions
        {
            UrlString = "https://localhost:44367/admin/login"
        }*/);
            // Assert.AreEqual("https://localhost:44367/admin/login", page.Url);
            // Click input[name="Input.UserName"]
            await page.ClickAsync("input[name=\"Input.UserName\"]");
            // Fill input[name="Input.UserName"]
            await page.FillAsync("input[name=\"Input.UserName\"]", "superuser");
            // Click input[name="Input.Password"]
            await page.ClickAsync("input[name=\"Input.Password\"]");
            // Fill input[name="Input.Password"]
            await page.FillAsync("input[name=\"Input.Password\"]", "superuser");
            // Click text=Log ind
            await page.ClickAsync("text=Log ind");
            // Assert.AreEqual("https://localhost:44367/", page.Url);
            
            // Click text=Menu
            await page.ClickAsync("text=Menu");
            // Click text=Ordre
            await page.ClickAsync("text=Ordre");

            
            // Assert.AreEqual("https://localhost:44367/order", page.Url);
            // Click text=22 Afventer Accepteret Afsluttet Afhentet 08-12-2021 03-02-2022 00:00 n n 600 kr >> :nth-match(button, 2)
            await page.ClickAsync(ORDERFIND + " >> :nth-match(button, 2)");
            // Click button:has-text("Ja")
            await page.ClickAsync("button:has-text(\"Ja\")");
            // Click text=22 Afventer Accepteret Afsluttet Afhentet 08-12-2021 03-02-2022 00:00 n n 600 kr >> :nth-match(button, 3)
            await page.ClickAsync(ORDERFIND + " >> :nth-match(button, 3)");
            // Click button:has-text("Ja")
            await page.ClickAsync("button:has-text(\"Ja\")");
            // Click text=22 Afventer Accepteret Afsluttet Afhentet 08-12-2021 03-02-2022 00:00 n n 600 kr >> :nth-match(button, 4)
            await page.ClickAsync(ORDERFIND + " >> :nth-match(button, 4)");
            // Click button:has-text("Ja")
            
            await page.ClickAsync("button:has-text(\"Ja\")");
        }
    }

}
        


