using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Memento
{
    class Originator
    {
        public string article { get; protected set;  }
        public void Set(string article)
        {
            this.article = article;
        }
        public Memento StoreInMemento()
        {
            return new Memento(this.article);
        }
        public string RestoreFromMemento(Memento memento)
        {
            article = memento.article;
            return article;
        }
    }
}
