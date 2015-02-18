using System;
using System.Collections.Generic;

namespace RussianTest
{
    internal class Question
    {
        #region Question members

        private string question;
        private string[] responces;
        private List<int> rightResponce;

        public Question(string question, string responce, int[] rightResponce)
        {
            this.rightResponce = new List<int>();
            this.question = question;
            responces = responce.Split(new Char[] { ';' });
            this.rightResponce.AddRange(rightResponce);
        }

        public bool IsRight(int indexItem)
        {
            return rightResponce.Contains(indexItem);
        }

        public override string ToString()
        {
            return question;
        }

        public int CountOfResponces
        {
            get { return this.responces.Length; }
        }

        public string this[int index]
        {
            get { return responces[index]; }
        }

        #endregion
    }
}
