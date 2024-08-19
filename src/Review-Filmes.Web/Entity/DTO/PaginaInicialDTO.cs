using Review_Filmes.Domain.Models;

namespace Review_Filmes.Web.Entity.DTO
{
	public class PaginaInicialDTO
	{
		public PaginaInicialDTO(IEnumerable<Filme> filmes, IEnumerable<Filme> carrossel)
		{
			this.Filmes = filmes;
			this.Carrossel = carrossel;
		}
		public IEnumerable<Filme> Filmes { get; set; }
		public IEnumerable<Filme> Carrossel { get; set; }

	}
}


