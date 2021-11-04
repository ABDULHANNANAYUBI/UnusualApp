using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHome1_OOP_Lab
{
    class Ceaser : EncryptionClass
    {
        public string Encrypt(string Alp, string str, string RotValue)
        {
            int max = int.MinValue;
            object obj = "";
            
            for (int i = 0; i < str.Length; i++)
            {
                if (max < Alp.IndexOf(str[i]))
                {
                    max = Alp.IndexOf(str[i]);
                }
            }
            if (Convert.ToInt32(RotValue) > Alp.Length || ((Alp.Length-max-1) - Convert.ToInt32(RotValue) < 0) || Convert.ToInt32(RotValue) < 0)
            {
                return "Error!" + Environment.NewLine + "Rot value is not valid.";
            }
            for(int i = 0; i < str.Length; i++)
            {
                if(Alp.IndexOf(str[i]) < 0)
                {
                    return "Error!" + Environment.NewLine + "The String is not in Alphabets";
                }
            }
            string temp = ""; 
            for (int i = 0; i < str.Length ; i++)
            {
                temp += (Alp[Alp.IndexOf(str[i % Alp.Length]) + (Convert.ToInt32(RotValue))]);
            }
            return temp;
        }
        public string Decrypt(string Alp, string str, string RotValue)
        {
            string temp = "";

            int min = int.MaxValue;
            for (int i = 0; i < str.Length; i++)
            {
                if(min > Alp.IndexOf(str[i]))
                {
                    min = Alp.IndexOf(str[i]);
                }
                
            }

            if (Convert.ToInt32(RotValue) > Alp.Length || (min - Convert.ToInt32(RotValue) < 0) || Convert.ToInt32(RotValue) < 0) 
            {
                return "Error!" + Environment.NewLine + "The Rot Value is not valid.";
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (Alp.IndexOf(str[i]) < 0)
                {
                    return "Error!" + Environment.NewLine + "The String is not in Alphabets";
                }
            }
            
            for (int i = 0; i < str.Length; i++)
            {
                temp += (Alp[Alp.IndexOf(str[i % Alp.Length]) - (Convert.ToInt32(RotValue))] );
            }
            return temp;
        }

    }
}
