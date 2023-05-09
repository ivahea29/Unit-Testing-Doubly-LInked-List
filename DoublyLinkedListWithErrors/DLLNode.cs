using System;

namespace DoublyLinkedListWithErrors
{
    public class DLLNode
    {
        public int num;   // field of the node
        public DLLNode next; // pointer to the next node
        public DLLNode previous; // pointer to the previous node
        public DLLNode(int num)
        {
            this.num = num; // assigns the input value num to the num field of the current instance.
            next = null; // initializes the next field to null.
            previous = null; // initializes the previous field to null.
        } // end of constructor
        // IsPrime Method
        public Boolean isPrime(int n)
        {
            Boolean b = true;
            if (n < 2) // check if the number is less than 2
            {
                return (false); // if it is, it is not a prime number
            }
            else // else
            {
                for (int i = 2; i < Math.Sqrt(n); i++) // loop through the number and check for divisibility
                {
                    if ((n % i) == 0) // if it is divisible by i, it is not a prime number
                    {
                        b = false;
                        break; // exit the loop since we already know it's not a prime number
                    }
                }
            }
            return (b); // return the boolean value
        } // end of isPrime
    } // end of class DLLNode
}
