using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Filmes.Domain.Models
{
    public class Filme
    {
        public Filme()
        {

        }

        public int FilmeId { get; set; }
        public string Titulo { get; set; }
        public string Resumo { get; set; }
        public string Lancamento { get; set; }
        public string Categoria { get; set; }
        public string Elenco { get; set; }
        public string Direcao { get; set; }
        public virtual List<Review> Reviews { get; set; } = new List<Review>();
        public string Slide { get; set; }
        public string Thumb { get; set; }

        public void AddReview(Review review)
        {
            Reviews.Add(review);
        }
    }
}
