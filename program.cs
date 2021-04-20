using System;
using System.Collections.Generic;

namespace arrays_and_lists {
    class program {
        static void Main(string[] args) {
            

            /*array_example_1();
            Console.WriteLine(array_example_2());*/
        }

        static public void array_example_1() {
            int array_size = 5;

            string[] names = new string[array_size];
             
            names[0] = "Steven"; 
            names[1] = "Bob"; 
            names[2] = "Will";
            names[3] = "James"; 
            names[4] = "Matt";
            
            for (int i = 0; i < array_size; i ++) {
                Console.WriteLine("Hello " + names[i]);
            }
        }

        static public int array_example_2() {
            int[] numbers = { 34,5,67,1,99,34,44,78,34,0 };

            int ret = 0;

            foreach (int i in numbers) {
                ret += i;
            }

            return ret;
        }

        static public void list_example_1(int input) {
            var list = new List<int>(); 
            var random = new Random();

            for (int i = 0; i < 5; i ++) {
                list.Add(random.Next(1, 10));
                Console.WriteLine(input == list[i] ? list[i] + " <" : list[i]);
            }
        }
    }
}
