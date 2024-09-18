using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VO;

namespace Transportes_3_capas.Catalogos.Camiones
{
    public partial class formularioCamiones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //validar si es postback
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] == null)
                {
                    Titulo.Text = "Agregar Camion";
                    Subtitulo.Text = "Registro de un nevento de camion";
                    lbldisponibilidad.Visible = false;
                    chkdisponibilidad.Visible = false;
                    imgfoto.Visible = false;
                    lblurlfoto.Visible = false;

                }
                else
                {
                    //Voy a actualizar
                    int _id = Convert.ToInt32(Request.QueryString["Id"]);


                    Camiones_VO _camion_original = BLL_Camiones.get_Camiones("@ID_Camion", _id)[0];
                    //valido que realmente obtenga un objeto, de lo contrario me regreso al listado 
                    if (_camion_original.Id_Camion != 0)
                    {
                        Titulo.Text = "Actualizar Camion";
                        Subtitulo.Text = $"Modificar los datos del Camion #{_id}";
                        txtmatricula.Text = _camion_original.Matricula;
                        txtcapacidad.Text = _camion_original.Capacidad.ToString();
                        txtkilometraje.Text = _camion_original.Kilometraje.ToString();
                        txtmarca.Text = _camion_original.Marca;
                        txtmodelo.Text = _camion_original.Modelo;
                        txttipo_camion.Text = _camion_original.Tipo_camion;
                        chkdisponibilidad.Checked = _camion_original.Disponibilidad;
                        imgfoto.ImageUrl = _camion_original.Urlfoto;
                    }
                    else
                    {
                        //Voy pa tras 
                        Response.Redirect("listarCamiones.aspx");
                    }
                }
            }
        }

        protected void btnsubeimagen_Click(object sender, EventArgs e)
        {
            if (subeimagen.Value != "")
            {

                string filename = Path.GetFileName(subeimagen.Value);
                //validar la extension del archivo
                string fileext = Path.GetExtension(filename).ToLower();
                if ((fileext != ".jpg") && (fileext != ".png"))
                {
                    //Sweet alert
                }
                else
                {
                    //verifico que exite el directorio en el servidor para poder almacenar la imagen, si es que no, lo creo
                    string pathdir = Server.MapPath("~/Imagenes/Camiones/");// ~ (virgulilla) hace referencia ala 
                    //direccion completa del servidor, independiente de donde este instalado, permitido que
                    //si no existe eldirectario, lo creamos 
                    if (!Directory.Exists(pathdir))
                    {
                        Directory.CreateDirectory(pathdir);
                    }
                    //subimos ala carpeta del server
                    subeimagen.PostedFile.SaveAs(pathdir + filename);
                    //recuperamos la ruta de la URL que almacenaremos en la BD
                    string urlfoto = "/Imagenes/Camiones/" + filename;
                    //mostramos en pantalla URL creada
                    this.urlfoto.Text = urlfoto;
                    //mostramos la imagen
                    imgcamion.ImageUrl = urlfoto;
                    //Sweet Alert
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string titulo = "", respuesta = "", tipo = "", salida = "";
            try
            {
                Camiones_VO _camion_aux = new Camiones_VO();
                _camion_aux.Matricula = txtmatricula.Text;
                _camion_aux.Tipo_camion = txttipo_camion.Text;
                _camion_aux.Marca = txtmarca.Text;
                _camion_aux.Modelo = txtmodelo.Text;
                _camion_aux.Capacidad = Convert.ToInt32(txtcapacidad.Text);
                _camion_aux.Kilometraje = double.Parse(txtcapacidad.Text);
                _camion_aux.Urlfoto = imgcamion.ImageUrl;
                _camion_aux.Disponibilidad = chkdisponibilidad.Checked;

                Camiones_VO _camion_aux2 = new Camiones_VO()
                {
                    Matricula = txtmatricula.Text,
                    Tipo_camion = txttipo_camion.Text,
                    Marca = txtmarca.Text,
                    Modelo = txtmodelo.Text,
                    Capacidad = Convert.ToInt32(txtcapacidad.Text),
                    Kilometraje = float.Parse(txtkilometraje.Text),
                    Urlfoto = imgcamion.ImageUrl,
                    Disponibilidad = chkdisponibilidad.Checked
                };
                if (Request.QueryString["Id"] == null)
                {
                    //Insertar
                    _camion_aux.Disponibilidad = true;
                    salida = BLL_Camiones.insertar_Camion(_camion_aux);
                }
                else
                {
                    //Actualizar
                    _camion_aux.Id_Camion = int.Parse(Request.QueryString["Id"]);
                    salida = BLL_Camiones.update_Camion(_camion_aux);
                }

                if (salida.ToUpper().Contains("ERROR"))
                {
                    titulo = "Ops...";
                    respuesta = salida;
                    tipo = "error";
                }
                else
                {
                    titulo = "Correcto";
                    respuesta = salida;
                    tipo = "success";
                }
            }
            catch (Exception ex)
            {
                titulo = "Error";
                respuesta = ex.Message;
                tipo = "error";
            }
            //Sweet alert
        }
    }
}