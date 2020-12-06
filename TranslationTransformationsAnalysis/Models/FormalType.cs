using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationTransformationsAnalysis.Models
{
    public class FormalType
    {
        [Required]
        public int Id { get; set; }

        public string FonLevel { get; set; }
        public string SlovLevel { get; set; }
        public string LekLevel { get; set; }
        public string MorfLevel { get; set; }
        public string SyntLevel { get; set; }

    }
}
