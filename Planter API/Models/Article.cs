using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Planter_API.Models
{
    public class Article
    {
        [Key]
        public int ArticleID { get; set; }//PK
        public string Text { get; set; }
        public string Tips { get; set; }
        
        //FK ApprovedTypeID
        public ApprovedType ApprovedType { get; set; }
        [ForeignKey("ApprovedTypeID")]
        public int ApprovedTypeID { get; set; }

        //FK PlantID
        //public Plants Plants { get; set; }
        //[ForeignKey("PlantID")]
        //public int PlantID { get; set; }

        //Relationships (Til Senere)

        //PK ArticleID(Article) TO FK_ArticleID(Comments)
        //public List<Comment> Comments { get; set; }

        //PK PlantID(Plants) TO FK_PlantID(Article)

        //PK ApprovedTypeID(ApprovedType) TO FK_ApprovedTypeID(Article)
    }
}
