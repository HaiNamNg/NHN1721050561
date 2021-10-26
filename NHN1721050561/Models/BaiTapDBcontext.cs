using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NHN1721050561.Models
{
    public partial class BaiTapDBcontext : DbContext
    {
        public BaiTapDBcontext()
            : base("name=BaiTapDBcontext")
        {
        }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Lecture> Lectures { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lecture>()
                .Property(e => e.Faculty)
                .IsUnicode(true);
            modelBuilder.Entity<Lecture>()
                .Property(e => e.Department)
                .IsUnicode(true);
        }
    }
}
//DESKTOP-GIPHEE4\SQLEXPRESS