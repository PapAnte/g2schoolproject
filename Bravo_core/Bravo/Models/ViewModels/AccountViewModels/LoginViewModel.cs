using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Models.ViewModels.AccountViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Benutzername")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Passwort")]
        public string Password { get; set; }

        [Display(Name = "Benutzerdaten speichern?")]
        public bool RememberMe { get; set; }
    }
}
