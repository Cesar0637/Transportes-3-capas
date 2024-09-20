using System;
using System.Collections.Generic;
using System.Data;
using VO;

namespace DAL
{
    public class DAL_Direcciones
    {
        // Create
        public static string insertar_Direccion(Direcciones_VO direccion)
        {
            string salida = "";
            int respuesta = 0;

            try
            {
                respuesta = metodos_datos.execute_nonQuery("SP_insertar_Direccion",
                    "@calle", direccion.Calle,
                    "@numero", direccion.Numero,
                    "@colonia", direccion.Colonia,
                    "@ciudad", direccion.Ciudad,
                    "@estado_ID", direccion.Estado_ID
                );

                salida = respuesta != 0 ? "Dirección registrada con éxito" : "Ha ocurrido un error";
            }
            catch (Exception e)
            {
                salida = "Error: " + e.Message;
            }
            return salida;
        }

        // Update
        public static string update_Direccion(Direcciones_VO direccion)
        {
            string salida = "";
            int respuesta = 0;

            try
            {
                respuesta = metodos_datos.execute_nonQuery("SP_actualizar_Direccion",
                    "@ID_direccion", direccion.ID_direccion,
                    "@calle", direccion.Calle,
                    "@numero", direccion.Numero,
                    "@colonia", direccion.Colonia,
                    "@ciudad", direccion.Ciudad,
                    "@estado_ID", direccion.Estado_ID
                );

                salida = respuesta != 0 ? "Dirección actualizada con éxito" : "Ha ocurrido un error";
            }
            catch (Exception e)
            {
                salida = "Error: " + e.Message;
            }
            return salida;
        }

        // Read
        public static List<Direcciones_VO> get_Direcciones(params object[] parametros)
        {
            List<Direcciones_VO> List = new List<Direcciones_VO>();
            try
            {
                DataSet ds_direcciones = metodos_datos.execute_DataSet("SP_select_Direcciones", parametros);
                foreach (DataRow dr in ds_direcciones.Tables[0].Rows)
                {
                    List.Add(new Direcciones_VO(dr));
                }
                return List;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Delete
        public static string eliminar_Direccion(int id)
        {
            string salida = "";
            int respuesta = 0;

            try
            {
                respuesta = metodos_datos.execute_nonQuery("SP_eliminar_Direccion",
                    "@ID_direccion", id
                );

                salida = respuesta != 0 ? "Dirección eliminada con éxito" : "Ha ocurrido un error";
            }
            catch (Exception e)
            {
                salida = "Error: " + e.Message;
            }
            return salida;
        }
    }
}
