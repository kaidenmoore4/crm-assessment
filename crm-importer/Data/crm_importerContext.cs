using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using crm_importer.Models;

namespace crm_importer.Data
{
    public class crm_importerContext : DbContext
    {
        public crm_importerContext (DbContextOptions<crm_importerContext> options)
            : base(options)
        {
        }

        public DbSet<crm_importer.Models.Lead> Lead { get; set; } = default!;
    }
}
