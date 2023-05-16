using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CompoundPatternTest.Duck
{
    public class MallardDuck : Interface.IQuackable
    {
        public MallardDuck() { }

        public void Quack()
        {
            Console.WriteLine("청둥오리 : 꿱꿱");
        }
    }

    public class RedHeadDuck : Interface.IQuackable
    {
        public RedHeadDuck() { }

        public void Quack()
        {
            Console.WriteLine("야생오리 : 꿱꿱");
        }
    }
    public class RubberDuck : Interface.IQuackable
    {
        public RubberDuck() { }

        public void Quack()
        {
            Console.WriteLine("고무오리 : 삑");
        }
    }
}
