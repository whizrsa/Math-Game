using Math_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            var date = DateTime.UtcNow;
            var games = new List<Game>();

            string name = Helpers.GetName();
            menu.ShowMenu(name,date, games);

        }

    }
}
