using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace BLL
{
    public class BLL_Camiones
    {
        //CRUD
        public static string insertar_Camion(Camiones_VO camion)
        {
            return DAL_Camiones.insertar_Camion(camion);
        }
        public static List<Camiones_VO> get_Camiones(params object[] parametros)
        {
            return DAL_Camiones.get_Camiones(parametros);
        }
        public static string update_Camion(Camiones_VO camion)
        {
            return DAL_Camiones.update_Camion(camion);
        }
        public static string eliminar_Camion(int id)
        {
            return DAL_Camiones.eliminar_Camion(id);
        }
    }
}
