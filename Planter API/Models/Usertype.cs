using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Planter_API.Models
{
    public class UserType
    {
        [Key]
        public int UserTypeID { get; set; }
        public string UType { get; set; }

        //Relationships (Til Senere)
        public List<Users> users { get; set; }

        public List<Plants> Plants { get; set; }
    }
}
