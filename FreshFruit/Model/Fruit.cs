using System;
using System.Collections.Generic;
using System.Text;

namespace FreshFruit.Model
{
    class Fruit
    {
        private string name;

        public Fruit(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }

        internal object getname()
        {
            throw new NotImplementedException();
        }
    }
}
