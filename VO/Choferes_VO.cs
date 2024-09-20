using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Choferes_VO
    {
        private int _Id_Chofer;
        private string _Nombre;
        private string _apellido_Paterno;
        private string _apellido_Materno;
        private string _fecha_Nacimiento;
        private string _licencia;
        private string _telefono;
        private bool _disponibilidad;
        private string _urlfoto;

        public int Id_Chofer { get => _Id_Chofer; set => _Id_Chofer = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido_Paterno { get => _apellido_Paterno; set => _apellido_Paterno = value; }
        public string Apellido_Materno { get => _apellido_Materno; set => _apellido_Materno = value; }
        public string Fecha_Nacimiento { get => _fecha_Nacimiento; set => _fecha_Nacimiento = value; }
        public string Licencia { get => _licencia; set => _licencia = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public bool Disponibilidad { get => _disponibilidad; set => _disponibilidad = value; }
        public string Urlfoto { get => _urlfoto; set => _urlfoto = value; }

        public Choferes_VO()
        {
            _Id_Chofer = 0;
            _Nombre = "";
            _apellido_Paterno = "";
            _apellido_Materno = "";
            _fecha_Nacimiento = "";
            _licencia = "";
            _telefono = "";
            _disponibilidad = true;
            _urlfoto = string.Empty;
        }

        public Choferes_VO(DataRow dr)
        {
            _Id_Chofer = int.Parse(dr["Id_Chofer"].ToString());
            _Nombre = dr["Nombre"].ToString();
            _apellido_Paterno = dr["apellido_Paterno"].ToString();
            _apellido_Materno = dr["apellido_Materno"].ToString();
            _fecha_Nacimiento = dr["fecha_Nacimiento"].ToString();
            _licencia = dr["licencia"].ToString();
            _telefono = dr["telefono"].ToString();
            _disponibilidad = bool.Parse(dr["disponibilidad"].ToString());
            _urlfoto = dr["urlfoto"].ToString();
        }
    }
}
