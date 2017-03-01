using SoftDeleteEntityFrameworkGettingStarted.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDeleteEntityFrameworkGettingStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var game in new DataContext().Games)
            {
                Console.WriteLine(game.Name);
            }

            Console.ReadLine();
        }
    }
}
