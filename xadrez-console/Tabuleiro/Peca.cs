using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    abstract class  Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get;protected set; }
        public Tabuleiro Tab { get; set; }


        public Peca ( Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            QtdMovimentos = 0;
        }

        public bool PodeMoverParaPosicao(Posicao pos)
        {

            return MovimentosPossiveis()[pos.Linha, pos.Coluna]; 
        }

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for(int i = 0; i < Tab.Linhas;i++)
            {
                for(int j = 0; j<Tab.Colunas; j++)
                {
                    if(mat[i,j] == true)
                    {
                        return true;
                    } else
                    {
                        
                    }
                }
            }
            return false;
        }

        public void IncrementarQtdMovimentos()
        {
            QtdMovimentos++;
        }

        public void DecrementarQtdMovimentos()
        {
            QtdMovimentos--;
        }

        public abstract bool[,] MovimentosPossiveis();
       
    }
}
