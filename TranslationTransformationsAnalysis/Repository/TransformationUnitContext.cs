using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslationTransformationsAnalysis.Models;
using TranslationTransformationsAnalysis.ViewModels;

namespace TranslationTransformationsAnalysis.Repository
{
    public class TransformationUnitContext:DbContext
    {
        public TransformationUnitContext(DbContextOptions<TransformationUnitContext> options):base(options)
        {

        }
        public DbSet<TransformationUnit> TransformationUnits { get; set; }
        public DbSet<ContextType> ContextTypes { get; set; }
        public DbSet<FormalType> FormalTypes { get; set; }
        public DbSet<PragmalType> PragmalTypes { get; set; }

    }
}
