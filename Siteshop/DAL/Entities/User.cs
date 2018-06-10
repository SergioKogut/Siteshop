using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Siteshop.DAL.Entities
{
    [Table("tblUser")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(maximumLength: 50)]
        public String Login { get; set; }

        [Required, StringLength(maximumLength: 50)]
        public String FirstName { get; set; }

        [Required, StringLength(maximumLength: 50)]
        public String LastName { get; set; }
       
        [Required, EmailAddress, StringLength(maximumLength: 50)]
        public string Email { get; set; }

        [Required, StringLength(maximumLength: 50)]
        public String Password { get; set; }

        [Required, StringLength(maximumLength: 50)]
        public String Role { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateRegistration { get; set; }


    }
}
