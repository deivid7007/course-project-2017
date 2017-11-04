using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    /*
        1. Name method like: 
        _12_0328009_LyubenKikov 
        or 
        _7_II_0328009_LyubenKikov

        2. Include it in your group method
        3. Implementation of the task should be placed in 'Private methods' region
    */
    class Program
    {
        static void Main(string[] args)
        {
            STD1A();
            STD3A();
        }

        #region Groups

        private static void STD1A()
        {
            _12_0328009_LyubenKikov();
            // your code goes here
        }

        private static void STD3A()
        {
            _7_II_0328009_LyubenKikov();
            // your code goes here
        }

        #endregion

        #region Private methods

        private static void _12_0328009_LyubenKikov()
        {
            Console.WriteLine("Hello STD 1A");
        }

        private static void _7_II_0328009_LyubenKikov()
        {
            Console.WriteLine("Hello STD 3A");
        }

        #endregion

    }
}
