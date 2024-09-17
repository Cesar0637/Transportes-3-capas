using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DAL_Camiones
    {
        //CRUD
        public static List<Camiones_VO> get_Camiones(params object[] parametros)
        {
            List<Camiones_VO> List = new List<Camiones_VO>();
            try
            {
                DataSet ds_camiones = metodos_datos.execute_DataSet("", parametros);
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

    }
}
