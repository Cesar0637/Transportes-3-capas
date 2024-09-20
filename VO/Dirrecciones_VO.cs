using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Direcciones_VO
    {
        private int _ID_direccion;
        private string _calle;
        private string _numero;
        private string _colonia;
        private string _ciudad;
        private int _estado_ID;

        public int ID_direccion { get => _ID_direccion; set => _ID_direccion = value; }
        public string Calle { get => _calle; set => _calle = value; }
        public string Numero { get => _numero; set => _numero = value; }
        public string Colonia { get => _colonia; set => _colonia = value; }
        public string Ciudad { get => _ciudad; set => _ciudad = value; }
        public int Estado_ID { get => _estado_ID; set => _estado_ID = value; }

        public Direcciones_VO()
        {
            _ID_direccion = 0;
            _calle = "";
            _numero = "";
            _colonia = "";
            _ciudad = "";
            _estado_ID = 0;
        }

        public Direcciones_VO(DataRow dr)
        {
            _ID_direccion = int.Parse(dr["ID_direccion"].ToString());
            _calle = dr["calle"].ToString();
            _numero = dr["numero"].ToString();
            _colonia = dr["colonia"].ToString();
            _ciudad = dr["ciudad"].ToString();
            _estado_ID = int.Parse(dr["estado_ID"].ToString());
        }
    }
}

