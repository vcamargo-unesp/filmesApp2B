using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmesApp2B.Models
{
    public class Ator
    {
        private int id;
        private string nome;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }

        public virtual List<Filme> filmes { get; set; }

        public Ator() {
            nome = "";
            filmes = new List<Filme>();
        }
    }
}
