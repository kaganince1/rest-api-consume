using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;

namespace RestApi_WebForm.Controllers
{
    public class DenemeController : ApiController
    {
        // GET ALL
        public DataSet GetAll(string connStr)
        {
            SqlConnection conn = new SqlConnection(connStr);
            DataSet ds = new DataSet();
            conn.Open();
            string cmdStr = "select * from Odev";
            SqlCommand cmd = new SqlCommand(cmdStr, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            conn.Close();
            return ds;
        }
        // GET ONE
        public DataSet GetOne(string connStr, int id)
        {
            SqlConnection conn = new SqlConnection(connStr);
            DataSet ds = new DataSet();
            conn.Open();
            string cmdStr = "select * from Odev where Id='" + id + "'";
            SqlCommand cmd = new SqlCommand(cmdStr, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            conn.Close();
            return ds;
        }

        // POST
        public void Post(string name, string surname, int age, string location, string connStr)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string cmdStr = "insert into Odev (Name, Surname, Age, Location) Values ('" + name + "', '" + surname + "', " + age + ", '" + location + "')";
            SqlCommand cmd = new SqlCommand(cmdStr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // UPDATE
        public void Put(string name, string surname, int age, string location, int id, string connStr)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string cmdStr = "update Odev set Name = '" + name + "', Surname = '" + surname + "', Age = '" + age + "', Location = '" + location + "' where Id = '" + id + "';";
            SqlCommand cmd = new SqlCommand(cmdStr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // DELETE
        public void Delete(int id, string connStr)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string cmdStr = "delete from Odev where Id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(cmdStr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
