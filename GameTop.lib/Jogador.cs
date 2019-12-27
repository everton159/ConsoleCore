using System;
using GameTOP.Interface;

namespace GameTop.lib
{
    public class Jogador : IJogador
    {
        public readonly string _Nome;


        public Jogador(string nome)
        {
            this._Nome = nome;
        }



        public string chuta()
        {
            return ($"{_Nome} o jogador está chutando \n");
        }

        public string corre()
        {
            return ($"{_Nome} o jogador está correndo \n");
        }
        public string passe()
        {
            return ($"{_Nome} o jogador está passendo \n");
        }
    }
}
