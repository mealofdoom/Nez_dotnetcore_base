using FNATemplate.Game;
using System;

namespace FNATemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var game = new TemplateClient())
            {
                game.Run();
            }
        }
    }
}
