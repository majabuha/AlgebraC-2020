using System;

namespace _08_03_over_hide
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass isReallyBase = new BaseClass();
<<<<<<< HEAD
            BaseClass isReallyDerived = new DerivedClass();
=======
            BaseClass isReallyDerived = new DerivedClass();  // POSEBAN SLUCAJ
>>>>>>> c636db93544f07e247aecbf038b0028e6c082f55
            DerivedClass isClearlyDerived = new DerivedClass();

            isReallyBase.WriteNum(); // writes 12
            isReallyBase.WriteStr(); // writes abc

            isReallyDerived.WriteNum(); // writes 12
            isReallyDerived.WriteStr(); // writes xyz

            isClearlyDerived.WriteNum(); // writes 42
            isClearlyDerived.WriteStr(); // writes xyz
        }
    }
}


public class BaseClass
{
    public void WriteNum()
    {
        Console.WriteLine(12);
    }
    public virtual void WriteStr()
    {
        Console.WriteLine("abc");
    }
}

public class DerivedClass : BaseClass
{
    public new void WriteNum()  // HIDE, ovo vrijedi samo za nasljedjeni objekt
    {
        Console.WriteLine(42);
    }
    
    public override void WriteStr()  //OVER
    {
        Console.WriteLine("xyz");
    }
    
}

