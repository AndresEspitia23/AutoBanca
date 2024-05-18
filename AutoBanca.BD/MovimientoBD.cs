using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBanca.BD
{
    public class MovimientoBD
    {
        AutoBancaEntities BD = new AutoBancaEntities();

        // Declaracion de variables

        int mov_id;
        DateTime mov_fecha;
        decimal mov_monto;
        string mov_tipo;
        string mov_descripcion;
        int cue_id;

        // Contructor

        public MovimientoBD()
        {
            mov_id = 0;
            mov_fecha = DateTime.Now;
            mov_monto = 0;
            mov_tipo = string.Empty;
            mov_descripcion = string.Empty;
            cue_id = 0;
        }

        // Propiedades 

        public int Mov_id { get; set; }
        public DateTime Mov_fecha { get; set; }
        public decimal Mov_monto { get; set; }
        public string Mov_tipo { get; set; }
        public string Mov_descripcion { get; set; }
        public int Cue_id { get; set; }

        


    }
}
