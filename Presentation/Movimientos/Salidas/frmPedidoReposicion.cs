using Common.Clases;
using DataAccess.Entities;
using DataAccess.Entities.Modulos;
using DataAccess.Entities.Movimientos;
using DataAccess.Entities.Movimientos.Salidas;
using Domain.Models;
using Domain.Models.Movimientos;
using Domain.Models.Movimientos.Salidas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Movimientos.Salidas
{
    public partial class frmPedidoReposicion : Form
    {
        entProducto ultimoProducto = null; //verifica ultimo producto agregado el detalleDatagridView
        List<entDetallePedidoReposicion> misDetallesPedidoReposicion = new List<entDetallePedidoReposicion>(); // se crea una lista vacia
        private decimal Total = 0;
        public frmPedidoReposicion()
        {
            InitializeComponent();
        }
        private void frmPedidoReposicion_Load(object sender, EventArgs e)
        {
            Enumerar_Num_Pedido_Reposicion();
            Listar_Deposito_ComboBox();
            Listar_Centros_Salud_ComboBox();
        }
        public void Enumerar_Num_Pedido_Reposicion()
        {
            modPedidoReposicion objeto_Pedido_Reposicion = new modPedidoReposicion();//creamos el modelo producto
            int ultimo_Id_Pedido_Reposicion = objeto_Pedido_Reposicion.ultimo_Id_Pedido_Reposicion();
            ultimo_Id_Pedido_Reposicion = ultimo_Id_Pedido_Reposicion + 1;
            numDocumentoReposicionLabel.Text = "N˚- 0" + ultimo_Id_Pedido_Reposicion;
        }
        public void Listar_Deposito_ComboBox()
        {
            modDeposito objeto_Deposito = new modDeposito();
            depositoComboBox.DataSource = objeto_Deposito.modListaDeposito();
            depositoComboBox.DisplayMember = "Descripcion";
            depositoComboBox.ValueMember = "IDDeposito";
        }
        public void Listar_Centros_Salud_ComboBox()
        {
            modCentroSalud Objeto_Centro_Salud = new modCentroSalud();
            centroSaludComboBox.DataSource = Objeto_Centro_Salud.listar_Centros_De_Salud();
            centroSaludComboBox.DisplayMember = "NombreCentroSalud";
            centroSaludComboBox.ValueMember = "IDCentroSalud";
        }
        //-----------------------Busqueda Centro Salud -----------------------------------
        private void busquedaCentroSaludButton_Click(object sender, EventArgs e)
        {
            frmBusquedaCentroSalud miBusqueda = new frmBusquedaCentroSalud();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDCentroSalud == 0) return;
            centroSaludComboBox.SelectedValue = miBusqueda.IDCentroSalud;
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

        private void productoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (productoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(productoTextBox, "Debe ingresar un Código de producto");
                return;
            }
            errorProvider1.Clear();

            entProducto objeto_Entidad_Producto = new entProducto();// 
            modProducto objeto_Producto = new modProducto();//creamos el modelo producto
            objeto_Entidad_Producto = objeto_Producto.getProducto(productoTextBox.Text); //llamamos a la clase getProdicto con el codigo de producto

            if (objeto_Entidad_Producto == null)
            {
                errorProvider1.SetError(productoTextBox, "El Producto no Existe");
                productoLabel.Text = string.Empty;
                ultimoProducto = null;
            }
            else
            {
                productoLabel.Text = objeto_Entidad_Producto.Descripcion + " " + objeto_Entidad_Producto.IDUnidadManejo + ".";
                //si el producto existe producto es igual mi producto
                ultimoProducto = objeto_Entidad_Producto;
                modDepositoProducto objeto_Deposito_Producto = new modDepositoProducto();
                //modDeposito objetoDeposito = new modDeposito();
                //int id_deposito_por_nombre = objetoDeposito.devolver_Id_Deposito(depositoComboBox.Text);
                decimal obtener_stock = objeto_Deposito_Producto.devolver_Stock_DepositoProducto((int)depositoComboBox.SelectedValue,productoTextBox.Text);
                stockProductoTextBox.Text = " " + obtener_stock + " ";

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

            for (int i = 0; i < misDetallesPedidoReposicion.Count; i++)
            {
                if (misDetallesPedidoReposicion[i].IDProducto == productoTextBox.Text)
                {
                    errorProvider1.SetError(productoTextBox, "El producto ya se ingreso");
                    productoTextBox.Focus();
                    return;
                }
            }

            errorProvider1.Clear();
            if (cantidadTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(cantidadTextBox, "Debe ingresar una cantidad de productos");
                cantidadTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            decimal cantidad;

            if (!decimal.TryParse(cantidadTextBox.Text, out cantidad))
            {
                errorProvider1.SetError(cantidadTextBox, "Debe ingresar un valor numerico entero");
                cantidadTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (cantidad <= 0)
            {
                errorProvider1.SetError(cantidadTextBox, "Debe ingresar un valor numerico mayor a cero");
                cantidadTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (cantidad > Convert.ToDecimal(stockProductoTextBox.Text))
            {
                errorProvider1.SetError(cantidadTextBox, "La cantidad es mayor al Stock en Almacenes");
                cantidadTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            // -----------Validacion fin ---------------
            // recuperamos el objeto IVA para calcular el porcentaje iva
            entIVA miIVA = new entIVA();
            modIVA IVA = new modIVA();
            miIVA = IVA.getIVA(ultimoProducto.IDIVA);

            //Creamo objeto miDetallePedidoReposicion para cargar con valores
            entDetallePedidoReposicion miDetallePedidoReposicion = new entDetallePedidoReposicion();
            miDetallePedidoReposicion.IDProducto = ultimoProducto.IDProducto;
            miDetallePedidoReposicion.Descripcion = ultimoProducto.Descripcion;
            miDetallePedidoReposicion.IDUnidadManejo = ultimoProducto.IDUnidadManejo;
            //miDetallePedidoReposicion.Precio = ultimoProducto.Precio;
            miDetallePedidoReposicion.Cantidad = cantidad;
            misDetallesPedidoReposicion.Add(miDetallePedidoReposicion);
            RefrescaGrid();

        }
        private void RefrescaGrid()
        {
            salidaProductoDataGridView.DataSource = null;
            salidaProductoDataGridView.DataSource = misDetallesPedidoReposicion;//carga el datagrit nuevamente con los nuevos valores
            errorProvider1.Clear();
            Total = 0; //inicilizamos el total en cero
                       //----inicializamos o blanqueamos los textbox--------
            productoLabel.Text = string.Empty;
            ultimoProducto = null;
            productoTextBox.Text = string.Empty;
            cantidadTextBox.Text = string.Empty;
            stockProductoTextBox.Text = string.Empty;
            // le damos foco producto para iniciar de nuevo
            productoTextBox.Focus();

            PersonalizarGrid();
        }
        private void PersonalizarGrid()
        {
            salidaProductoDataGridView.Columns["IDProducto"].HeaderText = "Codigo Kardex";
            salidaProductoDataGridView.Columns["IDProducto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            salidaProductoDataGridView.Columns["IDProducto"].Width = 50;

            salidaProductoDataGridView.Columns["Descripcion"].HeaderText = "Descripción";
            salidaProductoDataGridView.Columns["Descripcion"].Width = 200;

            salidaProductoDataGridView.Columns["IDUnidadManejo"].HeaderText = "Unidad.";
            salidaProductoDataGridView.Columns["IDUnidadManejo"].Width = 50;

           
            salidaProductoDataGridView.Columns["Cantidad"].HeaderText = "Cantidad Repuesta";
            salidaProductoDataGridView.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            salidaProductoDataGridView.Columns["Cantidad"].DefaultCellStyle.Format = "N2"; //numerico con 2 decimales
            salidaProductoDataGridView.Columns["Cantidad"].Width = 80;
        }

        private void borrarLineaBunifuFlatButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (misDetallesPedidoReposicion.Count == 0) return;
            if (salidaProductoDataGridView.SelectedRows.Count == 0)
            {
                misDetallesPedidoReposicion.RemoveAt(misDetallesPedidoReposicion.Count - 1);
                RefrescaGrid();
            }
            else
            {
                string IDProducto = (string)salidaProductoDataGridView.SelectedRows[0].Cells[0].Value;
                for (int i = 0; i < misDetallesPedidoReposicion.Count; i++)
                {
                    if (misDetallesPedidoReposicion[i].IDProducto == IDProducto)
                    {
                        misDetallesPedidoReposicion.RemoveAt(i);
                        break;
                    }
                }
            }
            RefrescaGrid();
        }

        private void borrartodoDetalleCompraBunifuFlatButton_Click(object sender, EventArgs e)
        {
            if (misDetallesPedidoReposicion.Count == 0) return;
            DialogResult rta = MessageBox.Show(" Esta seguro de  borrar todas las lineas de La compra?",
                "confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            misDetallesPedidoReposicion.Clear();
            RefrescaGrid();
        }

        private void grabarDetalleCompraBunifuFlatButton_Click(object sender, EventArgs e)
        {
            //-------------------------Validacion--------------------
            if (depositoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(depositoComboBox, "debe seleccionar una Deposito");
                depositoComboBox.Focus();
                return;
            }
            errorProvider1.Clear();       

            if (centroSaludComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(centroSaludComboBox, "debe seleccionar un Proveedor");
                centroSaludComboBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (misDetallesPedidoReposicion.Count == 0)
            {
                errorProvider1.SetError(productoTextBox, "debe ingresar productos en el Pedido de Reposición");
                productoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            
            //--------------------Validacion fin --------------------

            DialogResult rta = MessageBox.Show("Esta seguro de querer grabar la compra?",
                "confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;

            int IDDeposito = (int)depositoComboBox.SelectedValue;
            //Entidad Cabecera Pedido Reposicion
            entPedidoReposicion entidad_Pedido_Reposicion = new entPedidoReposicion();
            entidad_Pedido_Reposicion.Fecha = fechaSalidaDateTimePicker.Value;
            entidad_Pedido_Reposicion.IDCentroSalud = (int)centroSaludComboBox.SelectedValue;
            entidad_Pedido_Reposicion.IDDeposito = IDDeposito;
            modPedidoReposicion objeto_Pedido_Reposicion = new modPedidoReposicion();
            // -----1ro Insertamos Pedido Reposicion en BD
            int obtener_ultimo_IDPedido_Reposicion = objeto_Pedido_Reposicion.insertar_Pedido_Reposicion(entidad_Pedido_Reposicion);
            // -----2do Insertamos y recorremos la lista PedidoReposicion
            foreach (entDetallePedidoReposicion miDetalle in misDetallesPedidoReposicion)
            {
                modDepositoProducto objeto_Deposito_Producto = new modDepositoProducto();
                // restamos la cantidad de reposicion a stock de DepositoProducto
                objeto_Deposito_Producto.restarStockDepositoProducto(miDetalle.IDProducto, IDDeposito, miDetalle.Cantidad);

                // 3ro actualizamos el Kardex, creamos un objeto miKardex que nos devuelve el ultimo kardex registrado
                entKardex miKardex = new entKardex();
                entKardex nuevoKardex = new entKardex();
                modKardex objeto_Kardex = new modKardex();
                miKardex = objeto_Kardex.devolver_Ultimo_Kardex(miDetalle.IDProducto, IDDeposito);

                int IDKardex;
                decimal nuevoSaldo;
                nuevoSaldo = miKardex.Saldo - miDetalle.Cantidad;
                
                // insertamos el nuevo Kardex
                nuevoKardex.IDDeposito = IDDeposito;
                nuevoKardex.IDProducto = miDetalle.IDProducto;
                nuevoKardex.Entidad = centroSaludComboBox.Text;
                nuevoKardex.Fecha = fechaSalidaDateTimePicker.Value;
                nuevoKardex.Documento = string.Format("N˚- 0{0}", obtener_ultimo_IDPedido_Reposicion);
                nuevoKardex.Entrada =0 ;
                nuevoKardex.Salida = miDetalle.Cantidad;
                nuevoKardex.Saldo = nuevoSaldo;
                IDKardex = objeto_Kardex.modInsertarKardex(nuevoKardex);

                //---4to Actualizamos CompraDetalle
                modPedidoReposicionDetalle objeto_Pedido_Reposicion_Detalle = new modPedidoReposicionDetalle();
                entPedidoReposicionDetalle entidad_Pedido_Reposicion_Detalle = new entPedidoReposicionDetalle();
                entidad_Pedido_Reposicion_Detalle.IDPedidoReposicion = obtener_ultimo_IDPedido_Reposicion;
                entidad_Pedido_Reposicion_Detalle.IDProducto = miDetalle.IDProducto;
                entidad_Pedido_Reposicion_Detalle.Descripcion = miDetalle.Descripcion;
                entidad_Pedido_Reposicion_Detalle.Cantidad = miDetalle.Cantidad;                
                entidad_Pedido_Reposicion_Detalle.IDKardex = IDKardex;
                objeto_Pedido_Reposicion_Detalle.insertar_Pedido_Reposicion(entidad_Pedido_Reposicion_Detalle);

                //---5to Actualizamos KardexPorVencimientoYLote
                modKardexPorVencimientoYLote objeto_Kardex_Por_Vencimiento_Y_Lote = new modKardexPorVencimientoYLote();
                bool Bandera = true;
                objeto_Kardex_Por_Vencimiento_Y_Lote.restar_Saldo_Kardex_Por_Vencimiento_Y_Lote(miDetalle.IDProducto,IDDeposito, miDetalle.Cantidad);

                while (Bandera == true)
                {
                    decimal saldo_Kardex_Por_Vencimiento_Y_Lote = objeto_Kardex_Por_Vencimiento_Y_Lote.devolver_Saldo_Kardex_Por_Vencimiento_Y_Lote(miDetalle.IDProducto, IDDeposito);
                    objeto_Kardex_Por_Vencimiento_Y_Lote.eliminar_Kardex_Por_Vencimiento_Y_Lote_Saldo_Cero();
                    if (saldo_Kardex_Por_Vencimiento_Y_Lote < 0)
                    {
                        saldo_Kardex_Por_Vencimiento_Y_Lote = saldo_Kardex_Por_Vencimiento_Y_Lote * -1;
                        objeto_Kardex_Por_Vencimiento_Y_Lote.restar_Saldo_Kardex_Por_Vencimiento_Y_Lote(miDetalle.IDProducto, IDDeposito, saldo_Kardex_Por_Vencimiento_Y_Lote);
                    }
                    else
                        Bandera = false;
                }
            }

            MessageBox.Show(string.Format("La compra: N˚- 0{0}, fue grabada de forma exito", obtener_ultimo_IDPedido_Reposicion),
                  "confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Total = 0;
            if (rta == DialogResult.No) return;
            //inicializamos los combox
            centroSaludComboBox.SelectedIndex = -1;
            //depositoComboBox.SelectedIndex = -1;
            //para que actualiza la hora cuando se inicialice
            fechaSalidaDateTimePicker.Value = DateTime.Now;
            misDetallesPedidoReposicion.Clear();
            RefrescaGrid();
            depositoComboBox.Focus();
            Enumerar_Num_Pedido_Reposicion();
        }
    }
}
