using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planter_API.Models
{
    public class ApprovedType
    {
        [Key]
        public int ApprovedTypeID { get; set; }//PK
        public string AType { get; set; }

        //Relationships (Til Senere)

        //PK ApprovedTypeID(ApprovedType) to FK_ApprovedTypeID(Plants)
        //public List<Plant> Plants { get; set; }

        //PK ApprovedTypeID(ApprovedType) to FK_ApprovedTypeID(Article)
        //public List<Article> Article { get; set; }

    }
}
