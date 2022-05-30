using System;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook[] notebooks = new Notebook[3];
            Notebook notebook1 = new Notebook()
            {
                Name = "For Notes",
                BrandName = "NodeB",
                Price = 50
            };
            Notebook notebook2 = new Notebook()
            {
                Name = "Drawing",
                BrandName = "DrawB",
                Price = 80

            };
            Notebook notebook3 = new Notebook()
            {
                Name = "Notes",
                BrandName = "NotesIO",
                Price = 40

            };
            notebooks[0] = notebook3;
            notebooks[1] = notebook1;
            notebooks[2] = notebook2;
            Console.WriteLine("minDeyeri daxil edin:");
            string notebooksStr = Console.ReadLine();



            
           


            
           



        }
    }
}
