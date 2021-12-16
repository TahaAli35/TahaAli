namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
       
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<registration> Registrations { get; set; }
        public virtual DbSet<student> student { get; set; }
        public virtual DbSet<teacher> teacher { get; set; }
        public virtual DbSet<Empolyee> Empolyee { get; set; }


    }

    public class registration
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string status { get; set; }

    }
    public class login
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string password { get; set; }

    }

    public class student
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string status { get; set; }

    }
    public class teacher
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string status { get; set; }

    }
    public class Empolyee
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string status { get; set; }

    }

}