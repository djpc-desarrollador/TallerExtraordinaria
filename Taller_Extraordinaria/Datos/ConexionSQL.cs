using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller_Extraordinaria;
using Taller_Extraordinaria.Datos;

namespace Software.Datos
{
    class ConexionSQL
    {
        public PolancoFinalEntities Conexion { private set; get; }

        private ConexionSQL()
        {
            this.Conexion = new PolancoFinalEntities();
        }

        private static ConexionSQL INSTANCE;

        public static ConexionSQL GetInstance()
        {
            if (ConexionSQL.INSTANCE == null)
            {
                ConexionSQL.INSTANCE = new ConexionSQL();
            }
            return ConexionSQL.INSTANCE;
        }
    }

}
