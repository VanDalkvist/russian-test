using System.Collections.Generic;
using System.IO;
using System.Text;
using System;

namespace RussianTest
{
    internal class Test
    {
        #region Test members

        private List<Question> questions;
        private int countRight = 0;

        public Test() { }

        public Test(string nameFile)
        {
            questions = new List<Question>();

            try
            {
                Encoding enc = Encoding.GetEncoding(1251);
                StreamReader reader = new StreamReader(nameFile, enc);
                string line = "";
                string[] right;
                Question question;
                string responce;
                int[] rightResponce;
                while ((line = reader.ReadLine()) != null)
                {
                    responce = reader.ReadLine();
                    right = (reader.ReadLine()).Split(new Char[] { ';', ',', '/' });
                    rightResponce = new int[right.Length];
                    for (int i = 0; i < right.Length; i++)
                        rightResponce[i] = Convert.ToInt32(right[i]);
                    question = new Question(line, responce, rightResponce);
                    countRight += right.Length;
                    questions.Add(question);
                }
                reader.Close();
            }
            catch (FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("Файл не найден!");
            }
        }

        public Question this[int index]
        {
            get { return questions[index]; }
        }

        public int CountOfRightResponces
        {
            get { return countRight; }
        }

        public int Length
        {
            get { return questions.Count; }
        }

        #endregion
    }
}
