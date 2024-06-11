using System;
using System.Collections.Generic;

namespace MyApp
{
    internal class Network
    {
        public Dictionary<int, Element> elements = new Dictionary<int, Element>();

        public Network(int elementsCount) 
        {
            if (elementsCount <= 0) throw new ArgumentException("Quantidade de elementos não pode ser menor que 0");

            for (int i = 1; i <= elementsCount; i++)
            {
                elements.Add(i,new Element(i));
            }
        }

        public void Connect(int a, int b)
        {
            if (!elements.ContainsKey(a)) throw new ArgumentException("Elemento " + a + " não existe na network");
            if (!elements.ContainsKey(b)) throw new ArgumentException("Elemento " + b + " não existe na network");

            elements[a].AddConnection(elements[b]);
        }

        public bool Query(int a, int b)
        {
            if (!elements.ContainsKey(a) || !elements.ContainsKey(b)) return false;
            return elements[a].IsConnected(elements[b]);
        }
    }
}