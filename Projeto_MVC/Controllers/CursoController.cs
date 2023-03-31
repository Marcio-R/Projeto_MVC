using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_MVC.Data;
using Projeto_MVC.Models;

namespace Projeto_MVC.Controllers
{
    public class CursoController : Controller
    {
        private readonly Projeto_MVCContext _context;

        public CursoController(Projeto_MVCContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var cursos = await _context.Curso.ToListAsync();
            return View(cursos);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Curso curso)
        {
            try
            {
                if (curso == null)
                {
                    return NotFound();
                }
                await _context.AddAsync(curso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
