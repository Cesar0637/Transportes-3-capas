using BLL;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Transportes_3_capas.Utilidades;
using VO;

namespace Transportes_3_capas.Catalogos.Rutas
{
    public partial class formulariosRutas : System.Web.UI.Page
    {
        public DateTime fecha_salida_global;
        public DateTime fecha_llegada_global;
        protected void Page_Load(object sender, EventArgs e)
        {
            //validar si es postback
            if (!IsPostBack)
            {
                cargar_dll();

                if (Request.QueryString["Id"] != null)
                {
                    //Voy a actualizar
                    int idruta = Convert.ToInt32(Request.QueryString["Id"]);


                    Rutas_VO _ruta = BLL_Rutas.get_Rutas("@Id_Ruta", idruta)[0];
                    //valido que realmente obtenga un objeto, de lo contrario me regreso al listado 
                    if (_ruta.Id_Ruta != 0)
                    {
                        Titulo.Text = "Actualizar Ruta";
                        Subtitulo.Text = $"Ruta #{idruta}";
                        ddlcamion.SelectedValue = _ruta.Camion_id.ToString();
                        dllchofer.SelectedValue = _ruta.Chofer_id.ToString();
                        ddlorigen.SelectedValue = _ruta.Direccion_Origen_Id.ToString();
                        ddldestino.SelectedValue = _ruta.Direccion_Destino_Id.ToString();
                        ddlcargamento.SelectedValue = _ruta.Cargamento_Id.ToString();
                        txtdistancia.Text = _ruta.Distancia.ToString();
                        calestimada.SelectedDate = DateTime.Parse(_ruta.Fecha_llegada_estimada);
                        calestimada.VisibleDate = DateTime.Parse(_ruta.Fecha_llegada_estimada);
                        lblestimada.Text = "Fecha estimada de LLegada: " + _ruta.Fecha_llegada_estimada;

                        calsalida.SelectedDate = DateTime.Parse(_ruta.Fecha_salida);
                        calsalida.VisibleDate = DateTime.Parse(_ruta.Fecha_salida);
                        lblestimada.Text = "Fecha de salida" + _ruta.Fecha_salida;

                    }
                    else
                    {

                    }
                }
                else
                {

                    //voi a aInsertar 
                    Titulo.Text = "Agregar Nueva Ruta";
                    Subtitulo.Text = "";

                    calsalida.SelectedDate = DateTime.Now.Date.AddDays(1);
                    calsalida.VisibleDate = DateTime.Now.Date.AddDays(1);
                    lblsalida.Text = "Fecha de Salida: " + DateTime.Now.Date.AddDays(1).ToShortDateString();
                    calestimada.SelectedDate = calsalida.SelectedDate.AddDays(4);
                    calestimada.VisibleDate = calsalida.SelectedDate.AddDays(4);
                    lblestimada.Text = "Fecha estimada de LLegada: " + calsalida.SelectedDate.AddDays(4).ToShortDateString();



                }
            }
        }


