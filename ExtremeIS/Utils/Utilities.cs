using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace ExtremeIS.Utils
{
    class Utilities
    {

        //Returns salted password hash (including a different salt values through iterations)
        public static string getPasswordHash(String pass, String salt)
        {
            var pswh = pass;
            var slt = salt;
            using (SHA256 shaHash = SHA256.Create())
            {
                int iterations = 5;
                while ((iterations--) > 0)
                {
                    byte[] data = shaHash.ComputeHash(Encoding.UTF8.GetBytes(pswh + slt));
                    StringBuilder sBuilder = new StringBuilder();
                    for (int i = 0; i < data.Length; i++)
                        sBuilder.Append(data[i].ToString("x2"));
                    pswh = sBuilder.ToString();
                    slt = slt + iterations;
                }
            }
            return pswh;
        }

    }
}
