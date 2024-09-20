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
    public class BLL_Cargamentos
    {
        // CRUD
        public static string insertar_Cargamento(Cargamentos_VO cargamento)
        {
            return DAL_Cargamentos.insertar_Cargamento(cargamento);
        }

        public static List<Cargamentos_VO> get_Cargamentos(params object[] parametros)
        {
            return DAL_Cargamentos.get_Cargamentos(parametros);
        }

        public static string update_Cargamento(Cargamentos_VO cargamento)
        {
            return DAL_Cargamentos.update_Cargamento(cargamento);
        }

        public static string eliminar_Cargamento(int id)
        {
            return DAL_Cargamentos.eliminar_Cargamento(id);
        }
    }
}

