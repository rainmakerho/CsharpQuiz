using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CsharpQuiz
{

    //http://www.volatileread.com/Wiki/Index?id=1073

    [TestClass]
    public class PredictOutputChallenge
    {
        [TestMethod]
        public void DynamicMess()
        {
            byte b= 1;
            dynamic d = b;
            Console.WriteLine(d.GetType());
            d = 1;
            Console.WriteLine(d.GetType());
        }

        [TestMethod]
        public void EnumerableNuance()
        {
            GetChars(null);
            Console.WriteLine("done!");
        }

        static IEnumerable<char> GetChars(string input)
        {
            if (input == null)
                throw new ArgumentNullException(input);

            foreach (char c in input)
                yield return c;
        }
    }
}
