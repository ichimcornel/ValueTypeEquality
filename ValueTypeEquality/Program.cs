using System;

namespace ValueTypeEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeItem @int = new TypeItem("int", ValueType.Int);
            TypeItem int2 = new TypeItem("int", ValueType.Int);
            TypeItem @bool = new TypeItem("bool", ValueType.Bool);

            Console.WriteLine($"int == int2 : {@int == int2}");
            Console.WriteLine($"bool == int2 : {@bool == int2}");
        }
    }
}
