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
        public enum dzialanie { mnozenie = 0, dzielenie = 1}
        public string[] caindOfTask = { "Multiplier", "Div" };
        public string selectedOperation;
        public CalculateRandomTask()
        {
            num1 = rand.Next(1, 11);
            num2 = rand.Next(1, 11);
        }

        public int RandomTask(int randomOperation)
        {
            selectedOperation = caindOfTask[randomOperation];
            if (selectedOperation == caindOfTask[0])
            {
                return num1 * num2;
            }
            else if (selectedOperation == caindOfTask[1])
            {
                return (num1 * num2) /num2;
            }
            return 0;
        }
    }
}
