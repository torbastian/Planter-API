using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Planter_API.Models
{
    public class PlantType
    {
        [Key]
        public int PlantTypeID { get; set; }
        public string PType { get; set; }

        //Relationships (Til Senere)
        public List<Plants> Plants { get; set; }
    }
}
