using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Evolution.General
{
  public   class Conexion
    {
        #region "Variables (Clases) de Conexion"
        private SqlConnection Conexions;
        #endregion
         string sqlstring = string.Empty;

        //string xxx = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString.ToString();
       
        //Constructor
        public Conexion()
        {
            Conexions = new SqlConnection(CadenaConexion);
        }
        private string CadenaConexion
        { 
            get
            {
                //byte[] decryted = Convert.FromBase64String(xxx);

                //sqlstring = Encoding.Unicode.GetString(decryted);
                return ConfigurationManager.ConnectionStrings["Conexion"].ToString();
                //return sqlstring;// ConfigurationManager.ConnectionStrings["Conexion"].ToString();
            }

        }

        public SqlConnection SQL()
        {
            return Conexions;
        }

    }
}
