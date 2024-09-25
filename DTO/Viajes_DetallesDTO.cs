using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Viajes_DetallesDTO
    {
        public int ID_Cargamento { get; set; }
        public string Cargamento { get; set; }
        public int ID_Direccion_Origen { get; set; }
        public string Origen { get; set; }
        public string Estado_Origen { get; set; }
        public int ID_Direccion_Destino { get; set; }
        public string Destino { get; set; }
        public string Estado_Destino { get; set; }
        public int Id_Chofer { get; set; }
        public string Chofer { get; set; }
        public int Id_Camion { get; set; }
        public string Camión { get; set; }
        public DateTime Salida { get; set; }
        public DateTime Llegada_Estimada { get; set; }
    }
}
