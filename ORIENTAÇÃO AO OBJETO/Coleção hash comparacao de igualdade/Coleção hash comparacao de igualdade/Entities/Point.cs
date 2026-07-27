using System;
using System.Collections.Generic;
using System.Text;

namespace Coleção_hash_comparacao_de_igualdade.Entities
{
    internal struct Point
    {
        public int X { get; set;  }
        public int Y { get; set; }

        public Point (int x, int y) : this ()
        {
            X = x;
            Y = y;
        }
    }
}
