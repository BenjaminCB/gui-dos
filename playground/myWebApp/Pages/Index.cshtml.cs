using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myWebApp.Models;
using myWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace myWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger,
            SqlProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public SqlProductService ProductService { get; }
        public List<Product> Products { get; private set; }

        public void OnGet()
        {
            Products = ProductService.GetAll();
        }
    }
}
