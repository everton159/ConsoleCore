using System;
using GameTop.lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var jogo = new JogoFoda( new Jogador("Everton"));
            jogo.IniciarJogo();
        }
    }

}
