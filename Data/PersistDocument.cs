using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.Entity;

namespace Data
{
    public class PersistDocument
    {
        public void SalvarDocumento(Documento documento)
        {
            using (DataContext con = new DataContext())
            {
                if (documento.Titulo != null)
                {
                    int i = documento.Id;
                    documento = con.Documentos.Find(i);

                    con.Documentos.Add(documento);
                    con.SaveChanges();
                }
                else
                {
                    con.Documentos.Add(documento);
                    con.SaveChanges();
                }
            }
        }

        public List<Documento> ListarDocumentos()
        {
            using (var context = new DataContext())
            {
                var Documents = context.Documentos.Include(i => i.ListaDocumentos).ToList();

                return Documents;
            }
        }

        public List<Documento> ListarDocumentos(string s)
        {
            using (var context = new DataContext())
            {
                var Documents = context.Documentos.Include(i => i.ListaDocumentos).First(x => x.Titulo == s);
                //List<Documento> list = Documents.ToList<Documento>();
                //return Documents;
                return null;
            }
        }

        public Documento ConsultarPorNome(string nome)
        {
            using (DataContext con = new DataContext())
            {
                var Consulta = con.Documentos.Include(e => e.ListaDocumentos).First(x => x.Titulo == nome);
                Documento doc = (Documento)Consulta;
                return doc;
            }
        }
    }
}
