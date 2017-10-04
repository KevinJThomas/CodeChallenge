using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public interface IMethod
    {
        string Execute(string input);
    }
    class Program : IMethod
    {
        static void Main(string[] args)
        {
            var test = "ok";
            var testing = new Program();
            Console.WriteLine(testing.Execute(test));
            Console.ReadLine();
        }

        public string Execute(string input)
        {
            string result;
            var test = input.Length % 2 == 0 ? Test(input) ? TestThree(input) : Test(input) : TestTwo(input);
            if (test == null || test)
            {
                goto Are;
            }

            Are:
                result = TestFour(input);
            You:
                TestFour(input);
            Confused:
                TestFour(input);
            Yet:
                TestFour(input);


            return result;
        }

        public bool Test(string input)
        {
            return true;
        }

        public bool TestTwo(string input)
        {
            return true;
        }

        public bool TestThree(string input)
        {
            return true;
        }

        public string TestFour(string input)
        {
            return input + " :)";
        }
    }
}
