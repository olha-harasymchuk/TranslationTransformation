using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationTransformationsAnalysis.Models
{
    public class TransformationUnit
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Original { get; set; }
        [Required]
        public string Translation { get; set; }
        public string ContextFonLevel { get; set; }
        public string ContextLekLevel { get; set; }
        public string ContextMorfLevel { get; set; }
        public string ContextSyntLevel { get; set; }
        public string FormalFonLevel { get; set; }
        public string FormalSlovLevel { get; set; }
        public string FormalLekLevel { get; set; }
        public string FormalMorfLevel { get; set; }
        public string FormalSyntLevel { get; set; }
        public string PragmalPragmalFraTtransformation { get; set; }
        public string PragmalKoncTransformation { get; set; }
        public string PragmalAxTransformation { get; set; }
        public string PragmalMegTransformation { get; set; }
    }
}
