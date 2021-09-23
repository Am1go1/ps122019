using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RubicTest.Controllers
{
    public class UsersContexsts : DbContext
    {
        public UsersContexsts(DbContextOptions<UsersContexsts> options)
            : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
    }
}
