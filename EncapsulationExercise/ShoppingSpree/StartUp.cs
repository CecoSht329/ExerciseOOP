﻿using System;

namespace ShoppingSpree
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                Engine engine = new Engine();
                engine.Run();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
