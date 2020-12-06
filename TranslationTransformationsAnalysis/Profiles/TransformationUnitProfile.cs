using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslationTransformationsAnalysis.Models;
using TranslationTransformationsAnalysis.ViewModels;

namespace TranslationTransformationsAnalysis.Profiles
{
    public class TransformationUnitProfile:Profile
    {
        public TransformationUnitProfile()
        {
            CreateMap<TransformationUnit, TransformationUnitViewModel>().ReverseMap();
        }
    }
}
