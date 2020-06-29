using DataAccess.Clases;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class modProducto
    {
        clasProducto ObjetoDato = new clasProducto();
        public DataTable modListadoProducto()
        {
            return ObjetoDato.listadoProducto();
        }
        public void modInsertarProducto(entProducto obj)
        {
            ObjetoDato.insertarProducto(obj);
        }
        public void modEditarProducto(entProducto obj)
        {
            ObjetoDato.editarProducto(obj);
        }
        public void modEliminarProducto(string codigo)
        {
            ObjetoDato.eliminarProducto(codigo);
        }
        public DataTable modBuscarProducto(string buscar)
        {
            return ObjetoDato.buscarProducto(buscar);
        }
        public bool modExisteProducto(string documento)
        {
            return ObjetoDato.existeProducto(documento);
        }


    }
}
