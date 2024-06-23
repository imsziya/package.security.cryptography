using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Package.Security.Cryptography.Contrasts
{
    public interface ICryptographyService
    {
        public string Encrypt(string plainText);

        public string Decrypt(string cipherText);
    }
}
