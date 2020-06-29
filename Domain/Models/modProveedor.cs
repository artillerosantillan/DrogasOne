using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Clases;

namespace Domain.Models
{
    
    public class modProveedor
    {
        clasProveedor ObjetoDato = new clasProveedor();
        public DataTable modListadoProveedor()
        {
            return ObjetoDato.listadoProveedor();
        }
        public void modInsertarProveedor(entProveedor obj)
        {
            ObjetoDato.insertarProveedor(obj);
        }
        public void modEditarProveedor(entProveedor obj)
        {
            ObjetoDato.editarProveedor(obj);
        }
        public void modEliminarProveedor(int codigo)
        {
            ObjetoDato.eliminarProveedor(codigo);
        }
        public DataTable modBuscarProveedor(string buscar)
        {
            return ObjetoDato.buscacProveedor(buscar);
        }
        public bool modExisteProveedor(string documento)
        {
            return ObjetoDato.existeProveedor(documento);
        }


    }
}
