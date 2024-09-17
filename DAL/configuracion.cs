using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class configuracion
    {
        static string _cadenaConecion = @"Data Source = DESKTOP-22CN6F9\MSSQLSERVER01;
                                           Initial Catalog = Transportes;
                                            Integrated Security = true;";

        public static string CadenaConecion
        {
            get { return _cadenaConecion; }
        }
    }
}
