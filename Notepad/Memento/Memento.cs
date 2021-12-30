using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Memento
{
    class Memento
    {
        public string article {  get; protected set; }
        public Memento(string article)
        {
            this.article = article;
        }
    }
}
