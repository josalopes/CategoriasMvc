using CategoriasMvc.Models;
using CategoriasMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace CategoriasMvc.Controllers
{
    public class CategoriasController1 : Controller
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriasController1(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        public async Task<ActionResult<IEnumerable<CategoriaViewModel>>> Index()
        {
            var result = await _categoriaService.GetCategorias();

            if (result == null)
            {
                return View("Error");
            }
            return View(result);
        }
    }
}
