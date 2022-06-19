using System;
using System.Collections.Generic;
using System.Text;

namespace ListasLigadas
{
    class CListaLigada
    {
        //Es el ancla o encabezado de la lista
        private CNodo ancla;

        //Esta variable de referencia nos ayuda a trabajar con la lista
        private CNodo trabajo;

        //Esta variable de referencia apoya en ciertas operaciones de la lista
        private CNodo trabajo2;

        public CListaLigada()
        {
            //Instanciamos el ancla
            ancla = new CNodo();

            //Como es una lista vacía su siguiente es null
            ancla.Siguiente = null;    

        }

        //Recorre la lista
        public void Transversa()
        {
            //Trabajo al inicio
            trabajo = ancla;

            //Recorremos hasta encontrar el final

            while(trabajo.Siguiente != null)
            {
                //Avanzamos trabajo
                trabajo = trabajo.Siguiente;

                //Obtenemos el dato y lo mostramos
                int d = trabajo.Dato;

                Console.Write("{0}, ", d);
            }

            //Bajamos la línea
            Console.WriteLine();
        }

        //Adiciona un nuevo elemento
        public void Adicionar(int oDato)
        {
            //Trabajo al inicio
            trabajo = ancla;

            //Recorremos hasta encontrar el final
            while(trabajo.Siguiente != null)
            {
                //Avanzamos trabajo
                trabajo = trabajo.Siguiente;
            }

            //Creamos el nuevo nodo
            CNodo temp = new CNodo();

            //Insertamos el dato
            temp.Dato = oDato;

            //Finalizamos correctamente
            temp.Siguiente = null;

            //Ligamos el último nodo encontrado con el recién creado
            trabajo.Siguiente = temp;
        }
    }
}
