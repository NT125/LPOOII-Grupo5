using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Articulos
    {
        private int art_ID;

        public int Art_ID
        {
            get { return art_ID; }
            set { art_ID = value; }
        }
        private string art_Descrip;

        public string Art_Descrip
        {
            get { return art_Descrip; }
            set { art_Descrip = value; }
        }
        private int fam_ID;

        public int Fam_ID
        {
            get { return fam_ID; }
            set { fam_ID = value; }
        }
        private decimal art_Precio;

        public decimal Art_Precio
        {
            get { return art_Precio; }
            set { art_Precio = value; }
        }
        private Boolean art_Maneja_Stock;

        public Boolean Art_Maneja_Stock
        {
            get { return art_Maneja_Stock; }
            set { art_Maneja_Stock = value; }
        }
    }
}
