using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GorselProgramlama_Proje
{
    class DB_Baglan
    {
        private SqlConnection con;
        private SqlDataAdapter da;
        private SqlCommand cmd;
        private DataSet ds;

        //Constructor
        public DB_Baglan()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            con = new SqlConnection("server=.; Initial Catalog=avukat;Integrated Security=SSPI");
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        //Insert statement
        public void Insert(string tablo_adi, string ad, string konu, string mAdi, string sAdi, string adliye, string turu, string bilgi, string mIletisim, string sIletisim, string mKimlik, string sKimlik)
        {
            string query = "INSERT INTO " + tablo_adi + " (dava_adi, dava_konusu, muvekkil_adi, sanik_adi, adliye_adi, dava_turu, dava_bilgi, muvekkil_iletisim, sanik_iletisim, muvekkil_kimlik, sanik_kimlik, durum) VALUES ('" + ad + "','" + konu + "','" + mAdi + "','" + sAdi + "','" + adliye + "','" + turu + "','" + bilgi + "','" + mIletisim + "','" + sIletisim + "','" + mKimlik + "','" + sKimlik + "',1)";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                cmd = new SqlCommand(query, con);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update(string tablo_adi,int id,string ad, string konu, string mAdi, string sAdi, string adliye, string turu, string bilgi, string mIletisim, string sIletisim, string mKimlik, string sKimlik)
        {
            string query = "UPDATE "+tablo_adi+ " SET dava_adi='" + ad + "', dava_konusu='" + konu + "', muvekkil_adi='" + mAdi + "', sanik_adi='" + sAdi + "', adliye_adi='" + adliye + "', dava_turu='" + turu + "', dava_bilgi='" + bilgi + "', muvekkil_iletisim='" + mIletisim + "', sanik_iletisim='" + sIletisim + "', muvekkil_kimlik='" + mKimlik + "', sanik_kimlik='" + sKimlik + "' WHERE id=" + id;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                cmd = new SqlCommand(query,con);

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete(string tablo_adi, int id)
        {
            string query = "UPDATE "+tablo_adi+" SET durum=0 WHERE id="+id;

            if (this.OpenConnection() == true)
            {
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public DataSet Select(string tablo_adi)
        {
            string query = "SELECT * FROM "+tablo_adi+ " WHERE durum=1 ORDER BY id DESC";

            //Open connection
            if (this.OpenConnection() == true)
            {
                da = new SqlDataAdapter(query, con);
                ds = new DataSet();
                da.Fill(ds, tablo_adi);
                
                //close Connection
                this.CloseConnection();
                return ds;
            }
            else
            {
                return null;
            }
        }

        public DataSet Select(string tablo_adi,int sayi)
        {
            string query = "SELECT TOP "+sayi+" * FROM "+tablo_adi+" WHERE durum=1 ORDER BY id DESC";

            //Open connection
            if (this.OpenConnection() == true)
            {
                da = new SqlDataAdapter(query, con);
                ds = new DataSet();
                da.Fill(ds, tablo_adi);

                //close Connection
                this.CloseConnection();
                return ds;
            }
            else
            {
                return null;
            }
        }

        public DataSet Select(string tablo_adi, string condition)
        {
            string query = "SELECT * FROM " + tablo_adi + " WHERE dava_adi LIKE '%" + condition + "%' OR dava_konusu  LIKE '%" + condition + "%' OR muvekkil_adi  LIKE '%" + condition + "%' OR sanik_adi  LIKE '%" + condition + "%' OR adliye_adi  LIKE '%" + condition + "%' OR dava_turu  LIKE '%" + condition + "%' OR dava_bilgi  LIKE '%" + condition + "%' AND durum=1;";

            //Open connection
            if (this.OpenConnection() == true)
            {
                da = new SqlDataAdapter(query, con);
                ds = new DataSet();
                da.Fill(ds, tablo_adi);

                //close Connection
                this.CloseConnection();
                return ds;
            }
            else
            {
                return null;
            }
        }

        public DataSet Select(int id, string tablo_adi)
        {
            string query = "SELECT * FROM " + tablo_adi + " WHERE durum=1 AND id="+id;

            //Open connection
            if (this.OpenConnection() == true)
            {
                da = new SqlDataAdapter(query, con);
                ds = new DataSet();
                da.Fill(ds, tablo_adi);

                //close Connection
                this.CloseConnection();
                return ds;
            }
            else
            {
                return null;
            }
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM davalar WHERE durum=1";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                cmd = new SqlCommand(query, con);
          
                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
    }
}
