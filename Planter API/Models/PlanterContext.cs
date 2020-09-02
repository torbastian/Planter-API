using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planter_API.Models
{
    public class PlanterContext : DbContext
    {
        public PlanterContext(DbContextOptions<PlanterContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            //Not sure we need this, but I'll keep it here for now
            foreach(var relationship in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.SetNull;
            }

            base.OnModelCreating(modelbuilder);
        }

        //DBsets
    }
}
