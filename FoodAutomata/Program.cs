using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodAutomata
{
    class Program
    {
        static ConsoleKeyInfo keyinfo;
        public static void Main()
        {
            GenerateTable();
            Console.WriteLine("Press x to exit the application;");           
            do
            {
                DrawUI();
                keyinfo = Console.ReadKey(true);
                

            }
            while (keyinfo.Key != ConsoleKey.X);
        }

        static void DrawUI()
        {
           // Console.Clear();
        }

        static void GenerateTable()
        {
            Cell[] cells=new Cell[9];
            int counter = -1;
            foreach (Tuple<int, string> tuple in DataSource)
                cells[++counter] = new Cell(tuple.Item1, tuple.Item2);
        }

        static readonly Tuple<int, string>[] DataSource = 
        {
            Tuple.Create(59,"Potato"),
            Tuple.Create(100,"Soda"),
            Tuple.Create(29,"Parsnip")
        };
    }

    class Cell
    {
        public int Cost { get; set; }
        public string Name { get; set; }

        public Cell(int cost,string name)
        {
            Cost = cost;
            Name = name;
        }
    }
}
