using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject
{
    public class CmdProgram
    {
        private List<Product> cart;
        private List<float> prices;
        public CmdProgram(String[] args)
        {

        }
        public void Run()
        {
            Console.WriteLine("There are no plaza created yet! Press\n1) to create a new plaza.\n2) to exit.");
            string userInput = Console.ReadLine();
            if(userInput.Equals("1"))
            {

            }
            else if(userInput.Equals("2"))
            {
                System.Environment.Exit(1);
            }
            else
            {
                throw new Exception("No choice like that!");
            }
        }
    }
}
