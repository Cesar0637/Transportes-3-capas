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
    public class BLL_Estados
    {
        // CRUD

        public static List<Estados_VO> get_Estados(params object[] parametros)
        {
            return DAL_Estados.get_Estados(parametros);
        }

    }
}