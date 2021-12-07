using Microsoft.Playwright;
using System.Threading.Tasks;

class Program
{
    public static async Task Main()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false
        });
        var context = await browser.NewContextAsync();
        // Open new page
        var page = await browser.NewPageAsync(new BrowserNewPageOptions { IgnoreHTTPSErrors = true });
        await page.GotoAsync("https://localhost:5001/shop");
        // Click text=Mellem gavekurv 350 kr. Se mere Bestil >> :nth-match(button, 2)
        await page.ClickAsync("text=Mellem gavekurv 350 kr. Se mere Bestil >> :nth-match(button, 2)");
        // Click button:has-text("Tilføj til kurv")
        await page.ClickAsync("button:has-text(\"Tilføj til kurv\")");
        // Click button:has-text("Kurv")
        await page.ClickAsync("button:has-text(\"Kurv\")");
        // Click button:has-text("Gå til bestilling")
        await page.ClickAsync("button:has-text(\"Gå til bestilling\")");
        // Assert.AreEqual("https://localhost:5001/checkout", page.Url);
        // Click input[type="text"]
        await page.ClickAsync("input[type=\"text\"]");
        // Fill input[type="text"]
        await page.FillAsync("input[type=\"text\"]", "bbenne20@student.aau.dk");
        // Press Tab
        await page.PressAsync("input[type=\"text\"]", "Tab");
        // Fill .mud-grid.mud-grid-spacing-xs-3 div:nth-child(2) .mud-input-control .mud-input-control-input-container .mud-input input
        await page.FillAsync(".mud-grid.mud-grid-spacing-xs-3 div:nth-child(2) .mud-input-control .mud-input-control-input-container .mud-input input", "24948698");
        // Press Tab
        await page.PressAsync(".mud-grid.mud-grid-spacing-xs-3 div:nth-child(2) .mud-input-control .mud-input-control-input-container .mud-input input", "Tab");
        // Fill .mud-grid-item.mud-grid-item-xs-6 .mud-input-control .mud-input-control-input-container .mud-input input
        await page.FillAsync(".mud-grid-item.mud-grid-item-xs-6 .mud-input-control .mud-input-control-input-container .mud-input input", "Benjamin");
        // Press Tab
        await page.PressAsync(".mud-grid-item.mud-grid-item-xs-6 .mud-input-control .mud-input-control-input-container .mud-input input", "Tab");
        // Fill div:nth-child(4) .mud-input-control .mud-input-control-input-container .mud-input input
        await page.FillAsync("div:nth-child(4) .mud-input-control .mud-input-control-input-container .mud-input input", "Bennetzen");
        // Press Tab
        await page.PressAsync("div:nth-child(4) .mud-input-control .mud-input-control-input-container .mud-input input", "Tab");
        // Click text=Ønsket afhentnings datoDobbelt tjek at denne er rigitg >> button
        await page.ClickAsync("text=Ønsket afhentnings datoDobbelt tjek at denne er rigitg >> button");
        // Click [aria-label="Friday, 17 December 2021"]
        await page.ClickAsync("[aria-label=\"Friday, 17 December 2021\"]");
        // Check input[type="checkbox"]
        await page.CheckAsync("input[type=\"checkbox\"]");
        await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });
        // Click button:has-text("Bestil ordre")
        await page.ClickAsync("button:has-text(\"Bestil ordre\")");
        // Click button:has-text("Ja")
        await page.RunAndWaitForNavigationAsync(async () =>
        {
            await page.ClickAsync("button:has-text(\"Ja\")");
        }/*, new PageWaitForNavigationOptions
        {
            UrlString = "https://localhost:5001/shop"
        }*/);
    }
}
