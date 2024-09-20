using System;
using System.Collections.Generic;
using System.Data;
using VO;

namespace DAL
{
    public class DAL_Choferes
    {
        // Create
        public static string insertar_Chofer(Choferes_VO chofer)
        {
            string salida = "";
            int respuesta = 0;

            try
            {
                respuesta = metodos_datos.execute_nonQuery("SP_insertar_Chofer",
                    "@Nombre", chofer.Nombre,
                    "@apellido_Paterno", chofer.Apellido_Paterno,
                    "@apellido_Materno", chofer.Apellido_Materno,
                    "@fecha_Nacimiento", chofer.Fecha_Nacimiento,
                    "@licencia", chofer.Licencia,
                    "@telefono", chofer.Telefono,
                    "@disponibilidad", chofer.Disponibilidad,
                    "@urlfoto", chofer.Urlfoto
                );

                salida = respuesta != 0 ? "Chofer registrado con éxito" : "Ha ocurrido un error";
            }
            catch (Exception e)
            {
                salida = "Error: " + e.Message;
            }
            return salida;
        }

        // Update
        public static string update_Chofer(Choferes_VO chofer)
        {
            string salida = "";
            int respuesta = 0;

            try
            {
                respuesta = metodos_datos.execute_nonQuery("SP_actualizar_Chofer",
                    "@Id_Chofer", chofer.Id_Chofer,
                    "@Nombre", chofer.Nombre,
                    "@apellido_Paterno", chofer.Apellido_Paterno,
                    "@apellido_Materno", chofer.Apellido_Materno,
                    "@fecha_Nacimiento", chofer.Fecha_Nacimiento,
                    "@licencia", chofer.Licencia,
                    "@telefono", chofer.Telefono,
                    "@disponibilidad", chofer.Disponibilidad,
                    "@urlfoto", chofer.Urlfoto
                );

                salida = respuesta != 0 ? "Chofer actualizado con éxito" : "Ha ocurrido un error";
            }
            catch (Exception e)
            {
                salida = "Error: " + e.Message;
            }
            return salida;
        }

        // Read
        public static List<Choferes_VO> get_Choferes(params object[] parametros)
        {
            List<Choferes_VO> List = new List<Choferes_VO>();
            try
            {
                DataSet ds_choferes = metodos_datos.execute_DataSet("SP_select_Choferes", parametros);
                foreach (DataRow dr in ds_choferes.Tables[0].Rows)
                {
                    List.Add(new Choferes_VO(dr));
                }
                return List;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Delete
        public static string eliminar_Chofer(int id)
        {
            string salida = "";
            int respuesta = 0;

            try
            {
                respuesta = metodos_datos.execute_nonQuery("SP_eliminar_Chofer",
                    "@Id_Chofer", id
                );

                salida = respuesta != 0 ? "Chofer eliminado con éxito" : "Ha ocurrido un error";
            }
            catch (Exception e)
            {
                salida = "Error: " + e.Message;
            }
            return salida;
        }
    }
}
