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


            //문자열 연결 연산자
            // concat concatenate operator
            // concatenation operator

            //시험 문제 나왔을 때 맞출수 있어야 함. 다음 중 성격이 다른 것은?
            Console.WriteLine("ABC" + "EFC"); //덧셈 연산자 아니고 문자열 연산자
            Console.WriteLine('A' + 'E');
            Console.WriteLine("ABC" + 'E');

            Console.WriteLine("ABC"[2]);
            //Console.WriteLine("ABC"[3]); 에러

            //bool
            bool isPlay = true;
            bool isDeath = false;

            //comparison operator
            Console.WriteLine(52 == 163);
            Console.WriteLine(52 != 163);
            Console.WriteLine(52 > 163);
            Console.WriteLine(52 > 163);
            Console.WriteLine(52 >= 163);
            Console.WriteLine(52 < 163);
            Console.WriteLine(52 >= 163);

            //Logic operator
            Console.WriteLine(!(true));
            Console.WriteLine(true || false);
            Console.WriteLine(true && false);

            // 단항연산자 - unary operator
            Console.WriteLine(!(true));
            int i = 0;
            i++;

            // 이항연산자 - binary operator
            i = 1 + 2;

            // 삼항연산자 - ternary operator
            int j;
            j = (i > 3) ? 0 : 1;

            //Console.WriteLine(3 < i < 8);
            Console.WriteLine(3 < i && i < 8);
            Console.WriteLine(3 > i || i > 8);
            Console.WriteLine(i < 3 || 8 < i);


        }
    }
}
