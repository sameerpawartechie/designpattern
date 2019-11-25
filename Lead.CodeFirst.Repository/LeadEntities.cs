
using Microsoft.EntityFrameworkCore;
using Lead.CodeFirst.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lead.CodeFirst.Repository
{
    public partial class LeadEntities : DbContext
    {
        public LeadEntities()
           // : base("name=SEMSEntities")
        {

        }

        //public DbSet<tblClass> tblClasses { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
            
            
            
        //       // modelBuilder.Entity<tblCity>().ToTable("tblCity", "public");
        //       // modelBuilder.Entity<tblClass>().ToTable("tblClass", "public");
                
                
            

            


        //}


    }
}
