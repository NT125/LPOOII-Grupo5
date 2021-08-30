using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Mesa
    {
        private int mesa_ID;

        public int Mesa_ID
        {
            get { return mesa_ID; }
            set { mesa_ID = value; }
        }
        private int mesa_Posicion;

        public int Mesa_Posicion
        {
            get { return mesa_Posicion; }
            set { mesa_Posicion = value; }
        }
        private bool mesa_Estado;

        public bool Mesa_Estado
        {
            get { return mesa_Estado; }
            set { mesa_Estado = value; }
        }
    }
}
