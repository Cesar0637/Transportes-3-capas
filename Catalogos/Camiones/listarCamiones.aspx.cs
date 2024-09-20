using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VO;

namespace Transportes_3_capas.Catalogos.Camiones
{
    public partial class listarCamiones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrid();
            }
        }

        public void cargarGrid()
        {
            //carga la informacion desde la BLL al GV 
            GVCamiones.DataSource = BLL_Camiones.get_Camiones();
            //Mostramos los resultado renderizando los informacion
            GVCamiones.DataBind();
        }
        protected void GVCamiones_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //recupero el id del renglon afectado
            int idcamion = int.Parse(GVCamiones.DataKeys[e.RowIndex].Values["ID_Camion"].ToString());

            //invoco mi metodo para eliminar camiones desde la BLL 
            //string repuesta = BLL_Camiones.eliminar_Camion(idcamion);
            //invoco mi metodo para eliminar camiones desde el servicio Web
            string respuesta = BLL_Camiones.eliminar_Camion(idcamion);
            //Preparamos el Sweet Alert
            string titulo, msg, tipo;
            if (respuesta.ToUpper().Contains("ERROR"))
            {
                titulo = "Error";
                msg = respuesta;
                tipo = "error";
            }
            else
            {
                titulo = "Correcto!";
                msg = respuesta;
                tipo = "succes";
            }
            //Sweet alert
            //Recargamos el Grid
            cargarGrid();
        }

        protected void GVCamiones_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // defino si el comando (el click que se detecta es select)
            if (e.CommandName == "Select")
            {
                //recuperamos el indice en cuncion de aquel elemento que haya detonado el evento
                int varIndex = int.Parse(e.CommandArgument.ToString());
                //recupero el ID en funcion del indice que recuperemos 
                string id = GVCamiones.DataKeys[varIndex].Values["Id_Camion"].ToString();
                //redirecciono al formulario de edicion, pasando como parametro el ID
                Response.Redirect("FormularioCamiones.aspx?Id=" + id);
            }
        }

        protected void GVCamiones_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GVCamiones.EditIndex = e.NewEditIndex;
            cargarGrid();
        }

        protected void GVCamiones_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //recupero el id del renglon afectado
            int idcamion = int.Parse(GVCamiones.DataKeys[e.RowIndex].Values["Id_Camion"].ToString());

            //invoco mi metodo para eliminar camiones desde la BLL 
            //string repuesta = BLL_Camiones.eliminar_Camion(idcamion);
            //invoco mi metodo para eliminar camiones desde el servicio Web
            string matricula = e.NewValues["Matricula"].ToString();
            string TipoCamion = e.NewValues["UrlFoto"].ToString();
            string Foto = e.NewValues["UrlFoto"].ToString();
            CheckBox chaux = (CheckBox)GVCamiones.Rows[e.RowIndex].FindControl("chkEditDisponible");
            bool disponibilidad = chaux.Checked;
            //Recupero el Objeto Original 
            Camiones_VO _camion = BLL_Camiones.get_Camiones("@Id_Camion", idcamion)[0];
            Camiones_VO _camion_aux = new Camiones_VO();

            _camion_aux.Id_Camion = idcamion;
            _camion_aux.Matricula = matricula;
            _camion_aux.Disponibilidad = disponibilidad;
            _camion_aux.Tipo_camion = TipoCamion;
            _camion_aux.Urlfoto = Foto;
            _camion_aux.Marca = _camion.Marca;
            _camion_aux.Modelo = _camion.Modelo;
            _camion_aux.Capacidad = _camion.Capacidad;
            _camion_aux.Kilometraje = _camion.Kilometraje;


            string respuesta = "";
            string titulo, msg, tipo;

            try
            {
                respuesta = BLL_Camiones.update_Camion(_camion_aux);


                //Preparamos el Sweet Alert

                if (respuesta.ToUpper().Contains("ERROR"))
                {
                    titulo = "Ops...";
                    msg = respuesta;
                    tipo = "error";
                }
                else

                {
                    titulo = "Correcto!";
                    msg = respuesta;
                    tipo = "succes";
                }
                //Sweet alert
                //Recargamos el Grid
                cargarGrid();
            }
            catch (Exception ex)
            {
                titulo = "Ops...";
                msg = ex.Message;
                tipo = "error";
            }
            GVCamiones.EditIndex = -1;
            cargarGrid();
        }
        protected void GVCamiones_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Reinicio los indices de Edicion
            GVCamiones.EditIndex = -1;
            //Recarg el Grid
            cargarGrid();

        }

        protected void Insertar_Click(object sender, EventArgs e)
        {
            Response.Redirect("formularioCamiones.aspx");
        }
    }
}