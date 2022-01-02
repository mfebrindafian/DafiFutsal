using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;
using MySqlCommand = MySql.Data.MySqlClient.MySqlCommand;
using MySqlDataReader = MySql.Data.MySqlClient.MySqlDataReader;
using System.Data;
using System.Configuration;

namespace futsal
{
    class Penyewaan
    {
        private String ConnString = ConfigurationManager.ConnectionStrings["dbfutsal"].ConnectionString;
        public string Insert(string nama, string tgl_sewa, int lama_sewa, string kode_lapangan, int biaya, string status,string jam_sewa)
        {
            string result = null;
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO tbPenyewaan (nama,tgl_sewa,lama_sewa,kode_lapangan,biaya,status,jam_sewa)" +
                    "VALUES (@nama,@tgl_sewa,@lama_sewa,@kode_lapangan,@biaya,@status,@jam_sewa)", conn))
                {
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@tgl_sewa", tgl_sewa);
                    cmd.Parameters.AddWithValue("@lama_sewa", lama_sewa);
                    cmd.Parameters.AddWithValue("@kode_lapangan", kode_lapangan);
                    cmd.Parameters.AddWithValue("@biaya", biaya);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@jam_sewa", jam_sewa);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception e)
                    {
                        return e.Message;
                    }
                }
            }
            return result;
        }
        public DataTable ReadAllSewa()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT status,jam_sewa,nama,tgl_sewa,lama_sewa,kode_lapangan,biaya,id FROM tbPenyewaan WHERE status = 'bermain' ORDER BY tgl_sewa", conn))
                {
                    conn.Open();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                }
            }
            return dt;
        }
        public DataTable ReadAllBooking()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT status,jam_sewa,nama,tgl_sewa,lama_sewa,kode_lapangan,biaya,id FROM tbPenyewaan WHERE status = 'booking' ORDER BY tgl_sewa", conn))
                {
                    conn.Open();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                }
            }
            return dt;
        }
        public DataTable ReadAllSelesai()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT status,jam_sewa,nama,tgl_sewa,lama_sewa,kode_lapangan,biaya,id FROM tbPenyewaan WHERE status = 'selesai' ORDER BY tgl_sewa", conn))
                {
                    conn.Open();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                }
            }
            return dt;
        }

        public string Update(int id,string nama, string tgl_sewa, int lama_sewa, string kode_lapangan, int biaya, string status,string jam_sewa)
        {
            string result = null;
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("UPDATE tbpenyewaan SET nama=@nama,tgl_sewa=@tgl_sewa,lama_sewa=@lama_sewa,kode_lapangan=@kode_lapangan,biaya=@biaya,status=@status,jam_sewa=@jam_sewa WHERE id=@id ", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@tgl_sewa", tgl_sewa);
                    cmd.Parameters.AddWithValue("@lama_sewa", lama_sewa);
                    cmd.Parameters.AddWithValue("@kode_lapangan", kode_lapangan);
                    cmd.Parameters.AddWithValue("@biaya", biaya);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@jam_sewa", jam_sewa);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception e)
                    {
                        return e.Message;
                    }
                }
            }
            return result;
        }
        public string Delete(int id)
        {
            string result = null;
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM tbpenyewaan WHERE id=@id ", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception e)
                    {
                        return e.Message;
                    }
                }
            }
            return result;
        }
    }
}
