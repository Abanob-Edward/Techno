using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        public DateTime BrithDate { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        [DisplayName("Phone")]
       //[RegularExpression(@"^01[0125][0-9]{8}$", ErrorMessage = "Invalid PhoneNumber")]
        public int PhoneNumber { get; set; }

        
        public ICollection<UserRole> userRoles { get; set; }

        public ICollection<Product> products { get; set; }


        // what this the eroro 
        //public static implicit operator User(User v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
