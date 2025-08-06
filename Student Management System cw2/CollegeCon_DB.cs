using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Student_Management_System_cw2
{
    class CollegeCon_DB
    {

        public SqlConnection connect = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter adp = new SqlDataAdapter();
        public SqlDataReader dr;

        public CollegeCon_DB()
        {
            connect = new SqlConnection("Server=tcp:collegedbms.database.windows.net,1433;Initial Catalog=College;Persist Security Info=False;User ID=Prakash156;Password=Ba@178%b1d;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        public int insert_update_delete_view(string query)
        {
            connect.Open();
            cmd = new SqlCommand(query, connect);
            int d = cmd.ExecuteNonQuery();
            connect.Close();
            return d;

        }

        public DataTable display(string query)
        {
            connect.Open();
            adp = new SqlDataAdapter(query, connect);
            DataTable Dt = new DataTable();
            adp.Fill(Dt);
            connect.Close();
            return Dt;

        }

        public void exe(string qry)
        {
            connect.Close();
            connect.Open();
            cmd = new SqlCommand(qry, connect);
            cmd.CommandText = qry;
            dr = cmd.ExecuteReader();


        }
    }
}
