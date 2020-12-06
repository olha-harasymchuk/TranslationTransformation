using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslationTransformationsAnalysis.Models;
using TranslationTransformationsAnalysis.Services;

namespace TranslationTransformationsAnalysis.Controllers
{
    public class HomeController:Controller
    {

        private readonly TransformationUnitServices _services;
        public HomeController(TransformationUnitServices services)
        {
            _services = services;
        }


        [HttpGet]
        public IActionResult Index(IEnumerable<TransformationUnit> units)
        {
            if (units.Count()!=0)
            {
                return View(units);
            }
            var res = _services.GetTransformationUnitsAsync();
            return View(res);      
        }

        [HttpPost]
        public IActionResult Index(string search, IEnumerable<string> values)
        {
            if (values.Any())
            {
                var res = Filter(values);
                return View(res);
            }
            if (String.IsNullOrEmpty(search))
            {
                 var res = _services.GetTransformationUnitsAsync();
                 return View(res);
            }
            var filtered = _services.GetTransformationUnitsAsync()
                                     .Where(x => x.Original.Contains(search) || x.Translation.Contains(search));
            return View(filtered);
        }

        [HttpGet]

        public IActionResult Details(int id)
        {
            var res = _services.GetById(id);
            return View(res);
        }

        [HttpGet]

        public IActionResult Create(int? id) 
        {
            if (id==null)
            {
                return View(new TransformationUnit());

            }
            else
            {
                var unit = _services.GetById((int)id);
                return View(unit);
            }
        }

        [HttpPost]
        public IActionResult Create(TransformationUnit unit)
        {
            if (ModelState.IsValid)
            {
                if (unit.Id > 0)
                {
                    _services.UpdateUnit(unit);
                    return RedirectToAction("Details", new { id = unit.Id }); ;
                }
                _services.CreateUnit(unit);
                return RedirectToAction("Details", new { id = unit.Id }); ;
            }
            return View(unit);
        }

        public IActionResult Delete(int id )
        {
            var res = _services.DeleteUnit(id);
            if (res!=true)
            {
                return NotFound();
            }
            return RedirectToAction("Index");
        }

        private IEnumerable<TransformationUnit> Filter(IEnumerable<string> values)
        {
            List<TransformationUnit> res = new List<TransformationUnit>();
            if (values.Contains("option1"))
            {
                var formal = _services.GetTransformationUnitsAsync().Where(x => x.FormalFonLevel != null
                                                                            | x.FormalLekLevel != null
                                                                            | x.FormalMorfLevel != null
                                                                            | x.FormalSlovLevel != null
                                                                            | x.FormalSyntLevel != null);
                res.AddRange(formal);
            }
            if (values.Contains("option2"))
            {
                var context = _services.GetTransformationUnitsAsync().Where(x => x.ContextFonLevel != null
                                                                           | x.ContextLekLevel != null
                                                                           | x.ContextMorfLevel != null
                                                                           | x.ContextSyntLevel != null);
                res.AddRange(context);
            }
            if (values.Contains("option3"))
            {
                var pragmal = _services.GetTransformationUnitsAsync().Where(x => x.PragmalAxTransformation != null
                                                                           | x.PragmalKoncTransformation != null
                                                                           | x.PragmalMegTransformation != null
                                                                           | x.PragmalPragmalFraTtransformation != null);
                res.AddRange(pragmal);
            }
            return res.AsEnumerable();
        }
    }
}
