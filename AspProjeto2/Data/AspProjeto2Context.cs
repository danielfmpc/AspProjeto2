using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspProjeto2.Models;

namespace AspProjeto2.Data
{
    public class AspProjeto2Context : DbContext
    {
        public AspProjeto2Context (DbContextOptions<AspProjeto2Context> options)
            : base(options)
        {
        }

        public DbSet<AspProjeto2.Models.Department> Department { get; set; }
    }
}
