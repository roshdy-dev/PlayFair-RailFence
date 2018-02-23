using System;
using System.Collections.Generic;
using System.Linq;


namespace PlayFair
{
    internal enum Mode
    {
        Encrypt, Decrypt
    }

    class PlayFair:Security
    {
        string key;

        public PlayFair(string key)
        {
            this.key = key.ToLower() ;
        }
        #region Public Methods
        public override string Encrypt(string plainText)
        {
            return Process(plainText, Mode.Encrypt);
        }

        public override string Decrypt(string cipherText)
        {
            return Process(cipherText, Mode.Decrypt);
        }
        #endregion

      
        
        
        #region Encapsulated Methods
        private string Process(string message, Mode mode)
        {
            //Key:Character
            //Value:Position
            Dictionary<char, string> characterPositionsInMatrix = new Dictionary<char, string>();

            //Key:Position
            //Value:Character
            Dictionary<string, char> positionCharacterInMatrix = new Dictionary<string, char>();

            FillMatrix(key.Distinct().ToArray(), characterPositionsInMatrix, positionCharacterInMatrix);

            if (mode == Mode.Encrypt)
            {
                message = RepairWord(message);
            }

            string result = "";

            for (int i = 0; i < message.Length; i += 2)
            {
                //get characters from text by pairs
                string substring_of_2 = message.Substring(i, 2);
                //get Row & Column of each character
                string rc1 = characterPositionsInMatrix[substring_of_2[0]];
                string rc2 = characterPositionsInMatrix[substring_of_2[1]];

                // Same Row, different Column
                if (rc1[0] == rc2[0])
                {
                    int newC1 = 0, newC2 = 0;

                    switch (mode)
                    {
                        case Mode.Encrypt://Increment Columns
                            newC1 = (int.Parse(rc1[1].ToString()) + 1) % 5;
                            newC2 = (int.Parse(rc2[1].ToString()) + 1) % 5;
                            break;
                        case Mode.Decrypt://Decrement Columns
                            newC1 = (int.Parse(rc1[1].ToString()) - 1) % 5;
                            newC2 = (int.Parse(rc2[1].ToString()) - 1) % 5;
                            break;
                    }

                    newC1 = RepairNegative(newC1);
                    newC2 = RepairNegative(newC2);

                    result += positionCharacterInMatrix[rc1[0].ToString() + newC1.ToString()];
                    result += positionCharacterInMatrix[rc2[0].ToString() + newC2.ToString()];
                }

                //Same Column, different Row
                else if (rc1[1] == rc2[1])
                {
                    int newR1 = 0, newR2 = 0;

                    switch (mode)
                    {
                        case Mode.Encrypt://Increment Rows
                            newR1 = (int.Parse(rc1[0].ToString()) + 1) % 5;
                            newR2 = (int.Parse(rc2[0].ToString()) + 1) % 5;
                            break;
                        case Mode.Decrypt://Decrement Rows
                            newR1 = (int.Parse(rc1[0].ToString()) - 1) % 5;
                            newR2 = (int.Parse(rc2[0].ToString()) - 1) % 5;
                            break;
                    }
                    newR1 = RepairNegative(newR1);
                    newR2 = RepairNegative(newR2);

                    result += positionCharacterInMatrix[newR1.ToString() + rc1[1].ToString()];
                    result += positionCharacterInMatrix[newR2.ToString() + rc2[1].ToString()];
                }

                //Different Row & Column
                else
                {
                    //1st character:row of 1st + col of 2nd
                    //2nd character:row of 2nd + col of 1st
                    result += positionCharacterInMatrix[rc1[0].ToString() + rc2[1].ToString()];
                    result += positionCharacterInMatrix[rc2[0].ToString() + rc1[1].ToString()];
                }
            }

            return result;
        }

        private string RepairWord(string message)
        {
            string trimmed = message.Replace(" ", "");
            string result = "";

            for (int i = 0; i < trimmed.Length; i++)
            {
                result += trimmed[i];
              
                //Check if two consecutive letters are the same
                if (i < trimmed.Length - 1 && message[i] == message[i + 1] && (i%2 == 0 && i+1 % 2 != 0)) 
                {
                    result += 'x';
                }
            }

            //Check if Plain Text length is ODD
            if (result.Length % 2 != 0)
            {
                result += 'x';
            }

            return result;
        }

        private void FillMatrix(IList<char> key, Dictionary<char, string> characterPositionsInMatrix, Dictionary<string, char> positionCharacterInMatrix)
        {
            char[,] matrix = new char[5, 5];
            int keyPosition = 0, charPosition = 0;
            List<char> alphabetPF = alphabet.Keys.ToList();
            alphabetPF.Remove('j');

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    // Fill Matrix with Key Provided By User
                    if (charPosition < key.Count)
                    {
                        matrix[i, j] = key[charPosition];//fill matrix with key
                        alphabetPF.Remove(key[charPosition]);
                        charPosition++;
                    }
                    //key finished...fill with rest of alphabet
                    else
                    {
                        matrix[i, j] = alphabetPF[keyPosition];
                        keyPosition++;
                    }

                    string position = i.ToString() + j.ToString();
                    //store character positions in dictionary to avoid searching everytime
                    characterPositionsInMatrix.Add(matrix[i, j], position);
                    positionCharacterInMatrix.Add(position, matrix[i, j]);
                }
            }
        }

        private int RepairNegative(int number)
        {
            if (number < 0)
            {
                number += 5;
            }

            return number;
        }
        #endregion


    }
}
