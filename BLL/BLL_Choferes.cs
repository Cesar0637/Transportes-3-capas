using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;

using VO;

namespace BLL
{
    public class BLL_Choferes
    {
        // CRUD
        public static string insertar_Chofer(Choferes_VO chofer)
        {
            return DAL_Choferes.insertar_Chofer(chofer);
        }

        public static List<Choferes_VO> get_Choferes(params object[] parametros)
        {
            return DAL_Choferes.get_Choferes(parametros);
        }

        public static string update_Chofer(Choferes_VO chofer)
        {
            return DAL_Choferes.update_Chofer(chofer);
        }

        public static string eliminar_Chofer(int id)
        {
            return DAL_Choferes.eliminar_Chofer(id);
        }
    }
}
