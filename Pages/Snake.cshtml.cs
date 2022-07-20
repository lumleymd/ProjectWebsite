using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebpage.Pages
{
    public class SnakeModel : PageModel
    {
        private readonly ILogger<SnakeModel> _logger;

        public SnakeModel(ILogger<SnakeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
