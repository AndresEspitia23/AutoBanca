using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBanca.BD
{
    public class CuentaBD
    {
        AutoBancaEntities BD = new AutoBancaEntities();

        // Declaracion de variables

        int cue_id;
        string cue_numero;
        bool cue_activa;
        DateTime? cue_fechacreacion;
        string cue_usuariocreacion;
        decimal? cue_saldoactual;
        int? cli_id;

        // Contructor

        public CuentaBD()
        {
            cue_id = 0;
            cue_numero = string.Empty;
            cue_activa = false;
            cue_fechacreacion = null;
            cue_usuariocreacion = string.Empty;
            cue_saldoactual = null;
            cli_id = null;
        }

        // Propiedades 

        public int Cue_id { get; set; }
        public string Cue_numero { get; set; }
        public bool Cue_activa { get; set; }
        public DateTime? Cue_fechacreacion { get; set; }
        public string Cue_usuariocreacion { get; set; }
        public decimal Cue_saldoactual { get; set; }
        public int? Cli_id { get; set; }



        // Procemiento de Cuenta_Insert
        /// <summary>
        /// Descripcion: Procedimiento que inserta un cliente a la base de datos.
        /// </summary>
        /// <param name="cue_numero"></param>
        /// <param name="cue_activo"></param>
        /// <param name="cue_fechacreacion"></param>
        /// <param name="cue_usuariocreacion"></param>
        /// <param name="cue_saldoactual"></param>
        /// <param name="cli_id"></param>
        public void Cuenta_Insert(string cue_numero, bool cue_activo, DateTime cue_fechacreacion, string cue_usuariocreacion, decimal cue_saldoactual, int cli_id)
        {
            try
            {
                BD.Cuenta_Insert(cue_numero, cue_activo, cue_fechacreacion, cue_usuariocreacion, cue_saldoactual, cli_id);
                BD.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        // Procedimiento de Cuenta_List
        /// <summary>
        /// Descripcion: Procedimiento que lista las cuentas de la base de datos.
        /// </summary>
        /// <param name="cue_id"></param>
        /// <returns></returns>
        public List<Cuenta_List_Result> Cuenta_List(int cue_id)
        {
            try
            {
                var Cuenta = BD.Cuenta_List(cue_id).ToList();
                return Cuenta;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        // Procedimiento de Cuenta_Update
        /// <summary>
        /// Descripcion: Procedimiento que actualiza una cuenta de la base de datos.
        /// </summary>
        /// <param name="cue_id"></param>
        /// <param name="cue_numero"></param>
        /// <param name="cue_activo"></param>
        /// <param name="cue_fechacreacion"></param>
        /// <param name="cue_usuariocreacion"></param>
        /// <param name="cue_saldoactual"></param>
        /// <param name="cli_id"></param>
        public void Cuenta_Update(int cue_id, string cue_numero, bool cue_activo, DateTime cue_fechacreacion, string cue_usuariocreacion, decimal cue_saldoactual, int cli_id)
        {
            try
            {
                BD.Cuenta_Update(cue_id, cue_numero, cue_activo, cue_fechacreacion, cue_usuariocreacion, cue_saldoactual, cli_id);
                BD.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        // Procedimiento de Cuenta_Delete
        /// <summary>
        /// Descripcion: Procedimiento que elimina una cuenta de la base de datos.
        /// </summary>
        /// <param name="cue_id"></param>
        public void Cuenta_Delete(int cue_id)
        {
            try
            {
                BD.Cuenta_Delete(cue_id);
                BD.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }


    }
}
