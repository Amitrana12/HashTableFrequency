using System;

namespace FrequencyHash
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to My HashTable Application BY AMIT RANA");
            /* MyMapNode<int, string> hash = new MyMapNode<int, string>(6);
             hash.Add(0, "To");
             hash.Add(1, "be");
             hash.Add(2, "or");
             hash.Add(3, "not");
             hash.Add(4, "to");
             hash.Add(5, "be");*/
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] para = paragraph.Split(" ");
            MyMapNode<int, string> hash = new MyMapNode<int, string>(para.Length);
            int key = 0;
            foreach (string word in para)
            {
                hash.Add(key, word);
                key++;
            }
            Operation operation = new Operation();
            //operation.Frequency(hash);
            operation.Remove(hash, "are");
        }
    }
}
