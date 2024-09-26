using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Rutas_DTO
    {
        public int Id_Ruta { get; set; }
        public double distancia { get; set; }
        public DateTime fecha_salida { get; set; }
        public DateTime fecha_llegada_estimada { get; set; }
        public int Camion_id { get; set; }
        public int Chofer_id { get; set; }
        public int Direccion_Origen_Id { get; set; }
        public int Direccion_Destino_Id { get; set; }
        public int Cargamento_Id { get; set; }
    }
}
