using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebOne.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please, enter your name!")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter your email adress")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "enter valid email adress!")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Enter your numner phone!")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Enter you attend")]
        public bool ? WillAttend { get; set; }
    }
}
