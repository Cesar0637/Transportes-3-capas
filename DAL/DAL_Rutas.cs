using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DAL_Rutas
    {
        // Create
        public static string insertar_Ruta(Rutas_VO ruta)
        {
            string salida = "";
            int respuesta = 0;

            try
            {
                respuesta = metodos_datos.execute_nonQuery("SP_insertar_Ruta",
                    "@distancia", ruta.Distancia,
                    "@fecha_salida", ruta.Fecha_salida,
                    "@fecha_llegada_estimada", ruta.Fecha_llegada_estimada,
                    "@Camion_id", ruta.Camion_id,
                    "@Chofer_id", ruta.Chofer_id,
                    "@Direccion_Origen_Id", ruta.Direccion_Origen_Id,
                    "@Direccion_Destino_Id", ruta.Direccion_Destino_Id,
                    "@Cargamento_Id", ruta.Cargamento_Id
                );

                salida = respuesta != 0 ? "Ruta registrada con éxito" : "Ha ocurrido un error";
            }
            catch (Exception e)
            {
                salida = "Error: " + e.Message;
            }
            return salida;
        }

        // Update
        public static string update_Ruta(Rutas_VO ruta)
        {
            string salida = "";
            int respuesta = 0;

            try
            {
                respuesta = metodos_datos.execute_nonQuery("SP_actualizar_Ruta",
                    "@Id_Ruta", ruta.Id_Ruta,
                    "@distancia", ruta.Distancia,
                    "@fecha_salida", ruta.Fecha_salida,
                    "@fecha_llegada_estimada", ruta.Fecha_llegada_estimada,
                    "@Camion_id", ruta.Camion_id,
                    "@Chofer_id", ruta.Chofer_id,
                    "@Direccion_Origen_Id", ruta.Direccion_Origen_Id,
                    "@Direccion_Destino_Id", ruta.Direccion_Destino_Id,
                    "@Cargamento_Id", ruta.Cargamento_Id
                );

                salida = respuesta != 0 ? "Ruta actualizada con éxito" : "Ha ocurrido un error";
            }
            catch (Exception e)
            {
                salida = "Error: " + e.Message;
            }
            return salida;
        }

        // Read
        public static List<Rutas_VO> get_Rutas(params object[] parametros)
        {
            List<Rutas_VO> List = new List<Rutas_VO>();
            try
            {
                DataSet ds_rutas = metodos_datos.execute_DataSet("SP_select_Rutas", parametros);
                foreach (DataRow dr in ds_rutas.Tables[0].Rows)
                {
                    List.Add(new Rutas_VO(dr));
                }
                return List;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Delete
        public static string eliminar_Ruta(int id)
        {
            string salida = "";
            int respuesta = 0;

            try
            {
                respuesta = metodos_datos.execute_nonQuery("SP_eliminar_Ruta",
                    "@Id_Ruta", id
                );

                salida = respuesta != 0 ? "Ruta eliminada con éxito" : "Ha ocurrido un error";
            }
            catch (Exception e)
            {
                salida = "Error: " + e.Message;
            }
            return salida;
        }
    }
}