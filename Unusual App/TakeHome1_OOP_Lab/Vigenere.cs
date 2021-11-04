using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHome1_OOP_Lab
{
    class Vigenere : EncryptionClass
    {
        public string Encrypt(string Alp, string str, string Key)
        {
            string temp = "";
            if (Key.Length > str.Length)
            {
                return "Error";
            }

            for (int i = 0; i < str.Length; i++)
            {
                if ((Alp.IndexOf(str[i]) + 1) + (Alp.IndexOf(Key[i % Key.Length])) >= Alp.Length)
                    return "Error";
            }

            for (int i = 0; i < str.Length; i++)
            {

                temp += Alp[(Alp.IndexOf(str[i]) + 1) + (Alp.IndexOf(Key[i % Key.Length]))];
            }

            return temp;
        }
        public string Decrypt(string Alp, string str, string Key)
        {
            string temp = "";
            if (Key.Length > str.Length)
            {
                return "Error";
            }

            for (int i = 0; i < str.Length; i++)
            {
                if ((Alp.IndexOf(str[i]) /*-1*/) - (Alp.IndexOf(Key[i % Key.Length])) <= 0)
                {
                    int DENEME = (Alp.IndexOf(str[i]) - 1) - (Alp.IndexOf(Key[i % Key.Length]));
                    return "Error";

                }
            }

            for (int i = 0; i < str.Length; i++)
            {

                temp += Alp[(Alp.IndexOf(str[i]) - 1) - (Alp.IndexOf(Key[i % Key.Length]))];
            }

            return temp;
        }


    }
}
