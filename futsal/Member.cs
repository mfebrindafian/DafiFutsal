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
    class Member
    {
        private String ConnString = ConfigurationManager.ConnectionStrings["dbfutsal"].ConnectionString;
        public string Insert(string nama, string no_ktp, string no_hp, string alamat, string kode_anggota, string tgl_daftar, int biaya)
        {
            string result = null;
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO tbmember (nama,no_ktp,no_hp,alamat,kode_anggota,tgl_daftar,biaya)" +
                    "VALUES (@nama,@no_ktp,@no_hp,@alamat,@kode_anggota,@tgl_daftar,@biaya)", conn))
                {
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@no_ktp", no_ktp);
                    cmd.Parameters.AddWithValue("@no_hp", no_hp);
                    cmd.Parameters.AddWithValue("@alamat", alamat);
                    cmd.Parameters.AddWithValue("@kode_anggota", kode_anggota);
                    cmd.Parameters.AddWithValue("@tgl_daftar", tgl_daftar);
                    cmd.Parameters.AddWithValue("@biaya", biaya);
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
        public DataTable ReadAll()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT nama,no_ktp,no_hp,alamat,kode_anggota,tgl_daftar,biaya,id FROM tbmember", conn))
                {
                    conn.Open();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                }
            }
            return dt;
        }
        public string Update(int id, string nama, string no_ktp, string no_hp, string alamat, string kode_anggota, string tgl_daftar, int biaya)
        {
            string result = null;
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("UPDATE tbMember SET nama=@nama,no_ktp=@no_ktp,no_hp=@no_hp,alamat=@alamat,kode_anggota=@kode_anggota,tgl_daftar=@tgl_daftar,biaya=@biaya WHERE id=@id ", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@no_ktp", no_ktp);
                    cmd.Parameters.AddWithValue("@no_hp", no_hp);
                    cmd.Parameters.AddWithValue("@alamat", alamat);
                    cmd.Parameters.AddWithValue("@kode_anggota", kode_anggota);
                    cmd.Parameters.AddWithValue("@tgl_daftar", tgl_daftar);
                    cmd.Parameters.AddWithValue("@biaya", biaya);
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
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM tbmember WHERE id=@id ", conn))
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
