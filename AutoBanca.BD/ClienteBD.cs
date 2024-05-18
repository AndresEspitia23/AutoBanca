using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBanca.BD
{
    public class ClienteBD
    {
        AutoBancaEntities BD = new AutoBancaEntities();

        // Declaracion de variables

        int cli_id;
        string cli_identificacioin;
        string cli_apellido1;
        string cli_apellido2;
        string cli_nombre1;
        string cli_nombre2;
        string cli_direccion;
        string cli_celular;
        string cli_email;

        // Constructor

        public ClienteBD()
        {
            cli_id = 0;
            cli_identificacioin = "";
            cli_apellido1 = "";
            cli_apellido2 = "";
            cli_nombre1 = "";
            cli_nombre2 = "";
            cli_direccion = "";
            cli_celular = "";
            cli_email = "";
        }

        // Propiedades 

        public int Cli_id { get; set; }
        public string Cli_identificacioin { get; set; }
        public string Cli_apellido1 { get; set; }
        public string Cli_apellido2 { get; set; }
        public string Cli_nombre1 { get; set; }
        public string Cli_nombre2 { get; set; }
        public string Cli_direccion { get; set; }
        public string Cli_celular { get; set; }
        public string Cli_email { get; set; }

        // Procedimiento Cliente_Insert
        /// <summary>
        /// Descripcion: Procedimiento que inserta un cliente a la base de datos.
        /// </summary>
        /// <param name="cli_identificacioin"></param>
        /// <param name="cli_apellido1"></param>
        /// <param name="cli_apellido2"></param>
        /// <param name="cli_nombre1"></param>
        /// <param name="cli_nombre2"></param>
        /// <param name="cli_direccion"></param>
        /// <param name="cli_celular"></param>
        /// <param name="cli_email"></param>

        public void Cliente_Insert(string cli_identificacioin, string cli_apellido1, string cli_apellido2, string cli_nombre1, string cli_nombre2, string cli_direccion, string cli_celular, string cli_email)
        {
            try
            {
                BD.Cliente_Insert(cli_identificacioin, cli_apellido1, cli_apellido2, cli_nombre1, cli_nombre2, cli_direccion, cli_celular, cli_email);
                BD.SaveChanges();
            } 
            catch (Exception Ex) 
            {
                throw (Ex);
            }
        }
      

        // Procedimiento de Cliente_Update
        /// <summary>
        /// Descripcion: Procedimiento que actualiza un cliente en la base de datos.
        /// </summary>
        /// <param name="cli_id"></param>
        /// <param name="cli_identificacioin"></param>
        /// <param name="cli_apellido1"></param>
        /// <param name="cli_apellido2"></param>
        /// <param name="cli_nombre1"></param>
        /// <param name="cli_nombre2"></param>
        /// <param name="cli_direccion"></param>
        /// <param name="cli_celular"></param>
        /// <param name="cli_email"></param>
        public void Cliente_Update(int cli_id, string cli_identificacioin, string cli_apellido1, string cli_apellido2, string cli_nombre1, string cli_nombre2, string cli_direccion, string cli_celular, string cli_email)
        {
            try
            {
                BD.Cliente_Update(cli_id, cli_identificacioin, cli_apellido1, cli_apellido2, cli_nombre1, cli_nombre2, cli_direccion, cli_celular, cli_email);
                BD.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }


        // Procedimiento de Cliente_Delete
        /// <summary>
        /// Descripcion: Procedimiento que elimina un cliente de la base de datos.
        /// </summary>
        /// <param name="cli_id"></param>
        public void Cliente_Delete(int cli_id)
        {
            try
            {
                BD.Cliente_Delete(cli_id);
                BD.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }


        // Procedimiento de Cliente_List
        /// <summary>
        /// Descripcion: Procedimiento que lista los clientes de la base de datos.
        /// </summary>
        /// <param name="cli_id"></param>
        /// <returns></returns>
        public List<Cliente_List_Result> Cliente_List(int cli_id)
        {
            try
            {
                var clientes = BD.Cliente_List(cli_id).ToList();
                return clientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
