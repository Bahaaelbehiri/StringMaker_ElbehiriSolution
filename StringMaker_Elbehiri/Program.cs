// Bahaa Elbehiri
// IT113

using StringMaker_Elbehiri;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace StringMaker_Elbehiri
{
    class Program
    {
        static void Main(string[] args)
        {
            StringManager SM = new StringManager();    
            string str = "Sunbeam Tiger";
            Console.WriteLine(SM.Reverse(str));
            Console.WriteLine(SM.ToString());
            bool equals = str.Equals(str);
            Console.WriteLine(equals);
            Console.WriteLine(SM.Reverse(str, true));

            str = "ABBA";
            bool Sym = SM.Symmetric(str);
            if (Sym)
            {
                Console.WriteLine(str + " is Symmetric");
            }
            else
            {
                Console.WriteLine(str + " is Not Symmetric");
            }

            str = "ABA";
            bool Sym1 = SM.Symmetric(str);
            if (Sym1)
            {
                Console.WriteLine(str + " is Symmetric");
            }
            else
            {
                Console.WriteLine(str + " is Not Symmetric");
            }

            str = "ABba";
            bool Sym2 = SM.Symmetric(str);
            if (Sym2)
            {
                Console.WriteLine(str + " is Symmetric");
            }
            else
            {
                Console.WriteLine(str + " is Not Symmetric");
            }

            str = "Dan";
        }
    }
}