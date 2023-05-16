using CompoundPatternTest.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatternTest.Goose
{
    public class GooseAdapter : IQuackable
    {
        private Goose goose;
        public GooseAdapter(Goose _goose) 
        {
            this.goose = _goose;
        }
        public void Quack()
        {
            this.goose.Honk();
        }
    }
}
