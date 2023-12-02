using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class Prestito
    {
        public string Numero { get; set; }
        public DateTime Da { get; set; }
        public DateTime A { get; set; }
        public Utente Utente { get; set; }
        public Documento Documento { get; set; }
    }
}
