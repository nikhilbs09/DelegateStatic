using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrivialDelegateStatic
{
    delegate string StringPrinter(string paramString);
    class Program
    {
        static void Main(string[] args)
        {
            var objTwo = new Two();
            var printer = new StringPrinter(Two.StaticMethod);
            Console.WriteLine(printer("koki-koki"));
            Console.WriteLine("\n" + printer.Invoke("oki-doki"));

            printer = new StringPrinter(objTwo.InstanceMethod);
            Console.WriteLine(printer("TomDickHarry"));

            Console.ReadLine();
        }
    }
    class Two
    {
        public static string StaticMethod(string valStrOne)
        {
            return string.Format("Static Output: {0}", valStrOne);
        }

        public string InstanceMethod(string valStrTwo)
        {
            return string.Format("\nInstance Output: {0}", valStrTwo);
        }
    }
}
