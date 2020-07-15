using DataAccess.Clases;
using DataAccess.Entities;
using Domain.Models;
using Domain.Models.Movimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Movimientos
{
    public partial class frmCompras : Form
    {
        //creamos un atributo generico llamado misDetalle
        List<entDetalleCompra> misDetalle = new List<entDetalleCompra>(); // se crea una lista vacia
        entProducto ultimoProducto = null; //verifica ultimo producto agregado el detalleDatagridView

        modProveedor objModeloPro = new modProveedor();
        private decimal Total = 0;
        public frmCompras()
        {
            InitializeComponent();
        }
        private void frmCompras_Load(object sender, EventArgs e)
        {
            ListarProveedor();
            ListarDeposito();
            entradaProductodataGridView.DataSource = misDetalle;
            PersonalizarGrid();

        }
        //-----------------------Listar Deposito en ComboBox -----------------------
        public void ListarDeposito()
        {
            modDeposito objProd = new modDeposito();
            depositoComboBox.DataSource = objProd.modListaDeposito();
            depositoComboBox.DisplayMember = "Descripcion";
            depositoComboBox.ValueMember = "IDDeposito";
        }
        //-----------------------Listar Proveedor en ComboBox ----------------------
        public void ListarProveedor()
        {
            modProveedor objProd = new modProveedor();
            proveedorComboBox.DataSource = objProd.modListadoProveedor();
            proveedorComboBox.DisplayMember = "Descripcion";
            proveedorComboBox.ValueMember = "IDProveedor";
        }
        //-----------------------Busqueda Proveedor -----------------------------------
        private void busquedaProveedorButton_Click(object sender, EventArgs e)
        {
            frmBusquedaProveedor miBusqueda = new frmBusquedaProveedor();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDProveedor == 0) return;
            proveedorComboBox.SelectedValue = miBusqueda.IDProveedor;
        }
        //-----------------------Busqueda Producto ----------------------------------
        private void busquedaProductoButton_Click(object sender, EventArgs e)
        {
            frmBusquedaProducto miBusqueda = new frmBusquedaProducto();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDProducto == null) return;
            productoTextBox.Text = miBusqueda.IDProducto;
            productoTextBox_Validating(sender, new CancelEventArgs());//dispara el evento para que busque y muestre automaticaent en el label
        }
        //-----------------------Validar Producto buscado ----------------------------------
        private void productoTextBox_Validating(object sender, CancelEventArgs e)
        {

            if (productoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(productoTextBox, "Debe ingresar un Código de producto");
                return;
            }
            errorProvider1.Clear();

            entProducto meProducto = new entProducto();// se crea un entidad producto
            modProducto miProducto = new modProducto();//creamos el modelo producto
            meProducto = miProducto.getProducto(productoTextBox.Text); //llamamos a la clase getProdicto con el codigo de producto

            if (meProducto == null)
            {
                errorProvider1.SetError(productoTextBox, "El Producto no Existe");
                productoLabel.Text = string.Empty;
                ultimoProducto = null;
            }
            else
            {

                productoLabel.Text = meProducto.Descripcion + " " + meProducto.IDUnidadManejo + ".";
                //si el producto existe producto es igual mi producto
                ultimoProducto = meProducto;


            }
        }

        private void agregarBunifuFlatButton_Click(object sender, EventArgs e)
        {
            // -----------Validacion---------------
            if (ultimoProducto == null)
            {
                errorProvider1.SetError(productoTextBox, "Debe ingresar un producto");
                productoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (cantidadTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(cantidadTextBox, "Debe ingresar una cantidad de productos");
                cantidadTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            int cantidad;

            if (!int.TryParse(cantidadTextBox.Text, out cantidad))
            {
                errorProvider1.SetError(cantidadTextBox, "Debe ingresar un valor numerico entero");
                cantidadTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (cantidad <= 0)
            {
                errorProvider1.SetError(productoTextBox, "Debe ingresar un valor numerico mayor a cero");
                cantidadTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (costoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(costoTextBox, "Debe ingresar una cantidad de productos");
                costoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            decimal costo;

            if (!decimal.TryParse(costoTextBox.Text, out costo))
            {
                errorProvider1.SetError(costoTextBox, "Debe ingresar un valor numerico entero");
                costoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (costo <= 0)
            {
                errorProvider1.SetError(costoTextBox, "Debe ingresar un valor numerico mayor a cero");
                costoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (fechaVencimientoDateTimePicker.Text == string.Empty)
            {
                errorProvider1.SetError(fechaVencimientoDateTimePicker, "Debe ingresar una la expiracion del producto");
                return;
            }
            errorProvider1.Clear();

            if (loteTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(loteTextBox, "Debe ingresar el lote  del productos");
                costoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            // -----------Validacion fin ---------------

            // recuperamos el objeto IVA para calcular el porcentaje iva
            entIVA miIVA = new entIVA();
            modIVA IVA = new modIVA();
            miIVA = IVA.getIVA(ultimoProducto.IDIVA);

            //Creamo objeto miDetalle para cargar con valores
            entDetalleCompra miDetalle = new entDetalleCompra();
            miDetalle.Cantidad = cantidad;
            miDetalle.Costo = costo;
            miDetalle.Descripcion = ultimoProducto.Descripcion;
            miDetalle.IDUnidadManejo = ultimoProducto.IDUnidadManejo;
            miDetalle.IDProducto = ultimoProducto.IDProducto;
            miDetalle.FechaVencimiento = fechaVencimientoDateTimePicker.Value;
            miDetalle.Lote = loteTextBox.Text;
            //calculamos el IVA a particar del objeto obtenido miIVA
            miDetalle.PorcentajeIVA = miIVA.Tarifa / 100;
            //Sumamos el Total 
            Total += miDetalle.ValorNeto;
            //adicionamos a misdetalles el nuevo producto midetalle
            misDetalle.Add(miDetalle);
            //refrescamos el datagritview
            RefrescaGrid();
            //----inicializamos o blanqueamos los textbox--------
            ultimoProducto = null;
            productoTextBox.Text = string.Empty;
            cantidadTextBox.Text = string.Empty;
            costoTextBox.Text = string.Empty;
            loteTextBox.Text = string.Empty;
            // le damos foco producto para iniciar de nuevo
            productoTextBox.Focus();

        }
        //--------------------Refrescamos el datagrid----------------------
        private void RefrescaGrid()
        {
            entradaProductodataGridView.DataSource = null;
            entradaProductodataGridView.DataSource = misDetalle;//carga el datagrit nuevamente con los nuevos valores
            errorProvider1.Clear();
            Total = 0; //inicilizamos el total en cero
            productoLabel.Text = string.Empty;//limpiamos 

            foreach (entDetalleCompra miDetalle in misDetalle)
            {

                Total += miDetalle.ValorNeto;
            }

            totalTextBox.Text = string.Format("{0:C2}", Total);//mostramos el nuevo valor  de  Total.
            PersonalizarGrid();
        }

        //--------------------Personalizacioin del datagrid----------------------
        private void PersonalizarGrid()
        {
            entradaProductodataGridView.Columns["IDProducto"].HeaderText = "Cod";
            entradaProductodataGridView.Columns["IDProducto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            entradaProductodataGridView.Columns["IDProducto"].Width = 50;

            entradaProductodataGridView.Columns["Descripcion"].HeaderText = "Descripción";
            entradaProductodataGridView.Columns["Descripcion"].Width = 200;

            entradaProductodataGridView.Columns["IDUnidadManejo"].HeaderText = "U.M.";
            entradaProductodataGridView.Columns["IDUnidadManejo"].Width = 50;

            entradaProductodataGridView.Columns["Costo"].HeaderText = "P.U.";
            entradaProductodataGridView.Columns["Costo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            entradaProductodataGridView.Columns["Costo"].DefaultCellStyle.Format = "C2";
            entradaProductodataGridView.Columns["Costo"].Width = 80;


            entradaProductodataGridView.Columns["Cantidad"].HeaderText = "Cantidad";
            entradaProductodataGridView.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            entradaProductodataGridView.Columns["Cantidad"].DefaultCellStyle.Format = "N2"; //numerico con 2 decimales
            entradaProductodataGridView.Columns["Cantidad"].Width = 80;


            entradaProductodataGridView.Columns["Lote"].HeaderText = "Lote";
            entradaProductodataGridView.Columns["Lote"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            entradaProductodataGridView.Columns["Lote"].Width = 100;

            entradaProductodataGridView.Columns["FechaVencimiento"].HeaderText = "Expiración";
            entradaProductodataGridView.Columns["FechaVencimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            entradaProductodataGridView.Columns["FechaVencimiento"].Width = 120;

            entradaProductodataGridView.Columns["PorcentajeIVA"].HeaderText = "IVA";
            entradaProductodataGridView.Columns["PorcentajeIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            entradaProductodataGridView.Columns["PorcentajeIVA"].DefaultCellStyle.Format = "P2"; //numerico con 2 decimales
            entradaProductodataGridView.Columns["PorcentajeIVA"].Width = 50;

            entradaProductodataGridView.Columns["ValorIVA"].HeaderText = "Valor IVA";
            entradaProductodataGridView.Columns["ValorIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            entradaProductodataGridView.Columns["ValorIVA"].DefaultCellStyle.Format = "C2"; //numerico con 2 decimales
            entradaProductodataGridView.Columns["ValorIVA"].Width = 80;

            entradaProductodataGridView.Columns["ValorNeto"].HeaderText = "Total";
            entradaProductodataGridView.Columns["ValorNeto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            entradaProductodataGridView.Columns["ValorNeto"].DefaultCellStyle.Format = "C2"; //porcentaje con 2 decimales
            entradaProductodataGridView.Columns["ValorNeto"].Width = 80;
        }

        private void grabarDetalleCompraBunifuFlatButton_Click(object sender, EventArgs e)
        {
            //-------------------------Validacion--------------------
            if (depositoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(depositoComboBox, "debe seleccionar una Bodega");
                depositoComboBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (numFacturaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(numFacturaTextBox, "debe introducir el numero de factura");
                numFacturaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (proveedorComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(proveedorComboBox, "debe seleccionar un Proveedor");
                proveedorComboBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (numConvocatoriaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(numConvocatoriaTextBox, "debe introducir el numero de Coonvocatoria");
                numConvocatoriaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (laboratorioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(laboratorioTextBox, "debe introducir el Laboratorio");
                laboratorioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (numDocEntradaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(numDocEntradaTextBox, "debe introducir el Numero de entrada compra");
                numDocEntradaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (numPedidoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(numPedidoTextBox, "debe introducir el Numero de pedido");
                numPedidoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (liquidacionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(liquidacionTextBox, "debe introducir la liquidacion");
                liquidacionTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (ProcedenciaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ProcedenciaTextBox, "debe introducir la procedencia");
                ProcedenciaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (notaEntradaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(notaEntradaTextBox, "debe introducir la nota  de entrada compra");
                notaEntradaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (misDetalle.Count == 0)
            {
                errorProvider1.SetError(productoTextBox, "debe ingresar productos en el ingreso de compra");
                productoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            //--------------------Validacion fin --------------------

            DialogResult rta = MessageBox.Show("Esta seguro de querer grabar la compra?",
                "confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;

            //Entidad Cabecera Compra
            entCompra cabecera_compra = new entCompra();
            cabecera_compra.Fecha = fechaIngresoDateTimePicker.Value;
            cabecera_compra.IDProveedor =(int)proveedorComboBox.SelectedValue;
            cabecera_compra.IDDeposito = (int)depositoComboBox.SelectedValue;
            cabecera_compra.NumFactura = numFacturaTextBox.Text;
            cabecera_compra.NumConvocatoria = numConvocatoriaTextBox.Text;
            cabecera_compra.Laboratorio = laboratorioTextBox.Text;
            cabecera_compra.NumPedido = numPedidoTextBox.Text;
            cabecera_compra.Liquidacion = liquidacionTextBox.Text;
            cabecera_compra.Procedencia = ProcedenciaTextBox.Text;
            cabecera_compra.Nota = notaEntradaTextBox.Text;
            cabecera_compra.CostoTotal =(decimal)Total;
            // -----1ro Insertamos Compra en BD 
            modCompra mod_insertar_compra = new modCompra();
            int obtener_ultimo_idcompra = mod_insertar_compra.modInsertarCompra(cabecera_compra);

            // -----2do Insertamos DetalleCompra en BD
            foreach (entDetalleCompra miDetalle in misDetalle)
            {
                modDepositoProducto obtener_stock_DepositoProducto = new modDepositoProducto();
                int stock = obtener_stock_DepositoProducto.modObtenerStockDepositoProducto(miDetalle.IDProducto, cabecera_compra.IDDeposito);
                if (stock == 0)
                {
                    //realiza un insert en DepositoProducto 
                    entDepositoProducto datos_deposito_producto = new entDepositoProducto();

                    datos_deposito_producto.IDDeposito = cabecera_compra.IDDeposito;
                    datos_deposito_producto.IDProducto = miDetalle.IDProducto;
                    datos_deposito_producto.Stock = miDetalle.Cantidad;
                    datos_deposito_producto.Minimo = 1;
                    datos_deposito_producto.Maximo = 1;
                    datos_deposito_producto.DiasReposicion = 1;
                    datos_deposito_producto.CantidadMinima = 1;

                    obtener_stock_DepositoProducto.modInsertarDepositoProducto(datos_deposito_producto);
                }
                // si el producto tiene saldo stock se lo suma la cantidad nueva
                obtener_stock_DepositoProducto.modActualizarStockDepositoProducto(miDetalle.IDProducto, cabecera_compra.IDDeposito, miDetalle.Cantidad);

            //    int IDKardex;
            //    float nuevoSaldo;
            //    decimal nuevoCostoPromedio;
            //    decimal nuevoUltimoCosto;

            //    if (miKardex == null)
            //    {
            //        nuevoSaldo = miDetalle.Cantidad;
            //        //costo con descuento
            //        nuevoCostoPromedio = miDetalle.ValorNeto / (decimal)miDetalle.Cantidad;
            //        nuevoUltimoCosto = nuevoCostoPromedio;
            //    }
            //    else
            //    {
            //        nuevoSaldo = miKardex.Saldo + miDetalle.Cantidad;
            //        nuevoCostoPromedio =
            //            (miKardex.CostoPromedio * (decimal)miKardex.Saldo +
            //            miDetalle.ValorNeto) / (decimal)nuevoSaldo;
            //        nuevoUltimoCosto = miDetalle.ValorNeto / (decimal)miDetalle.Cantidad;
            //    }
            //    // insertamos el nuevo Kardex
            //    IDKardex = CADKardex.InsertKardex(IDDeposito, miDetalle.IDProducto, fecha,
            //        string.Format("AF-0{0}", IDCompra), miDetalle.Cantidad, 0, nuevoSaldo,
            //        nuevoUltimoCosto, nuevoCostoPromedio);

            //    //---4to Actualizamos CompraDetalle
            //    CADCompraDetalle.InsertCompraDetalle(IDCompra, miDetalle.IDProducto,
            //       miDetalle.Descripcion, miDetalle.Costo, miDetalle.Cantidad, miDetalle.Lote, miDetalle.FechaVencimiento,
            //        IDKardex, miDetalle.PorcentajeIVA, miDetalle.PorcentajeDescuento);
            }

            MessageBox.Show(string.Format("La compra: {0}, fue grabada de forma exito", obtener_ultimo_idcompra),
                  "confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        
    }
}
