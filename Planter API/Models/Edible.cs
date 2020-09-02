using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Planter_API.Models
{
    public class Edible
    {
        [Key]
        public int EdibleID { get; set; }
        public string EdibleS { get; set; }

        //Relationships (Til Senere)
        public List<Plants> Plants { get; set; }
    }
}
