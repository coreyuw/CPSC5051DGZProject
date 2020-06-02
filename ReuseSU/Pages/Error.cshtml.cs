using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ReuseSU.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

    /// Model class for the ClaimItem.cshtml.cs page 
    public class ErrorModel : PageModel
    {
        // the unique id for each request
        public string RequestId { get; set; }

        // shows request id
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        // stores log of errors
        private readonly ILogger<ErrorModel> _logger;

        //  initialize logger
        public ErrorModel(ILogger<ErrorModel> logger)
        {
            _logger = logger;
        }

        // on get request that fails log id
        public void OnGet()
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        }
    }
}
