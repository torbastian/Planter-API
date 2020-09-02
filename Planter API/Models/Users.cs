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

        public Usertype UserType { get; set; }
        [Foreignkey("UserType")]
        public int UserTypeID { get; set; }

        //Relationships (Til Senere)
        //public List<UserType> Plants { get; set; }
    }
}
