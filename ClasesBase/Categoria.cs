using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Categoria
    {
        private int cat_ID;

        public int Cat_ID
        {
            get { return cat_ID; }
            set { cat_ID = value; }
        }
        private string cat_Descrip;

        public string Cat_Descrip
        {
            get { return cat_Descrip; }
            set { cat_Descrip = value; }
        }
    }
}
