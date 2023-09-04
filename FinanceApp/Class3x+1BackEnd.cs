using System;
using System.Collections.Generic;

namespace FinanceApp
{
    public class Class3x_1BackEnd
    {
        LinkedList<int> resultLinkedList = new LinkedList<int>();
        int result = 0;
        string sequence = "";

        public LinkedList<int> CalculateAndStoreCollatzSequence(int input)
        {
            resultLinkedList.Clear();
            // Check for valid input (positive integer)
            if (input <= 0)
            {
                throw new ArgumentException("Input must be a positive integer.");
            }

            result = input;

            while (result != 1)
            {
                if (result % 2 == 0)
                {
                    // If the current number is even, divide it by 2
                    result /= 2;
                }
                else
                {
                    // If the current number is odd, apply 3x + 1
                    result = 3 * result + 1;
                }

                ResultLinkedList.AddLast(result);

                // Add a termination condition to avoid infinite loops
                if (ResultLinkedList.Count > 1000) // You can adjust this limit as needed
                {
                    throw new InvalidOperationException("Sequence reached a limit of 1000 iterations.");
                }
            }

            Sequence = ("Collatz sequence for " + input + ": " + string.Join(", ", ResultLinkedList));

            return ResultLinkedList;
        }

        public LinkedList<int> ResultLinkedList { get => resultLinkedList; set => resultLinkedList = value; }
        public string Sequence { get => sequence; set => sequence = value; }
    }
}
