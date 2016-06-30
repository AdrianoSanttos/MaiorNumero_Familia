using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SiblingAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            //O número irmão é solicitado
            Console.WriteLine("Enter a number:", num);
            num = Convert.ToInt32(Console.ReadLine());
            
            int returnMain = Solution(num);
            //O Console mostra o maior numero da familia
            Console.WriteLine("Biggest value of the number family: {0}", returnMain);
        }

        static private int Solution(int N)
        {
            int nReturn = 0;
            //O número digitado é armazenado dentro do Array
            int[] eachNumber = N.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            //O Array é ordenado de forma decrescente, gerando assim o maior numero 
            string strBiggestValue = string.Join("", eachNumber.OrderByDescending(x => x));

            //Se o resultado for superior a 100 milhões, retorna -1
            if (Convert.ToInt32(strBiggestValue) > 100000000)
                nReturn = -1;
            else
                nReturn = Convert.ToInt32(strBiggestValue);

            return nReturn;
        }
    }
}
