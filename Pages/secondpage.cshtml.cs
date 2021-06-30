using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using razordemo.Services;
using razordemo.Models;

namespace razordemo.Pages
{
    public class secondpageModel : PageModel
    {
        [BindProperty]
        public string studentid { get; set; }
        [BindProperty]
        public string studentname { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            Credentials credentials = new Credentials(studentid, studentname);
            HttpResponseMessage response = await CheckInValidationService.validateCredentials(credentials);
            string result = await response.Content.ReadAsStringAsync();
            studentname = result;
            return Page();
        }
    }
}