using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planter_API.Models
{
    public class PlanterContext : DbContext
    {
        //DBsets
        public DbSet<ApprovedType> ApprovedTypes { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Climates> Climates { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Edible> Edibles { get; set; }
        public DbSet<Plants> Plants { get; set; }
        public DbSet<PlantType> PlantTypes { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UserType> Usertypes { get; set; }
    }
}
