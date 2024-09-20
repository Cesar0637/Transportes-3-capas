using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;

using VO;

namespace BLL
{
    public class BLL_Rutas
    {
        // CRUD
        public static string insertar_Ruta(Rutas_VO ruta)
        {
            return DAL_Rutas.insertar_Ruta(ruta);
        }

        public static List<Rutas_VO> get_Rutas(params object[] parametros)
        {
            return DAL_Rutas.get_Rutas(parametros);
        }

        public static string update_Ruta(Rutas_VO ruta)
        {
            return DAL_Rutas.update_Ruta(ruta);
        }

        public static string eliminar_Ruta(int id)
        {
            return DAL_Rutas.eliminar_Ruta(id);
        }
    }
}
