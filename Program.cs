using System.Xml.Linq;

namespace Class_0515_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IName n1 = new Person();
            Console.WriteLine(n1.GetData());
            Console.WriteLine(n1.GetName());
        }
    }
}
