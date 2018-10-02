using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Card
    {
        private string _colour;
        private int _value;

        public Card(string colour, int value)
        {
            _colour = colour;
            _value = value;
        }
        public override string ToString()
        {
            return $"{_value}, {_colour}";
        }

        public string Colour
        {
            get { return _colour; }
        }

        public int Value
        {
            get { return _value; }
        }
    }
}
