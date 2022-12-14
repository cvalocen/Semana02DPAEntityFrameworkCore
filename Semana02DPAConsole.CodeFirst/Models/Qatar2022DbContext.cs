using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02DPAConsole.CodeFirst.Models
{
    public class Qatar2022DbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //Windows authentications
            var myCnxString = "Server=LENOVO\\SQLEXPRESS;Database=Qatar2022Db;Integrated Security = true"; //ira en un json luego
            // SQL auth
            //var myCnxString = "Server=MYSERVER;Database=MYDATABASE;User=MYUSER;Password=MYPASSWORD"; 


            options
                .UseSqlServer(myCnxString)
                .LogTo(Console.WriteLine, LogLevel.Information);


        }

        public virtual DbSet<Player> Player { get; set; } //como voy a llamar a la clase Player con sus metodos get and set




    }
}
