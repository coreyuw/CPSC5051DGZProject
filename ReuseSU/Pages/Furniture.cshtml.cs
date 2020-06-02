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
    /// Model class for Furniture.cshtml home page
    /// </summary>
    public class FurnitureModel : PageModel
    {
        // Logger instantiation
        private readonly ILogger<IndexModel> _logger;
        // product service instantiation
        public JsonFileProductService ProductService;

        /// <summary>
        /// products Enumerable initiation function
        /// </summary>
        public IEnumerable<Product> Products { get; private set; }

        /// <summary>
        /// Model class constructor
        /// </summary>
        /// <param name="logger">logging data</param>
        /// <param name="productService">product service</param>
        public FurnitureModel(ILogger<IndexModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        /// <summary>
        /// fucntion called when the page is loaded
        /// </summary>
        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }

    }

}
