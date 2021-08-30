using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Historial_Login
    {
        private int log_ID;

        public int Log_ID
        {
            get { return log_ID; }
            set { log_ID = value; }
        }
        private int usu_ID;

        public int Usu_ID
        {
            get { return usu_ID; }
            set { usu_ID = value; }
        }
        private DateTime log_Fecha_Hora;

        public DateTime Log_Fecha_Hora
        {
            get { return log_Fecha_Hora; }
            set { log_Fecha_Hora = value; }
        }
        private string log_Descrip;

        public string Log_Descrip
        {
            get { return log_Descrip; }
            set { log_Descrip = value; }
        }
    }
}
