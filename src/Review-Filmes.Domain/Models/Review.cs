using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Filmes.Domain.Models
{
    public class Review
    {
       private Review()
            		{
		}   

        public Review(int filmeID, string nome, string descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.FilmeId = filmeID;
        }
        public int ReviewId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int FilmeId { get; set; }
    }
}
