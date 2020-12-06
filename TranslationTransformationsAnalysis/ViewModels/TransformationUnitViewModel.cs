using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationTransformationsAnalysis.ViewModels
{
    public class TransformationUnitViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Оригінал")]

        public string Original { get; set; }
        [Display(Name = "Переклад")]

        public string Translation { get; set; }
        [Display(Name = "Формальні")]

        public string Formal { get; set; }
        [Display(Name = "Формально-змістові")]

        public string Context { get; set; }
        [Display(Name = "Прагматичні")]

        public string Pragmal { get; set; }

        public ContextTypeViewModel ContextType { get; set; }
        public FormalTypeViewModel FormalType { get; set; }
        public PragmalTypeViewModel PragmalType { get; set; }
        public int FormalTypeId { get; set; }
        public int ContextTypeId { get; set; }
        public int PragmalTypeId { get; set; }
    }
}
