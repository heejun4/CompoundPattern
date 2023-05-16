using CompoundPatternTest.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatternTest
{
    public class DuckComposite : IQuackable
    {
        private List<IQuackable> quackables = new List<IQuackable>();

        public DuckComposite() { }

        public void AddQuack(IQuackable quackable)
        {
            this.quackables.Add(quackable);
        }
        public void Quack()
        {
            foreach (var duck in this.quackables)
            {
                duck.Quack();
            }
        }




    }
}
