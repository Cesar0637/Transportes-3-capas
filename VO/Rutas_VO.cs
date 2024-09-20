using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Rutas_VO
    {
        private int _Id_Ruta;
        private double _distancia;
        private string _fecha_salida;
        private string _fecha_llegada_estimada;
        private int _Camion_id;
        private int _Chofer_id;
        private int _Direccion_Origen_Id;
        private int _Direccion_Destino_Id;
        private int _Cargamento_Id;

        public int Id_Ruta { get => _Id_Ruta; set => _Id_Ruta = value; }
        public double Distancia { get => _distancia; set => _distancia = value; }
        public string Fecha_salida { get => _fecha_salida; set => _fecha_salida = value; }
        public string Fecha_llegada_estimada { get => _fecha_llegada_estimada; set => _fecha_llegada_estimada = value; }
        public int Camion_id { get => _Camion_id; set => _Camion_id = value; }
        public int Chofer_id { get => _Chofer_id; set => _Chofer_id = value; }
        public int Direccion_Origen_Id { get => _Direccion_Origen_Id; set => _Direccion_Origen_Id = value; }
        public int Direccion_Destino_Id { get => _Direccion_Destino_Id; set => _Direccion_Destino_Id = value; }
        public int Cargamento_Id { get => _Cargamento_Id; set => _Cargamento_Id = value; }

        public Rutas_VO()
        {
            _Id_Ruta = 0;
            _distancia = 0;
            _fecha_salida = "";
            _fecha_llegada_estimada = "";
            _Camion_id = 0;
            _Chofer_id = 0;
            _Direccion_Origen_Id = 0;
            _Direccion_Destino_Id = 0;
            _Cargamento_Id = 0;
        }
        public Rutas_VO(DataRow dr)
        {
            _Id_Ruta = int.Parse(dr["Id_Ruta"].ToString());
            _distancia = double.Parse(dr["distancia"].ToString());
            _fecha_salida = DateTime.Parse(dr["fecha_salida"].ToString()).ToShortDateString();
            _fecha_llegada_estimada =DateTime.Parse(dr["fecha_llegada_estimada"].ToString()).ToShortDateString();
            _Camion_id = int.Parse(dr["Camion_id"].ToString());
            _Chofer_id = int.Parse(dr["Chofer_id"].ToString());
            _Direccion_Origen_Id = int.Parse(dr["Direccion_Origen_Id"].ToString());
            _Direccion_Destino_Id = int.Parse(dr["Direccion_Destino_Id"].ToString());
            _Cargamento_Id = int.Parse(dr["Cargamento_Id"].ToString());
        }
    }
}
