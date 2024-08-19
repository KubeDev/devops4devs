using Microsoft.AspNetCore.Mvc.RazorPages;
using Review_Filmes.Domain.Models;

namespace Review_Filmes.Web.Entity.DTO
{
	public class FilmeReview 
	{
		public FilmeReview()
		{
			this.Filme = new Filme();
		}
		public Filme Filme { get; set; }

        public int FilmeID { get; set; }
        public string Nome { get; set; }
		public string Avaliacao { get; set; }

	}
}
