using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace MethodHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            Show(name, num);
        }
        static string Show(string name, int num)
        {
            string fullText = "Hello, Dear " + name;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(fullText);
            }
            return fullText;
        }
    }
}