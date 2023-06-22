using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AZURE_PORTAL.Models;

namespace AZURE_PORTAL.usercontext
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
            public DbSet<Application> Applications { get; set; }
    }


}

