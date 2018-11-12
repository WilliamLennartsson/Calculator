using System;
namespace Calculator
{
    public class Calculator
    {
        
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        float numberInMemory;

        public Calculator()
        {
            clear();

        }

        public void clear()
        {
            FirstNumber = 0;
            SecondNumber = 0;
            numberInMemory = 0;
        }

        public string printToString()
        {
            string pattern = @"
                First number: {0}
                Second number: {1}
                In memory: {2}";
            return string.Format(pattern, FirstNumber, SecondNumber, numberInMemory);
        }

        public float multiplyNumbers()
        {
            return FirstNumber * SecondNumber;
        }

        public void setFirstAndSecond(int first, int second)
        {
            FirstNumber = first;
            SecondNumber = second;
        }

        public float sumNumbers()
        {
            return FirstNumber + SecondNumber;
        }

        public float sumInbetween()
        {
            int a = FirstNumber;
            int b = SecondNumber;
            if (FirstNumber > SecondNumber)
            {
                a = SecondNumber;
                b = FirstNumber;
            }
            
            int sum = 0;
            for (int i = a; i < b + 1; i++)
            {
                sum += i;
            }
            return sum;
        }

        public void storeNumber(int val)
        {
            numberInMemory = val;
        }

        public void removeFromMemory()
        {
            numberInMemory = 0;
        }
    }
}

