using System;
using GameTop.lib;

namespace GameTop
{
    class JogoFoda
    {

        private readonly Jogador _jogador;
        
        public JogoFoda(Jogador jogador)
        {
            this._jogador =  jogador;        
        }

     
        public void IniciarJogo()
        {
            Console.Write(_jogador.corre());
            Console.Write(_jogador.chuta());
            Console.Write(_jogador.passe());
        }
    }
}
