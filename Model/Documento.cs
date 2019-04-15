using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Documento
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string ConteudoDocumento { get; set; }
        public List<Documento> ListaDocumentos { get; set; }
    }
}
