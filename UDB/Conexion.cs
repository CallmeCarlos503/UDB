using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDB
{
   public class Conexion
    {
        public SqlConnection connect= new SqlConnection(@"DESKTOP-70BPDVD\SQLEXPRESS;Database=UDB;Trusted_Connection=True");
        public DataTable listaCarreras()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType= CommandType.TableDirect;
            cmd.CommandText = "SELECT * FROM CARRERAS";
            cmd.Connection = connect;
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
