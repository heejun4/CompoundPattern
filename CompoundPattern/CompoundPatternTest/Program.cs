using CompoundPatternTest;
using CompoundPatternTest.Duck;
using CompoundPatternTest.Goose;
using CompoundPatternTest.Interface;

public class Client
{
    public static void Main(string[] args)
    {
        List<IQuackable> Ducks = new List<IQuackable>();

        // 1. 어댑터 패턴
        // 기존 코드를 수정하지 않고 호환되지 않은 두 개의 요소를 함께 사용할수 있게 함.
        // 수정이 불가능한 외부 라이브러리 같은 경우 감싸서 수정할수 있게 (예 구스가 외부라이브러리일 경우)

        //Ducks.Add(new MallardDuck());
        //Ducks.Add(new RubberDuck());
        //Ducks.Add(new RedHeadDuck());

        //Goose goose = new Goose();
        //Ducks.Add(new GooseAdapter(goose));

        //foreach (var duck in Ducks)
        //{
        //    duck.Quack();
        //}



        // 2. 데코레이터 패턴

        // 클래스의 구조를 변경하지 않고 기능 추가/확장 가능.
        // Duck 클래스를 변경하지 않고 Quack Count를 계산함.
        /*
        Ducks.Add(new DuckDecorator(new MallardDuck()));
        Ducks.Add(new DuckDecorator(new RubberDuck()));
        Ducks.Add(new DuckDecorator(new RedHeadDuck()));

        Goose goose = new Goose();
        Ducks.Add(new DuckDecorator(new GooseAdapter(goose)));
        foreach (var duck in Ducks)
        {
            duck.Quack();
        }
        Console.WriteLine("Quack Count : " + DuckDecorator.NumberOfQuacks);
        */

        // 3. Factory Pattern
        // 매번 데코레이터로 생성해야되니... 팩토리로 감싸서 한방에 만들수 있게
        // 클라이언트 코드와 객체 생성 코드를 분리시키는 것, 즉 오브젝트 생성 방법은 알필요 없고 그냥 요청만 하면 됨.
        // 오브젝트 생성이 복잡하거나, 다른 기능들을 추가하고 싶을때 사용.
        /*
        var duckFactory = new DuckFactory();
        Ducks.Add(duckFactory.CreateMallardDuck());
        Ducks.Add(duckFactory.CreateRedHeadDuck());
        Ducks.Add(duckFactory.CreateRubberDuck());
        Ducks.Add(duckFactory.CreateGooseToDuck());

        foreach (var duck in Ducks)
        {
            duck.Quack();
        }
        Console.WriteLine("Quack Count : " + DuckDecorator.NumberOfQuacks);
        */

        // 4. Composit Pattern
        // 단일 객체와 복합 객체를 동일한 방법으로 다룰 수 있음. 
        // 트리 구조로 구성할 수 있음
        /*
        var duckFactory = new DuckFactory();
        var duckGroup = new DuckComposite();
        duckGroup.AddQuack(duckFactory.CreateMallardDuck());
        duckGroup.AddQuack(duckFactory.CreateRedHeadDuck());
        duckGroup.AddQuack(duckFactory.CreateRubberDuck());

        duckGroup.Quack();
        Console.WriteLine("Quack Count : " + DuckDecorator.NumberOfQuacks);

        var gooseGroup = new DuckComposite();
        gooseGroup.AddQuack(duckFactory.CreateGooseToDuck());
        gooseGroup.AddQuack(duckFactory.CreateGooseToDuck());
        gooseGroup.AddQuack(duckFactory.CreateGooseToDuck());

        gooseGroup.Quack();
        Console.WriteLine("Quack Count : " + DuckDecorator.NumberOfQuacks);
        

        duckGroup.AddQuack(gooseGroup);
        duckGroup.Quack();
        Console.WriteLine("Quack Count : " + DuckDecorator.NumberOfQuacks);
        */


    }
}