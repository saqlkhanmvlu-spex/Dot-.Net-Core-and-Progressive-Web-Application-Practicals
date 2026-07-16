- SINGLE INHERITANCE CODE :- 
using System;
public class A
{
    public void Fun1()
    {
        Console.WriteLine("Method of Class A");
    }
}
public class B : A
{
    public void Fun2()
    {
        Console.WriteLine("Method of Class B");
    }
}
class SingleInheritance
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Single Inheritance");

        B obj = new B();
        obj.Fun1();
        obj.Fun2();
    }
}
OUTPUT :- 

MULTILEVEL INHERITANCE CODE :- 
using System;
public class A
{
    public void Fun1()
    {
        Console.WriteLine("Method of Class A");
    }
}
public class B : A
{
    public void Fun2()
    {
        Console.WriteLine("Method of Class B");
    }
}
public class C : B
{
    public void Fun3()
    {
        Console.WriteLine("Method of Class C");
    }

class MultilevelInheritance
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Multilevel Inheritance");
        C obj = new C();
        obj.Fun1();
        obj.Fun2();
        obj.Fun3();
    }
}
OUTPUT :- 

HIERARICHAL INHERITANCE CODE :- 
using System;
public class A
{
    public void Fun1()
    {
        Console.WriteLine("Method of Class A");
    }
}
public class B : A
{
    public void Fun2()
    {
        Console.WriteLine("Method of Class B");
    }
}
public class C : A
{
    public void Fun3()
    {
        Console.WriteLine("Method of Class C");
    }
}
class HierarchicalInheritance
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hierarchical Inheritance");
        B obj1 = new B();
        obj1.Fun1();
        obj1.Fun2();

        C obj2 = new C();
        obj2.Fun1();
        obj2.Fun3();
    }
}
