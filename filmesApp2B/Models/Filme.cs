using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmesApp2B.Models
{
    public class Filme
    {
        private int id;
        private string nome;
        private int anoLancamento;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int AnoLancamento { get => anoLancamento; set => anoLancamento = value; }

        public virtual List<Ator> atores { get; set; }

        public Filme()
        {
            nome = "";
            atores = new List<Ator>();
        }
    }
}
