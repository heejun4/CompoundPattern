using CompoundPatternTest.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatternTest
{
    public class DuckDecorator : IQuackable
    {
        public static int NumberOfQuacks = 0;
        private IQuackable duck;
        public DuckDecorator(IQuackable _duck) 
        {
            this.duck = _duck;
        }

        public void Quack()
        {
            this.duck.Quack();
            NumberOfQuacks++;
        }
    }
}
