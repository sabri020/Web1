using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web1.Models;

namespace Web1.Data
{
    public class Web1Context : DbContext
    {
        public Web1Context (DbContextOptions<Web1Context> options)
            : base(options)
        {
        }

        public DbSet<Web1.Models.Movie> Movie { get; set; }
    }
}
