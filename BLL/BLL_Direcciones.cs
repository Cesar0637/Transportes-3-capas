using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using System.Collections.Generic;
using VO;

namespace BLL
{
    public class BLL_Direcciones
    {
        // CRUD
        public static string insertar_Direccion(Direcciones_VO direccion)
        {
            return DAL_Direcciones.insertar_Direccion(direccion);
        }

        public static List<Direcciones_VO> get_Direcciones(params object[] parametros)
        {
            return DAL_Direcciones.get_Direcciones(parametros);
        }

        public static string update_Direccion(Direcciones_VO direccion)
        {
            return DAL_Direcciones.update_Direccion(direccion);
        }

        public static string eliminar_Direccion(int id)
        {
            return DAL_Direcciones.eliminar_Direccion(id);
        }
    }
}
