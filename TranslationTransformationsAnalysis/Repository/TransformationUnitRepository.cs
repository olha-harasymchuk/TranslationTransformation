using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslationTransformationsAnalysis.Models;

namespace TranslationTransformationsAnalysis.Repository
{
    public class TransformationUnitRepository
    {
        private readonly TransformationUnitContext _context;
        public TransformationUnitRepository(TransformationUnitContext context)
        {
            _context = context;
        }
        private IEnumerable<TransformationUnit> GetAllTransformationUnitsEmpty()
        {
            return _context.TransformationUnits.OrderBy(x=>x.Id);
        }


        public IEnumerable<TransformationUnit> GetAllTransformationUnitsAsync()
        {
            var res = GetAllTransformationUnitsEmpty();
            return res;
        }

        public TransformationUnit GetTransformationUnit(int id)
        {
            var res = _context.TransformationUnits.Single(x => x.Id == id);
            return res;
        }

        public void UpdateRepo(TransformationUnit unit)
        {
            _context.TransformationUnits.Update(unit);
            _context.SaveChanges();
        }
        public bool CreateTransformationUnits(TransformationUnit unit)
        {
            if (unit != null)
            {
                try
                {
                _context.Add(unit);
                _context.SaveChanges();
                return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }
            else
                return false;

        }

        public bool DeleteTransformationUnit (int id)
        {
           var item = _context.TransformationUnits.Find(id);
            if (item!=null)
            {
                try
                {
                _context.TransformationUnits.Remove(item);
                _context.SaveChanges();
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
