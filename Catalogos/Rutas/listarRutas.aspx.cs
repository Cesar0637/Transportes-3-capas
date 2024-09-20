using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VO;

namespace Transportes_3_capas.Catalogos.Rutas
{
    public partial class ListarRutas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrid();
            }
        }

        public void CargarGrid()

        {
            
            GVRutas.DataSource = BLL_Rutas.get_Rutas();
            
            GVRutas.DataBind();
        }

        protected void GVRutas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
            int idruta = int.Parse(GVRutas.DataKeys[e.RowIndex].Values["Id_Ruta"].ToString());

           
            string respuesta = BLL_Rutas.eliminar_Ruta(idruta);
            
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

            CargarGrid();
        }

        protected void GVRutas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
            if (e.CommandName == "Select")
            {
                
                int varIndex = int.Parse(e.CommandArgument.ToString());
                
                string id = GVRutas.DataKeys[varIndex].Values["Id_Ruta"].ToString();
                
                Response.Redirect("FormularioRutas.aspx?Id=" + id);
            }
        }
        protected void Insertar_Click(object sender, EventArgs e)
        {
            Response.Redirect("formularioRutas.aspx");
        }
    }
    
}

