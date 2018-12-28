using Controllers.Repositorios;
using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class DentistaService : IDentista
    {
        private DentistaRep rep = new DentistaRep();
        
        public void Cadastrar(Dentista obj)
        {
            rep.Cadastrar(obj);
        }

        public Dentista Buscar(int id)
        {
            return rep.Buscar(id);
        }

        public List<Dentista> Listar()
        {
            return rep.Listar();
        }

        public void Deletar(int id)
        {
            rep.Deletar(id);
        }
        
        public void Editar(Dentista objNovo)
        {
            rep.Editar(objNovo);
        }
    }
}
