using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using library.Model;
using System.Drawing;

namespace library.Data
{
    public class libraryContext : DbContext
    {
        public libraryContext (DbContextOptions<libraryContext> options)
            : base(options)
        {
            
        }

        public DbSet<library.Model.kitapVerileri> kitapVerileri { get; set; }
    }
}
