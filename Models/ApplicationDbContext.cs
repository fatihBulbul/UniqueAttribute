using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UniqueAttribute.Attribute;

namespace UniqueAttribute.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
//test
        }

        public DbSet<TestModel> test { get; set; }
    }

    [Table("TestModels")]
    public class TestModel
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Some", Description = "desc")]
        [Unique(ErrorMessage = "This already exist !!")]
        public string SomeThing { get; set; }
    }
}