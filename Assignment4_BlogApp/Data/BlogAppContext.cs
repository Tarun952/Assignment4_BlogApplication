using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment4_BlogApp.Models;

    public class BlogAppContext : DbContext
    {
        public BlogAppContext (DbContextOptions<BlogAppContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment4_BlogApp.Models.UserData> UserData { get; set; } = default!;
    }
