using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Obavezan unos korisnickog imena!")]
        public string username{ get; set; }
        [Required(ErrorMessage = "Obavezan unos lozinke!")]
        public string password { get; set; }

        public bool RememberMe { get; set; }

    }
}
