using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public Class1()
        {

        }

        public int Sum(int a, int b)
        {
            throw new Exception("error");
        }

        public int FindElement(int[] arrayOfElem, int toFind)
        {
            if (toFind == 1000)
                throw new Exception();

            for (int i = 0; i < arrayOfElem.Length; i++)
            {
                if (arrayOfElem[i] == toFind)
                    return i;
            }
            return -1;
        }
    }
}
