using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Estados_VO
    {
        private int _Id_Estado;
        private string _nombre;
        private string _capital;

        public int Id_Estado { get => _Id_Estado; set => _Id_Estado = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Capital { get => _capital; set => _capital = value; }

        public Estados_VO()
        {
            _Id_Estado = 0;
            _nombre = "";
            _capital = "";
        }

        public Estados_VO(DataRow dr)
        {
            _Id_Estado = int.Parse(dr["Id_Estado"].ToString());
            _nombre = dr["nombre"].ToString();
            _capital = dr["capital"].ToString();
        }
    }
}
