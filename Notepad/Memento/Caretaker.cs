using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Memento
{
    class Caretaker
    {
        List<Memento> savedArticle = new List<Memento>();
        public void AddMemento(Memento m)
        {
            savedArticle.Add(m);
        }
        public Memento GetMemento(int i)
        {
            return savedArticle[i];
        }
        public int GetCountOfSavedArticles()
        {
            return savedArticle.Count;
        }
    }
}
