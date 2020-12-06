using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslationTransformationsAnalysis.Models;
using TranslationTransformationsAnalysis.Repository;
using TranslationTransformationsAnalysis.ViewModels;

namespace TranslationTransformationsAnalysis.Services
{
    public class TransformationUnitServices
    {
        private readonly TransformationUnitRepository _repository;
        private readonly IMapper _mapper;
        public TransformationUnitServices(IMapper mapper, TransformationUnitRepository repository)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public IEnumerable<TransformationUnit> GetTransformationUnitsAsync()
        {
            var units =   _repository.GetAllTransformationUnitsAsync();
            return units;
        }

        public TransformationUnit GetById(int id)
        {
            var res = _repository.GetTransformationUnit(id);
            return (res);
        }

        public bool CreateUnit(TransformationUnit unit)
        {
            try
            {
                _repository.CreateTransformationUnits(unit);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateUnit(TransformationUnit unit)
        {
            _repository.UpdateRepo(unit);
        }

        public bool DeleteUnit(int id)
        {
            if (id != 0)
            {
                var res = _repository.DeleteTransformationUnit(id);
                return res;
            }
            return false;
        }
    }
}
