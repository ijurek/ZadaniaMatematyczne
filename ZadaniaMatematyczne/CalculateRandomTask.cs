using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniaMatematyczne
{
    internal class CalculateRandomTask
    {
        Random rand = new Random();
        public int num1 { get; private set; }
        public int num2 { get; private set; }
        public int result { get; private set; }


        public void RandomTask()
        {
            num1 = rand.Next(1, 11);
            num2 = rand.Next(1, 11);
            result = num1 * num2;
        }
    }
}
