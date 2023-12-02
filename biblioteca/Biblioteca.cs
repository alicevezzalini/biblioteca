using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class Biblioteca
    {
        public string Nome { get; set; }
        public List<Utente> Utenti { get; set; }
        public List<Prestito> Prestiti { get; set; }
        public List<Documento> Documenti { get; set; }
    }
}
