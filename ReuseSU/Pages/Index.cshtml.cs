using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.WebSite.Services;
using ReuseSU.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ReuseSU.Pages
{
    /// <summary>
    /// Model class for index.cshtml.cs home page
    /// </summary>
    public class IndexModel : PageModel
    {
        // used for logging data
        private readonly ILogger<IndexModel> _logger;

        // product service declaration
        public JsonFileProductService ProductService;

        /// <summary>
        /// products Enumerable instantiation
        /// </summary>
        public IEnumerable<Product> Products { get; private set; }

        /// <summary>
        /// the model of the index.cshtml.cs page
        /// </summary>
        /// <param name="logger">logging data</param>
        /// <param name="productService">product service</param>
        public IndexModel(ILogger<IndexModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        /// <summary>
        /// function called when the page is loaded
        /// </summary>
        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
