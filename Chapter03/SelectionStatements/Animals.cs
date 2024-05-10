using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectionStatements
{
    public class Animal
    {
        public string? Name;
        public DateTime Born;
        
        public byte Legs;
        
    }

    class Cat :Animal
    {
        public bool IsDomestic;
    }

    class Spider : Animal
    {
        public bool IsPoisonous;
    }
}