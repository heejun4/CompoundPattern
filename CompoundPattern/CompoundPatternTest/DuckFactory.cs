using CompoundPatternTest.Duck;
using CompoundPatternTest.Goose;
using CompoundPatternTest.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatternTest
{
    //public abstract class AbstractDuckFactory
    //{
    //    public abstract Interface.IQuackable CreateMallardDuck();
    //    public abstract Interface.IQuackable CreateRedHeadDuck();
    //    public abstract Interface.IQuackable CreateRubberDuck();

    //}
    public abstract class AbstractDuckFactory
    {
        public abstract Interface.IQuackable CreateRedHeadDuck();
        public abstract Interface.IQuackable CreateMallardDuck();
        public abstract Interface.IQuackable CreateRubberDuck();
        public abstract Interface.IQuackable CreateGooseToDuck();
    }

    public class DuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallardDuck()
        {
            return new DuckDecorator(new MallardDuck());
        }

        public override IQuackable CreateRedHeadDuck()
        {
            return new DuckDecorator(new RedHeadDuck());
        }

        public override IQuackable CreateRubberDuck()
        {
            return new DuckDecorator(new RubberDuck());
        }
        public override IQuackable CreateGooseToDuck()
        {
            return new DuckDecorator(new GooseAdapter(new Goose.Goose()));
        }

        //public override IQuackable CreateMallardDuck()
        //{
        //    return new DuckDecorator(new MallardDuck());
        //}

        //public override IQuackable CreateRedHeadDuck()
        //{
        //    return new DuckDecorator(new RedHeadDuck());
        //}

        //public override IQuackable CreateRubberDuck()
        //{
        //    return new DuckDecorator(new RubberDuck());
        //}
    }



}
