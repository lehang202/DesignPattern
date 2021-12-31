using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
    class Bracket
    {
        private IStrategy strategy;
        public Bracket()
        {
            this.strategy = new Quotes();
        }

        public void setStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }
        public string doubleBracket(string textselection)
        {
            return strategy.printBracket(textselection);
        }
    }

    interface IStrategy
    {
        string printBracket(string textselection);
    }

    class Quotes : IStrategy
    {
        public string printBracket(string textselection)
        {
            return "\"" + textselection + "\"";
        }
    }

    class Parentheses : IStrategy
    {
        public string printBracket(string textselection)
        {
            return "\'" + textselection + "\'";
        }
    }

    class SquareBrackets : IStrategy
    {
        public string printBracket(string textselection)
        {
            return "[" + textselection + "]";
        }
    }

    class CurlyBrackets : IStrategy
    {
        public string printBracket(string textselection)
        {
            return "{" + textselection + "}";
        }
    }

    class RoundBrackets : IStrategy
    {
        public string printBracket(string textselection)
        {
            return "(" + textselection + ")";
        }
    }

    class AngleBrackets : IStrategy
    {
        public string printBracket(string textselection)
        {
            return "<" + textselection + ">";
        }
    }
}
