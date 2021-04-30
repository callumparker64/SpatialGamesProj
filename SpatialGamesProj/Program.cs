using SpatialGames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpatialGamesProj
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Test test = new Test();
            Cooperator split = new Cooperator(2, 2, 0);

            Console.WriteLine("Hello World");
            Console.WriteLine(test.getValue());
            Console.WriteLine(split.xCoor);
            split.xCoor = 5;
            Console.WriteLine(split.xCoor);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserInterface());
        }
    }
}
