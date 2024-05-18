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


        // Procemiento de Movimiento_Insert
        public void Movimiento_Insert(DateTime mov_fecha, decimal mov_monto, string mov_tipo, string mov_descripcion, int cue_id)
        {
            try
            {
                BD.Movimiento_Insert(mov_fecha, mov_monto, mov_tipo, mov_descripcion, cue_id);
                BD.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        // Procemiento de Movimiento_List
        public List<Movimiento_List_Result> Movimiento_List(int cue_id)
        {
            try
            {
                var Movimiento = BD.Movimiento_List(cue_id).ToList();
                return Movimiento;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        // Procedimiento de Movimiento_Delete
        // comentario
        public void Movimiento_Delete(int mov_id)
        {
            try
            {
                BD.Movimiento_Delete(mov_id);
                BD.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        // Procedimiento de Movimiento_Update
        public void Movimiento_Update(int mov_id, DateTime mov_fecha, decimal mov_monto, string mov_tipo, string mov_descripcion, int cue_id)
        {
            try
            {
                BD.Movimiento_Update(mov_id, mov_fecha, mov_monto, mov_tipo, mov_descripcion, cue_id);
                BD.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
