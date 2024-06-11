using System;
using System.Collections.Generic;

namespace MyApp
{
    internal class Element
    {
        private int id { get; set; }
        private List<Element> connectionsList { get; set; }

        public Element(int id) 
        {
            this.id = id;
            connectionsList = [];
        }

        public int GetId() { return id; }

        public void AddConnection(Element e)
        {
            if (e == null) throw new ArgumentException("Elemento nulo não pode ser inserido");
            connectionsList.Add(e);
        }

        public bool IsConnected(Element e)
        {
            if (e == null) return false;
            foreach (Element innerElement in connectionsList)
            {
                if (innerElement.GetId() == e.GetId()) return true;
                if (innerElement.IsConnected(e)) return true;
            }
            return e.IsConnected(this);
        }
    }
}