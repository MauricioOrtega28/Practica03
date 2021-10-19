using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practica03.Models;
using Practica03.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Practica03.Controllers
{
    public class SolicitudController: Controller
    {
        private readonly ApplicationDbContext _context;

        public SolicitudController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Registro(){

            var Categorias = _context.DataCategorias.ToList();
            
             List<SelectListItem> items = Categorias.ConvertAll(d => {
                return new SelectListItem(){
                    Text = d.Nombre,
                    Value = d.Id.ToString(),
                    Selected = false
                };
            });
          
           ViewBag.items = items;

           return View();
        }

        [HttpPost]
        public IActionResult Registro(Solicitud solicitud, int datos){
            
            if(ModelState.IsValid){
                
                var categoria = _context.DataCategorias.Find(datos);
                solicitud.categoria = categoria;
                _context.Add(solicitud);
                _context.SaveChanges();
                return RedirectToAction("Listar");
            }
            
            var Categorias = _context.DataCategorias.ToList();
            
             List<SelectListItem> items = Categorias.ConvertAll(d => {
                return new SelectListItem(){
                    Text = d.Nombre,
                    Value = d.Id.ToString(),
                    Selected = false
                };
            });
          
           ViewBag.items = items;

            return View(solicitud);
        }

        public IActionResult Listar(){

           var Fecha = DateTime.Now;
            var Dia = Fecha.Day - 5;
            var Mes = Fecha.Month;
            var Año = Fecha.Year;
            var solicitudes = _context.DataSolicitudes.Include(s => s.categoria).Where(b => b.Fecha.Day >= Dia && b.Fecha.Month == Mes && b.Fecha.Year == Año).ToList();

            return View(solicitudes);

        }
    }
}