using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WildlifeForum.Models;

namespace WildlifeForum.Data
{
    public class WildlifeForumContext : DbContext
    {
        public WildlifeForumContext (DbContextOptions<WildlifeForumContext> options)
            : base(options)
        {
        }

        public DbSet<WildlifeForum.Models.Discussion> Discussion { get; set; } = default!;
        public DbSet<WildlifeForum.Models.Comment> Comment { get; set; } = default!;
    }
}
