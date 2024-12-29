using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pallets = { "B14", "A11", "B12", "A13" };
            Console.WriteLine("Sorted...");
            Array.Sort(pallets);
            Printing(pallets);

            Array.Reverse(pallets);
            Console.WriteLine("Reversed...");
            Printing(pallets);

            static void Printing(string[] pallets)
            {
                foreach (string pallet in pallets)
                {
                    Console.WriteLine($" -- {pallet}");
                }
            }
            // Clear 
            Array.Clear(pallets, 0, 2); // Clear 2 elements starting from 0 index, setting to default values in that case to null 
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            Printing(pallets);

            // Modify 

            Console.WriteLine("Resizing...");
            Array.Resize(ref pallets, 6);
            Console.WriteLine(($"Resizing successfull - now array has {pallets.Length} elements"));

            pallets[4] = "C01";
            pallets[5] = "C02";

            Printing(pallets);

            // ToCharArray()
            string value = "123abc";
            char[] valueArray = value.ToCharArray();
            foreach (char c in valueArray)
            {
                Console.WriteLine($"- {c} -");
            }

            Array.Reverse(valueArray);

            string result = new string(valueArray);
            Console.WriteLine(result);

            string resultWithCommas = string.Join(".", valueArray);
            Console.WriteLine(resultWithCommas);

            string[] items = resultWithCommas.Split(".");
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

            // Write code to reverse each word in a message

            string pangram = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine($"Original message {pangram}");
            // create array of words
            string[] words = pangram.Split(" ");
            string reversedMessage = "";
            string[] reversedMessageArray = new string[words.Length];
            for (int i = 0;  i < words.Length; i++)
            {
                // convert each word into chars array
                char[] wordAsCharArray = words[i].ToCharArray();
                Array.Reverse(wordAsCharArray);
                reversedMessageArray[i] = new string(wordAsCharArray);
            }

            reversedMessage = string.Join(" ", reversedMessageArray);
            Console.WriteLine($" Reversed string : {reversedMessage}");



            // Data comes in many formats. In this challenge you have to parse the individual "Order IDs",
            // and output the "OrderIDs" sorted and tagged as "Error" if they aren't exactly four characters in length.

            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

            // create an array of orders
            string[] orders = orderStream.Split(",");

            Array.Sort(orders);

            foreach (string order in orders)
            {
                if (order.Length != 4)
                {
                    Console.WriteLine($"{order} \t - Error");
                }
                else { Console.WriteLine(order); }

            }


        }
    }
}
