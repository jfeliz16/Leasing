using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JETech.Leasing.Web.Data.Entities
{
    public class User :IdentityUser
    {
        [MaxLength(30, ErrorMessage = "This field {0} can not have more than {1} characters.")]
        [Required(ErrorMessage = "This field is mandatory.")]
        public string Document { get; set; }

        [Required(ErrorMessage = "This field is mandatory.")]
        [MaxLength(50, ErrorMessage = "This field {0} can not have more than {1} characters.")]
        [Display(Name = "Firts Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field is mandatory.")]
        [MaxLength(50, ErrorMessage = "This field {0} can not have more than {1} characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [MaxLength(30, ErrorMessage = "This field {0} can not have more than {1} characters.")]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }

        [MaxLength(30, ErrorMessage = "This field {0} can not have more than {1} characters.")]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }

        public string Address { get; set; }

        [Display(Name = "Owner Name")]
        public string FullName => $"{FirstName} {LastName}";

        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";
    }
}
