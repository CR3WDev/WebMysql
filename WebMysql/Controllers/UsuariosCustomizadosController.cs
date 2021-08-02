using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMysql.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace WebMysql.Controllers
{
    public class UsuariosCustomizadosController : Controller
    {
        private readonly Contexto _context;

        public UsuariosCustomizadosController(Contexto contexto)
        {
            _context = contexto;
        }
        public async Task<IActionResult> Index()
        {

            var listaRetorno = await _context.UsuarioCustomizado
                .FromSqlRaw("CALL UsuariosCustomizados").ToListAsync();

            return View(listaRetorno);
        }

        public async Task<IActionResult> Details(int? id)
        {
            var param = new MySqlParameter("id", id);
            var usuario = await _context.UsuarioCustomizado
                .FromSqlRaw("CALL ObterUsuariosCustomizados(@id)", param).ToListAsync();

            if (usuario == null)
                return NotFound();


            return View(usuario.FirstOrDefault());
        }
    }
}
