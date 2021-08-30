using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Unidad_Medida
    {
        private int um_ID;

        public int Um_ID
        {
            get { return um_ID; }
            set { um_ID = value; }
        }
        private string um_Descrip;

        public string Um_Descrip
        {
            get { return um_Descrip; }
            set { um_Descrip = value; }
        }
        private string um_Abrev;

        public string Um_Abrev
        {
            get { return um_Abrev; }
            set { um_Abrev = value; }
        }
    }
}
