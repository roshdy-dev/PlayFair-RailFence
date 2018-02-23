using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayFair
{
    public abstract class Security
    {
        protected readonly Dictionary<char, int> alphabet;

        public Security()
        {
            alphabet = new Dictionary<char, int>();
            char c = 'a';
            alphabet.Add(c, 0);
           
            for (int i = 1; i < 26; i++)
            {
                alphabet.Add(++c, i);
            }
          
        }

        public abstract string Encrypt(string plainText);

        public abstract string Decrypt(string cipher);
    }
}
