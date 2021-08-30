using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Familia
    {
        private int fam_ID;

        public int Fam_ID
        {
            get { return fam_ID; }
            set { fam_ID = value; }
        }
        private string fam_Descrip;

        public string Fam_Descrip
        {
            get { return fam_Descrip; }
            set { fam_Descrip = value; }
        }
    }
}
