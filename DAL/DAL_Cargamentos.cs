using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DAL_Cargamentos
    {
        // Create
        public static string insertar_Cargamento(Cargamentos_VO cargamento)
        {
            string salida = "";
            int respuesta = 0;

            try
            {
                respuesta = metodos_datos.execute_nonQuery("SP_insertar_Cargamento",
                    "@descripcion", cargamento.Descripcion,
                    "@peso", cargamento.Peso,
                    "@estatus", cargamento.Estatus
                );

                salida = respuesta != 0 ? "Cargamento registrado con éxito" : "Ha ocurrido un error";
            }
            catch (Exception e)
            {
                salida = "Error: " + e.Message;
            }
            return salida;
        }

        // Update
        public static string update_Cargamento(Cargamentos_VO cargamento)
        {
            string salida = "";
            int respuesta = 0;

            try
            {
                respuesta = metodos_datos.execute_nonQuery("SP_actualizar_Cargamento",
                    "@ID_Cargamento", cargamento.ID_Cargamento,
                    "@descripcion", cargamento.Descripcion,
                    "@peso", cargamento.Peso,
                    "@estatus", cargamento.Estatus
                );

                salida = respuesta != 0 ? "Cargamento actualizado con éxito" : "Ha ocurrido un error";
            }
            catch (Exception e)
            {
                salida = "Error: " + e.Message;
            }
            return salida;
        }

        // Read
        public static List<Cargamentos_VO> get_Cargamentos(params object[] parametros)
        {
            List<Cargamentos_VO> List = new List<Cargamentos_VO>();
            try
            {
                DataSet ds_cargamentos = metodos_datos.execute_DataSet("SP_select_Cargamentos", parametros);
                foreach (DataRow dr in ds_cargamentos.Tables[0].Rows)
                {
                    List.Add(new Cargamentos_VO(dr));
                }
                return List;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Delete
        public static string eliminar_Cargamento(int id)
        {
            string salida = "";
            int respuesta = 0;

            try
            {
                respuesta = metodos_datos.execute_nonQuery("SP_eliminar_Cargamento",
                    "@ID_Cargamento", id
                );

                salida = respuesta != 0 ? "Cargamento eliminado con éxito" : "Ha ocurrido un error";
            }
            catch (Exception e)
            {
                salida = "Error: " + e.Message;
            }
            return salida;
        }
    }
}