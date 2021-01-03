﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace DAO
{
    public class DBProvider
    {
        protected SqlConnection _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GUI.Properties.Settings.Setting"].ConnectionString);
        //protected SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-NATE\SQLEXPRESS;Initial Catalog=TTCSDL;Integrated Security=True");

        public bool Login(string user, string pass)
        {
            string hashedPass = HashPass(pass);

            string query;

            if (user.Contains("TN"))
            {
                query = "SELECT * FROM THUNGAN WHERE MATHUNGAN = '" + user + "' AND PASSWORD = '" + hashedPass + "'";
            }
            else
            {
                query = "SELECT * FROM BACSY WHERE MABS = '" + user + "' AND MATKHAU = '" + hashedPass + "'";
            }

            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            
            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
            }
            return false;

          }
          #region Hashing Pass
          public string HashPass(string pass)
          {
               SHA1 shaH = new SHA1CryptoServiceProvider();
               MD5 md5H = new MD5CryptoServiceProvider();

               byte[] step1 = md5H.ComputeHash(Encoding.ASCII.GetBytes(pass));
               string strs1 = ByteArrayToString(step1);
               byte[] step2 = shaH.ComputeHash(Encoding.ASCII.GetBytes(strs1));

               string hashedPass = ByteArrayToString(step2);
               return hashedPass;
          }

          public static string ByteArrayToString(byte[] ba)
          {
               StringBuilder hex = new StringBuilder(ba.Length * 2);
               foreach (byte b in ba)
                    hex.AppendFormat("{0:x2}", b);
               return hex.ToString();
          }
          #endregion
     }
}