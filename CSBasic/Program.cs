﻿using System;

namespace CSBasic
{
    class Program
    {
        // var 키워드는 지역변수로만 사용 가능.
        //var var = "손지우";
        //var something = "blahblah";
        static void Main(string[] args)
        {

            //keyword
            //int as;

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

            int a = 2147483640;
            int b = 1000000000;
            Console.WriteLine((long)a + b);

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine(-int.MaxValue);
            //Console.WriteLine(-int.MinValue);

            Console.WriteLine(3L);

            Console.WriteLine(3);
            Console.WriteLine(3.0);
            char c = 'a';
            Console.WriteLine(c);

            //sizeof(자료형)
            Console.WriteLine("int:" + sizeof(int));
            Console.WriteLine("long:" + sizeof(long));
            Console.WriteLine("float:" + sizeof(float));
            Console.WriteLine("double:" + sizeof(double));
            Console.WriteLine("char:" + sizeof(char));

            bool IsLive = true;

            //증감연산자 - 섞어서 쓸 경우
            // 전위, 후위에 따라서 출력 값이 변할 수 있으니 주의
            int num = 10;
            Console.WriteLine(num++);
            Console.WriteLine(++num);
            Console.WriteLine(num--);
            Console.WriteLine(--num);

           // 복합대입연산자
            int output = 0;
            output += 52;
            output = output + 52;
            output *= 10;
            output = output * 10;
            Console.WriteLine(output);

            // 문자열 연결 연산자를 사용한 복합 연산자
            string output3 = "Hello";
            output3 += " World";
            output3 = output3 + "?!";
            Console.WriteLine(output3);

            int _int = 273; long _long = 522731033265;
            float _float = 52.273F;  double _double = 52.273;
            char _char = '귤'; string _string = "문자열";
            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());

            var somea = "마음에 드는 문자열";
            var someb = 42;
            var somec = 3.1415962;
            Console.WriteLine(somea.GetType());
            Console.WriteLine(someb.GetType());
            Console.WriteLine(somec.GetType());

            string input;
            while (true)
            {
                Console.Write("입력>");
                input = Console.ReadLine();
                if (input.Equals("q"))
                    break;
                else
                    Console.WriteLine(input);
            }


        }
    }
}
