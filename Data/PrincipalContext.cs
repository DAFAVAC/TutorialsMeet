using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TutorialsMeet.Models;

namespace TutorialsMeet.Data
{
    public class PrincipalContext : DbContext
    {
        public PrincipalContext (DbContextOptions<PrincipalContext> options)
            : base(options)
        {
        }

        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Reuniones> Reuniones { get; set; }


    }
}
