using System;
using System.Collections.Generic;
using System.Text;

namespace SneakyBox_1
{
    class LocalTest 
    {
        static void Main(string[] args)
        {
            SBox_1Modifier sneakyBoxMod = new SBox_1Modifier();
            sneakyBoxMod.PopulateWithData(0);
            //Console.WriteLine(sneakyBoxMod.Action("5"));

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(sneakyBoxMod.Action(i.ToString()));
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
