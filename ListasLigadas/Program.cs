using System;

namespace ListasLigadas
{
    class Program
    {
        static void Main(string[] args)
        {
            CListaLigada miLista = new CListaLigada();
            //Cambio en el program
            //Cambio local
            miLista.Adicionar(3);
            miLista.Adicionar(8);
            miLista.Adicionar(1);
            miLista.Adicionar(6);
            miLista.Adicionar(4);
            miLista.Adicionar(15);

            miLista.Transversa();
        }
    }
}
