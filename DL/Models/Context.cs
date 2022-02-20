using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DL.Models
{
    public class Context : DbContext
    {
        public DbSet<Materia> Materias {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=TestCRUD;Trusted_Connection=True;");            //Data Source=.;Initial Catalog=TestCRUD;User ID=sa;Password=***********
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Materia>()
        //                .MapToStoredProcedures();
        //}


    }
}
