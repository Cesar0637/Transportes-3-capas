using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DAL_Camiones
    {
        //CRUD
        //create 
        public static string insertar_Camion(Camiones_VO camion)
        {
            string salida = "";
            int respuesta = 0;

            try
            {
                respuesta = metodos_datos.execute_nonQuery("SP_insertar_Camion",
                    "@matricula ", camion.Matricula,
                    "@capacidad ", camion.Capacidad,
                    "@tipo_camion ", camion.Tipo_camion,
                    "@urlfoto ", camion.Urlfoto,
                    "@marca ", camion.Marca,
                    "@modelo ", camion.Modelo,
                    "@kilometraje ", camion.Kilometraje,
                    "@disponibilidad ", camion.Disponibilidad
                    );
                if (respuesta != 0)
                {
                    salida = "Camion registrado con exito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception e)
            {
                salida = "Errror: " + e.Message;
            }
            return salida;
        }
        //Update
        public static string update_Camion(Camiones_VO camion)
        {
            string salida = "";
            int respuesta = 0;

            try
            {
                respuesta = metodos_datos.execute_nonQuery("SP_actualizar_Camion",
                    "@Id_Camion", camion.Id_Camion,
                    "@matricula ", camion.Matricula,
                    "@capacidad ", camion.Capacidad,
                    "@tipo_camion ", camion.Tipo_camion,
                    "@urlfoto ", camion.Urlfoto,
                    "@marca ", camion.Marca,
                    "@modelo ", camion.Modelo,
                    "@kilometraje ", camion.Kilometraje,
                    "@disponibilidad ", camion.Disponibilidad
                    );
                if (respuesta != 0)
                {
                    salida = "Camion registrado con exito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception e)
            {
                salida = "Errror: " + e.Message;
            }
            return salida;
        }

        //READ
        public static List<Camiones_VO> get_Camiones(params object[] parametros)
        {
            List<Camiones_VO> List = new List<Camiones_VO>();
            try
            {
                DataSet ds_camiones = metodos_datos.execute_DataSet("SP_select_Camiones", parametros);
                //recorrremos caada renglon existenste de nuestro ods crando objectos VO y aniadiendolo ala lista
                foreach (DataRow dr in ds_camiones.Tables[0].Rows)
                {
                    List.Add(new Camiones_VO(dr));
                }
                return List;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //DELETE
        public static string eliminar_Camion(int id)
        {
            string salida = "";
            int respuesta = 0;

            try
            {
                respuesta = metodos_datos.execute_nonQuery("SP_eliminar_Camion",
                    "@Id_Camion ", id
                    );
                if (respuesta != 0)
                {
                    salida = "Camion eliminado con exito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception e)
            {
                salida = "Errror: " + e.Message;
            }
            return salida;
        }


    }
}
