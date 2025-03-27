using System;

namespace UnderstandingTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type\t\tSize (bytes)\tMin Value\t\tMax Value");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine($"sbyte\t\t{sizeof(sbyte)}\t\t{sbyte.MinValue}\t\t\t{sbyte.MaxValue}");
            Console.WriteLine($"byte\t\t{sizeof(byte)}\t\t{byte.MinValue}\t\t\t{byte.MaxValue}");
            Console.WriteLine($"short\t\t{sizeof(short)}\t\t{short.MinValue}\t\t\t{short.MaxValue}");
            Console.WriteLine($"ushort\t\t{sizeof(ushort)}\t\t{ushort.MinValue}\t\t\t{ushort.MaxValue}");
            Console.WriteLine($"int\t\t{sizeof(int)}\t\t{int.MinValue}\t\t\t{int.MaxValue}");
            Console.WriteLine($"uint\t\t{sizeof(uint)}\t\t{uint.MinValue}\t\t\t{uint.MaxValue}");
            Console.WriteLine($"long\t\t{sizeof(long)}\t\t{long.MinValue}\t\t\t{long.MaxValue}");
            Console.WriteLine($"ulong\t\t{sizeof(ulong)}\t\t{ulong.MinValue}\t\t\t{ulong.MaxValue}");
            Console.WriteLine($"float\t\t{sizeof(float)}\t\t{float.MinValue:E}\t\t\t{float.MaxValue:E}");
            Console.WriteLine($"double\t\t{sizeof(double)}\t\t{double.MinValue:E}\t\t\t{double.MaxValue:E}");
            Console.WriteLine($"decimal\t\t{sizeof(decimal)}\t\t{decimal.MinValue}\t\t\t{decimal.MaxValue}");
        }
    }
}