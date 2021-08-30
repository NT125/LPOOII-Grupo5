using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Items_Pedido
    {
        private int item_Ped_ID;

        public int Item_Ped_ID
        {
            get { return item_Ped_ID; }
            set { item_Ped_ID = value; }
        }
        private int ped_ID;

        public int Ped_ID
        {
            get { return ped_ID; }
            set { ped_ID = value; }
        }
        private int art_ID;

        public int Art_ID
        {
            get { return art_ID; }
            set { art_ID = value; }
        }
        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private decimal cantidad;

        public decimal Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private decimal importe;

        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }
    }
}
