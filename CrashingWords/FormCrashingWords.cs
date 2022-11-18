using System;
using System.IO;
using System.Windows.Forms;

namespace CrashingWords
{
    public partial class FormCrashingWords : Form
    {
        public FormCrashingWords()
        {
            InitializeComponent();
        }


        int crashingIndexPos;
        int lenght;

        private void BtnCrashingWords_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\words.txt";
            StreamReader streamReader = new StreamReader(path);

            string line1 = "";
            string line2 = "";


            while (true)
            {
                line1 = streamReader.ReadLine();
                line2 = streamReader.ReadLine();

                if (line1 == null || line2 == null)
                    break;

                string[,] words = new string[line1.Length, line1.Length];

                if (IsCrashingWords(line1, line2))
                {
                    lenght = line1.Length;
                    string firstWord = CheckWhichFirst(line1, line2);

                    if (firstWord == line1)
                    {
                        words = LoadWords(line1, line2);
                    }
                    else
                    {
                        words = LoadWords(line2, line1);
                    }
                }

                Display(words);
            }

        }

        private bool IsCrashingWords(string word1, string word2)
        {
            //The two words are always the same lenght as per the assignment.
            for (int i = 0; i < word1.Length; i++)
            {
                if(word1.Substring(i, 1) == word2.Substring(i, 1))
                {
                    crashingIndexPos = i;
                    return true;
                }
            }

            return false;
        }

        private string CheckWhichFirst(string word1, string word2)
        {
            int posWord1 = 0;
            int posWord2 = 0;

            string[] alphabet = new string[27]
                { "", "A", "B", "C", "D", "E", "F", "G", "I", "H", "J", "K", "L",
                "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W",
                "X", "Y", "Z" };

            for (int i = 1; i <= 26; i++)
            {
                if (word1.Substring(0, 1) == alphabet[i])
                {
                    posWord1 = i;
                }

                if (word2.Substring(0, 1) == alphabet[i])
                {
                    posWord2 = i;
                }
            }

            if (posWord1 < posWord2)
            {
                return word1;
            }
            else
            {
                return word2;
            }
        }

        private string[,] LoadWords(string word1, string word2)
        {
            string[,] display = new string[word1.Length, word1.Length];

            for (int i = 0; i < word1.Length; i++)
            {
                for (int j = 0; j < word1.Length; j++)
                {
                    if (j == crashingIndexPos)
                    {
                        display[i, j] = word1.Substring(i, 1);
                    }
                    else
                    {
                        display[i, j] = " ";
                    }
                }
            }

            for (int i = 0; i < word1.Length; i++)
            {
                for (int j = 0; j < word1.Length; j++)
                {
                    if (i == crashingIndexPos)
                    {
                        display[i, j] = word2.Substring(j, 1);
                    }
                }
            }
            return display;
        }

        private void Display(string[,] words)
        {
            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght; j++)
                {
                    TxtResult.Text += words[i, j];
                }
            }
        }
    }
}
