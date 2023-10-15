using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcProgQuestions.Models;

namespace MvcProgQuestions.Data
{
    public class MvcProgQuestionsContext : DbContext
    {
        public MvcProgQuestionsContext (DbContextOptions<MvcProgQuestionsContext> options)
            : base(options)
        {
        }

        public DbSet<MvcProgQuestions.Models.Question> Question { get; set; } = default!;
    }
}
