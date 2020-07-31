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
  public  class modDepositoProducto
    {
        clasDepositoProducto ObjetoDato = new clasDepositoProducto();
        public DataTable modListarDepositoProducto(string codigo)
        {
            return ObjetoDato.listadoDepositoProducto(codigo);
        }
        public decimal modObtenerStockDepositoProducto(string CodigoProducto, int CodigoDeposito)
        {
            return ObjetoDato.obtenerStockDepositoProducto(CodigoProducto, CodigoDeposito);
        }
        public void aumentarStockDepositoProducto(string IDProducto, int IDDeposito, decimal Cantidad)
        {
            ObjetoDato.aumentar_Stock_Deposito_Producto(IDProducto, IDDeposito, Cantidad);
        }
        public void restarStockDepositoProducto(string IDProducto, int IDDeposito, decimal Cantidad)
        {
            ObjetoDato.restar_Stock_DepositoProducto(IDProducto, IDDeposito, Cantidad);
        }
        public void mod_Insertar_Deposito_Producto(entDepositoProducto obj)
        {
            ObjetoDato.insertarDepositoProducto(obj);
        }
        public void modEliminar_Codigo_Deposito_Producto(string codigo)
        {
            ObjetoDato.eliminar_Codigo_Deposito_Producto(codigo);
        }
        public decimal devolver_Stock_DepositoProducto(int IDDeposito, String IDProducto)
        {
            return ObjetoDato.devolver_Stock_DepositoProducto(IDDeposito, IDProducto);
        }
    }
}
