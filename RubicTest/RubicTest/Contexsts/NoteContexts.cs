using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RubicTest.Models;

namespace RubicTest.Contexsts
{
    public class NoteContexts : DbContext
    {
        public NoteContexts(DbContextOptions<NoteContexts> options)
            : base(options)
        {

        }

        public DbSet<Note> Notes { get; set; }
    }
}
