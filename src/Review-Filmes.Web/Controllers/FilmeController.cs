using Microsoft.AspNetCore.Mvc;
using Review_Filmes.Domain.Models;
using Review_Filmes.Web.Entity.DTO;
using ReviewFilmes.Api.Entity;

namespace Review_Filmes.Web.Controllers
{
	public class FilmeController : Controller
	{

		private readonly ILogger<FilmeController> _logger;
		private readonly AppDbContext _context;

		public FilmeController(ILogger<FilmeController> logger, AppDbContext context)
		{
			_logger = logger;
			this._context = context;
		}

		public IActionResult Index()
		{
			return View();
		}


		//[HttpGet]
		//public IEnumerable<Filme> Get()
		//{
		//    var resultado = this._context.Filmes.ToList();
		//    return resultado;
		//}

		[HttpGet("filme/{id}", Name = "GetFilme")]
		public IActionResult Get(int id)
		{
			var filme = this._context.Filmes.Where(i => i.FilmeId == id).SingleOrDefault();

			if (filme != null)
			{
				filme.Reviews = this._context.Reviews.Where(i => i.FilmeId == id).ToList();
			}

			FilmeReview filmeReview = new FilmeReview();
			filmeReview.Filme = filme;
			filmeReview.FilmeID = filme.FilmeId;

			return View(filmeReview);
		}

		[HttpPost("filme", Name = "AddReview")]
		[AutoValidateAntiforgeryToken]
		public IActionResult AddReview([FromForm] FilmeReview review)
		{
			Filme filme = this._context.Filmes.Where(i => i.FilmeId == review.FilmeID).SingleOrDefault();

			if (filme != null)
			{
				filme.AddReview(new Review(review.FilmeID, review.Nome, review.Avaliacao));
				this._context.SaveChanges();
			}

			return RedirectToAction(actionName: "Get", controllerName: "Filme", new { id = review.FilmeID });
		}
	}

}