        protected void cargar_dll()
        {
            //ddlcamiones
            //creo un objeto de tipo 'ListItem' para agregarlo ala lista de elementos del ddl 
            //ListItem(valor_a_mostrar, valor guardar)
            ListItem ddlcamiones_I = new ListItem("Seleccione un camion", "0");
            ddlcamion.Items.Add(ddlcamiones_I);
            List<Camiones_VO> list_c = BLL_Camiones.get_Camiones("@Disponibilidad", true);
            if (list_c.Count > 0)
            {
                foreach (var c in list_c)
                {
                    ListItem Ci = new ListItem(
                        (c.Marca + " | " + c.Modelo + " | " + c.Matricula),
                        c.Id_Camion.ToString()
                        );
                    ddlcamion.Items.Add(Ci);
                }
            }
            ListItem ddlchoferes_I = new ListItem("Seleccione un chofer", "0");
            dllchofer.Items.Add(ddlchoferes_I);
            List<Choferes_VO> list_ch = BLL_Choferes.get_Choferes();
            if (list_ch.Count > 0)
            {
                foreach (var ch in list_ch)
                {
                    ListItem Chi = new ListItem(
                        (ch.Nombre + " | " + ch.Apellido_Paterno + " | " + ch.Apellido_Materno),
                        ch.Id_Chofer.ToString()
                        );
                    dllchofer.Items.Add(Chi);
                }
            }
            ListItem ddlcargamentos_I = new ListItem("Seleccione un cargamento", "0");
            ddlcargamento.Items.Add(ddlcamiones_I);
            List<Cargamentos_VO> list_car = BLL_Cargamentos.get_Cargamentos();
            if (list_car.Count > 0)
            {
                foreach (var car in list_car)
                {
                    ListItem Car = new ListItem(
                        (car.Descripcion + " | " + car.Peso + " | " + car.Estatus),
                        car.ID_Cargamento.ToString()
                        );
                    ddlcargamento.Items.Add(Car);
                }
            }
            ListItem DDL_D = new ListItem("Seleccione una Direccion", "0");
            ddlorigen.Items.Add(DDL_D);
            ddldestino.Items.Add(DDL_D);
            List<Direcciones_VO> list_d = BLL_Direcciones.get_Direcciones();
            if (list_d.Count > 0)
            {
                foreach (Direcciones_VO d in list_d)
                {
                    ListItem origen = new ListItem(
                        (d.Calle + " # " + d.Numero + " ") + d.Colonia + " " + d.Ciudad, d.ID_direccion.ToString());
                    ListItem destino = new ListItem(
                        (d.Calle + " # " + d.Numero + " ") + d.Colonia + " " + d.Ciudad, d.ID_direccion.ToString());

                    ddlorigen.Items.Add(origen);
                    ddldestino.Items.Add(destino);
                }
            }
        }
        protected void calsalida_SelectionChanged(object sender, EventArgs e)
        {
            fecha_salida_global = calsalida.SelectedDate;
            fecha_llegada_global = calsalida.SelectedDate.AddDays(4);

            lblsalida.Text = "Salida Estimada \n" + fecha_salida_global.ToShortDateString();
            lblestimada.Text = "Llegada estimada \n" + fecha_llegada_global.ToShortDateString();
            calestimada.SelectedDate = fecha_llegada_global;
            calestimada.VisibleDate = fecha_salida_global;
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Rutas_VO _ruta = new Rutas_VO();

            string titulo, msg, tipo, respuesta;

            try
            {
                _ruta.Distancia = float.Parse(txtdistancia.Text);
                _ruta.Camion_id = int.Parse(ddlcamion.SelectedValue);
                _ruta.Chofer_id = int.Parse(dllchofer.SelectedValue);
                _ruta.Direccion_Origen_Id = int.Parse(ddlorigen.SelectedValue);
                _ruta.Cargamento_Id = int.Parse(ddlcargamento.SelectedValue);
                _ruta.Direccion_Destino_Id = int.Parse(ddldestino.SelectedValue);
                _ruta.Fecha_salida = calsalida.SelectedDate.ToString("yyyy/MM/dd");
                _ruta.Fecha_llegada_estimada = calestimada.SelectedDate.ToString("yyyy/MM/dd");

                if (Request.QueryString["Id"] != null)
                {
                    _ruta.Id_Ruta = int.Parse(Request.QueryString["Id"]);
                    respuesta = BLL_Rutas.update_Ruta(_ruta);
                }
                else
                {
                    respuesta = BLL_Rutas.insertar_Ruta(_ruta);
                }
                if (respuesta.ToUpper().Contains("ERROR"))
                {
                    titulo = "Error";
                    msg = respuesta;
                    tipo = "error";
                    SweetAlert.Sweet_Alert(titulo, msg, tipo, this.Page, this.GetType());
                }
                else
                {
                    titulo = "Ok!";
                    msg = respuesta;
                    tipo = "success";
                    SweetAlert.Sweet_Alert(titulo, msg, tipo, this.Page, this.GetType(), "/Catalogos/Rutas/listarRutas.aspx");
                }
            }
            catch (Exception ex)
            {
                titulo = "Error";
                msg = ex.Message;
                tipo = "error";
                SweetAlert.Sweet_Alert(titulo, msg, tipo, this.Page, this.GetType());
            }
            
        }


    }
}