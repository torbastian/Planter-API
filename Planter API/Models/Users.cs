using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Planter_API.Models
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public UserType UserType { get; set; }
        [ForeignKey("UserType")]
        public int UserTypeID { get; set; }

        //Relationships (Til Senere)
        public List<UserType> UserType { get; set; }
    }
}
