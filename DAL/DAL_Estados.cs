using System;
using System.Collections.Generic;
using System.Data;
using VO;

namespace DAL
{
    public class DAL_Estados
    {
        // Create

        public static List<Estados_VO> get_Estados(params object[] parametros)
        {
            List<Estados_VO> List = new List<Estados_VO>();
            try
            {
                DataSet ds_estados = metodos_datos.execute_DataSet("sp_evento_sel_estados", parametros);
                foreach (DataRow dr in ds_estados.Tables[0].Rows)
                {
                    List.Add(new Estados_VO(dr));
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
