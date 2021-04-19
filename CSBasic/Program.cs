using System;

namespace CSBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(52);
            //325를 출력합니다.
            Console.WriteLine(52 + 273);
            Console.WriteLine(5 + 3 * 2);
            Console.WriteLine(10 % 5);
            Console.WriteLine(7 % 3);

            Console.WriteLine(52.273);
            Console.WriteLine(1.0+2.0);

            Console.WriteLine('A');
            Console.WriteLine('가');

            Console.WriteLine("안녕하세요");
            Console.WriteLine("한빛\t아카데미");
            Console.WriteLine("한빛\n아카데미");
            Console.WriteLine("\"\"\"");

            Console.WriteLine("가나다"+"라마");

            Console.WriteLine("안녕하세요"[0]);
            Console.WriteLine("안녕하세요"[1]);
            Console.WriteLine("안녕하세요"[3]);

            Console.WriteLine(true);
            Console.WriteLine(false);
            Console.WriteLine(!(52 < 273));

        }
    }
}
