using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSBasic3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[100];
            Console.WriteLine(intArray.Length);
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[99]);
            //Console.WriteLine(intArray[100]); //범위 초과
            //Console.WriteLine(intArray[-1]); // 음수 사용 불가

            int i = 0;
            int[] intArray2 = { 52, 273, 32, 65, 103 };
            while(i < intArray2.Length)
            {
                Console.WriteLine(i + "번째 출력:" + intArray2[i]);
                i++;
            }

            string input;
            do
            {
                Console.Write("입력(종료:exit):");
                input = Console.ReadLine();
            } while (input != "exit");

            for(int j = '가'; j <= '힣'; j++)
            {
                Console.Write((char)j);
            }

            int[] intArray3 = { 1, 2, 3, 4, 5, 6 };
            for(int k = intArray3.Length - 1; k>=0; k--)
            {
                Console.WriteLine(intArray3[k]);
            }
            for(int k = intArray3.Length; k > 0; k--)
            {
                Console.WriteLine(intArray3[k - 1]);
            }

            string[] fruits = { "사과", "배", "포도", "딸기", "바나나", "오렌지" };
            foreach(var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            for(i = 0; i < 10; i++)
            {
                for(int j = 0; j < i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            for(i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10 - i - 1; j++)
                {
                    Console.Write(' ');
                }
                for(int j = 0; j < i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            //대소문자 변환
            string input3 = "Potato Tomato";
            Console.WriteLine(input.ToUpper());
            Console.WriteLine(input.ToLower());
            input.ToLower(); // 헛고생
            Console.WriteLine(input); //기존 그대로 출력됨

            string foods = "감자 고구마 토마토";
            string[] foodsArray = foods.Split(new char[] { ' ' });
            foreach(var item in foodsArray)
            {
                Console.WriteLine(item);
            }

            //환경변수의 path 텍스트 값을 가져와서 \를 \\로 치환해서 넣어준다.
            string path = "C:\\Program Files (x86)\\Common Files\\Oracle\\Java\\javapath;C:\\oraclexe\\app\\oracle\\product\\11.2.0\\server\\bin;%SystemRoot%\\system32;%SystemRoot%;%SystemRoot%\\System32\\Wbem;%SYSTEMROOT%\\System32\\WindowsPowerShell\\v1.0\\;%SYSTEMROOT%\\System32\\OpenSSH\\;C:\\ProgramData\\Naraesoft\\Magic Recovery\\;C:\\Program Files\\nodejs\\;C:\\Program Files\\Java\\jdk1.8.0_281;C:\\Program Files\\Git\\cmd;C:\\Program Files\\dotnet\\";
            string[] paths = path.Split(new char[] { ';' });
            foreach(var item in paths)
            {
                Console.WriteLine(item);
            }

            string dirtyInput = " text     um \n\t";
            Console.WriteLine("[" + dirtyInput + "]");
            Console.WriteLine("[" + dirtyInput.Trim() + "]");

            string[] foodArray2 = { "감자", "고구마", "토마토", "가지" };
            Console.WriteLine(string.Join(" ", foodsArray));
            Console.WriteLine(string.Join(",", foodsArray));
            Console.WriteLine(string.Join(";", foodsArray));
            Console.WriteLine(string.Join(" ", foodsArray)); // tab

            Console.SetCursorPosition(0, 1);
            Console.WriteLine("[      ]");
            Thread.Sleep(1000);
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("[#     ]");
            Thread.Sleep(1000);
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("[##    ]");
            Thread.Sleep(1000);
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("[###   ]");
            Thread.Sleep(1000);
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("[####  ]");
            Thread.Sleep(1000); Console.SetCursorPosition(0, 1);
            Console.WriteLine("[##### ]");
            Thread.Sleep(1000);
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("[######]");
            Thread.Sleep(1000);

            int x = 1;
            while(x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");

                Thread.Sleep(1000);
                x++;
            }
        }
    }
}
