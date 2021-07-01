using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using razordemo.Controllers;

namespace razordemo.Pages
{
    public class secondpageModel : PageModel
    {
        [BindProperty]
        public string studentid { get; set; }
        [BindProperty]
        public string studentname { get; set; }
        public String data { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            data = await CheckInValidationController.post(studentid, studentname);
            return Page();
        }
    }
}