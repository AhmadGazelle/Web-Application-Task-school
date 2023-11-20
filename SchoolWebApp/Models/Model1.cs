using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SchoolWebApp.Models
{
	public partial class Model1 : DbContext
	{
		public Model1()
			: base("name=Model1")
		{
		}

		public virtual DbSet<Course> Courses { get; set; }
		public virtual DbSet<Student> Students { get; set; }
		public virtual DbSet<Tetcher> Tetchers { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}
