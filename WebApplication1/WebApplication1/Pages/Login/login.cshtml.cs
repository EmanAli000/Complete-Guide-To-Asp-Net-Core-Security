using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages.Login
{
    public class loginModel : PageModel
    {
        [BindProperty]
        public Credential Credential { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }

    public class Credential
    {
        [Required]
        [DisplayName("User Name: ")]
        public string UserName { get; set; }
        [Required]
        [DisplayName("Password : ")]
        public string Password { get; set; }
    }
}
