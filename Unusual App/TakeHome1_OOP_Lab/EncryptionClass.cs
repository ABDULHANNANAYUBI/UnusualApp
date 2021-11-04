using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHome1_OOP_Lab
{
    interface EncryptionClass
    {
        
        string Encrypt(string Alp, string str , string RotValue);
        string Decrypt(string Alp, string str, string RotValue);

    }
}
