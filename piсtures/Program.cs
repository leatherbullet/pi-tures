using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piсtures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pictures = 52;
            int picturesInRow = 3;
            int page;
            int overage;

            page = pictures / picturesInRow;
            overage = pictures % picturesInRow;

            Console.WriteLine($"Всего рядов: {page}, остаток: {overage}");

        }
    }
}
