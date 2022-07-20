using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebpage.Pages
{
    public class TraderModel : PageModel
    {
        private readonly ILogger<TraderModel> _logger;

        public TraderModel(ILogger<TraderModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
