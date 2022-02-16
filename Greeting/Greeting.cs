using Greeting.Chain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Greeting : IGreetingHandler
    {
        public IGreetingHandler SetNext(IGreetingHandler greetingHandler)
        {
            
        }
        public string Handle(params string[] names)
        {

            string nulled = "Hello, my friend";
            string name = Console.ReadLine();
            string greet = $"Hello, {name}";
            Console.WriteLine(greet);

            if (name == null)
                return nulled;

            bool IsAllUpper(string name)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (!Char.IsUpper(name[i]))
                        return false;
                }

                return true;
            }

            if (IsAllUpper == false)
            {
                Console.WriteLine(greet);
            }
            else
            {
                Console.WriteLine(greet.ToUpper());
            }



        }
        public static string TwoNames()
        {
            string[] friends = new string[1];
            var result = "";
            Console.WriteLine("Hello, ");

            Console.WriteLine("[{0}{1}]", string.Join(",", friends));

        }

        public static string ThreeNames()
        {

            string[] friends = new string[].Length;
            var result = "";
            Console.WriteLine("Hello, ");

            Console.WriteLine(friends.All, string.Join(",", friends));

        }

        public static string MixedCase()
        {
            string[] friends = new string[].Length;
            var result = "";
            Console.WriteLine("Hello, ");
            if (input.ToUpper() == input)
            {

                Console.WriteLine(friends.All, string.Join(",", friends));

            }
        }

    }
}
}
