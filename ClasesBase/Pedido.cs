using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Pedido
    {
        private int ped_ID;

        public int Ped_ID
        {
            get { return ped_ID; }
            set { ped_ID = value; }
        }
        private int usu_ID;

        public int Usu_ID
        {
            get { return usu_ID; }
            set { usu_ID = value; }
        }
        private int mesa_ID;

        public int Mesa_ID
        {
            get { return mesa_ID; }
            set { mesa_ID = value; }
        }
        private int cli_ID;

        public int Cli_ID
        {
            get { return cli_ID; }
            set { cli_ID = value; }
        }
        private DateTime ped_Fecha_Emision;

        public DateTime Ped_Fecha_Emision
        {
            get { return ped_Fecha_Emision; }
            set { ped_Fecha_Emision = value; }
        }
        private DateTime ped_Fecha_Entrega;

        public DateTime Ped_Fecha_Entrega
        {
            get { return ped_Fecha_Entrega; }
            set { ped_Fecha_Entrega = value; }
        }
        private int ped_Comensales;

        public int Ped_Comensales
        {
            get { return ped_Comensales; }
            set { ped_Comensales = value; }
        }
        private bool ped_Facturado;

        public bool Ped_Facturado
        {
            get { return ped_Facturado; }
            set { ped_Facturado = value; }
        }
    }
}
