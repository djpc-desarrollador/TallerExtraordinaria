using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller_Extraordinaria.Datos;

namespace Software 
{
    public class NParentesco
    {
        private PolancoFinalEntities controlParentesco = new PolancoFinalEntities();

        //LISTAR PARENTESCOS
        public List<Parentesco> listarParentescos()
        {
            List<Parentesco> listaMostrar = new List<Parentesco>();
            listaMostrar = controlParentesco.Parentesco.ToList();
            return listaMostrar;
        }
    }
}
