using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Planter_API.Models
{
    public class Usertype
    {
        [Key]
        public int UserTypeID { get; set; }
        public string UType { get; set; }

        //Relationships (Til Senere)
        //public List<Plant> Plants { get; set; }
    }
}
