using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjectWebpage.Pages
{
    public class biscuitModel : PageModel
    {
        private readonly ILogger<biscuitModel> _logger;

        public biscuitModel(ILogger<biscuitModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

          

    }
}

namespace DemoWebCam.Controllers
{
    public class CameraController : Controller
    {
        public IActionResult Capture()
        {
            return View();
        }
    }
}
