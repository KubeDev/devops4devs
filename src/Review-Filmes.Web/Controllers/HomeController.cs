using Microsoft.AspNetCore.Mvc;
using Review_Filmes.Web.Entity.DTO;
using Review_Filmes.Web.Models;
using ReviewFilmes.Api.Entity;
using System.Diagnostics;

namespace Review_Filmes.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly AppDbContext _context;

		public HomeController(ILogger<HomeController> logger, AppDbContext context)
		{
			_logger = logger;
			this._context = context;
		}

		public IActionResult Index()
		{
			var resultado = this._context.Filmes.ToList();
			var carrossel = resultado.Take(5);
			return View(new PaginaInicialDTO(resultado, carrossel));
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
