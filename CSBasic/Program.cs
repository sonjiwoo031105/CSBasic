using System;

namespace CSBasic
{
    class Program
    {
        static void Main(string[] args)
        {

            //keyword
            //int as;

            //context keyword
            //var var = "손지우";
            //식별자 Identifier
            int alpha;
            int Alpha;
            //int break;
            //int 263;
            //int has space;
            // int 😂❤😒;
            int 한글숫자;


            // inline comment
            /*
             * comment
             */

            //출력
            Console.Write("개행");
            Console.Write("입니당\n");
            Console.WriteLine("");
            Console.WriteLine("Hello");

            //자료형(Data Type)
            Console.WriteLine(53 + 272);
            Console.WriteLine(53 * 3 - 3);
            Console.WriteLine(14 / 2); //7
            Console.WriteLine(14 / 3); //4
            Console.WriteLine(14 % 3); //2

            //Real Number
            Console.WriteLine(13.123);
            Console.WriteLine(0.0);
            Console.WriteLine(0);
            Console.WriteLine(14.0 / 2.0); //7.0
            Console.WriteLine(14.0 / 3.0); //4.666667
            Console.WriteLine(14 / 3); //4
            Console.WriteLine(14.0 / 3); //4.666667
            Console.WriteLine(14 / 3.0);  //4.666667
            Console.WriteLine(14.0 / 3.0); //4.666667

            //Character
            Console.WriteLine('A'); //문자
            
            //String
            Console.WriteLine("A"); //문자열

            //Escape Character
            Console.WriteLine("\t 탭 \\  역슬래시 \n 개행 \" ");
            Console.WriteLine("미\t림여자정보과학고");
            Console.WriteLine("미림\t여자정보과학고");
            Console.WriteLine("미림여\t자정보과학고");
            Console.WriteLine("미림여자\t정보과학고");
            Console.WriteLine("미림여자정\t보과학고");
            Console.WriteLine("미림여자정보\t과학고");
            Console.WriteLine("미림여자정보과\t학고");
            Console.WriteLine("미림여자정보과학\t고");
            Console.WriteLine("미림여자정보과학고\t");


        }
    }
}
