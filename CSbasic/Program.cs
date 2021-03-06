using System;

namespace CSbasic
{
    class Program
    {
        //var 키워드는 지역변수만 가능
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //#1
            //keyworld
            //int as;
            //context keyword
            //var name = "jongah";
            //var var = "jongah";

            //식별자  identifier
            int alpha;
            int Alpha;
            //int break;
            //int 263alpha;
            //int has space;
            //int 🚧🧊🍰🥨🍇📎🙄👀🌿;
            //int 한글;

            ///xml 주석
            //inline comment
            /*
             * comment
             */
            
            //#2
            Console.Write("이건 안개행");
            Console.WriteLine("");
            Console.WriteLine("와");

            //#3 자료형(Datatype)
            Console.WriteLine(54 + 32 - 145);
            Console.WriteLine(43 * 33 - 4);
            Console.WriteLine(14 / 2); //7
            Console.WriteLine(14 / 3); //4
            Console.WriteLine(14 % 3); //2

            //Reallnumber
            Console.WriteLine(13.123);
            Console.WriteLine(0);
            Console.WriteLine(0.0);
            Console.WriteLine(14 / 2.0);
            Console.WriteLine(14.0 / 3.0);
            //14.0 % 12.0
            Console.WriteLine(14 / 3);      //4
            Console.WriteLine(14.0 / 3);    //4.6666
            Console.WriteLine(14 / 3.0);    //4.6666    
            Console.WriteLine(14.0 / 3.0);  //4.6666

            //character
            Console.WriteLine('A');     //문자
            Console.WriteLine("A");     //문자열
            //Escape Character
            Console.WriteLine("\t \\ \n \"");
            Console.WriteLine("미\t림여자정보과학고");
            Console.WriteLine("미림\t여자정보과학고");
            Console.WriteLine("미림여\t자정보과학고");
            Console.WriteLine("미림여자\t정보과학고");
            Console.WriteLine("미림여자정\t보과학고");
            Console.WriteLine("미림여자정보\t과학고");
            //문자열 연결 연산자
            //contenation operator
            Console.WriteLine("hello" + "world");
            Console.WriteLine('A' + 'a');
            //bpp;
            //true//false

            //자료형
            int a = 2147483640;
            int b = 100000000;
            Console.WriteLine((long)a + b);
            Console.WriteLine(int.MinValue + " " +  int.MaxValue);
            //Console.WriteLine(-int.MinValue + " " + -int.MaxValue);
            Console.WriteLine(3L);

            Console.WriteLine(3);
            Console.WriteLine(3.0);
            Console.WriteLine('a');
            Console.WriteLine("a");

            //sizeof(자료형)
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(char));
            Console.WriteLine(sizeof(long));
            Console.WriteLine(sizeof(double));

            //증감연산자
            int num = 10;
            Console.WriteLine(num++);
            Console.WriteLine(num--);
            Console.WriteLine(--num);
            Console.WriteLine(++num);

            //복합대입연산자
            int output = 0;
            output += 52;
            output = output + 52;
            output *= 30;
            output = output * 30;
            Console.WriteLine(output);

            //문자열 연결 연산자를 사용한 복합 연산자
            string output1 = "hello";
            output1 += "world";
            output1 = output1 + "!!";
            Console.WriteLine(output1);

            //자료형 검사
            int _int = 345;
            long _long = 324342550099;
            double _double = 0.2334;
            float _float = 3.434214f;
            char _char = 'w';
            string _string = "helloworld";

            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());

            //var키워드 * 반드시 초기화를 시켜줘야한다. ( 초기화 하는 값을 보고 추측하여 할당한다. )
            //메서드 안에서만 선언할 수 있다. -> 지역변수만 사용가능
            //멤버변수는 동적으로 불러온다.
            var number = 100;
            var somea = "인간";
            var someb = 3.4234242;

            //입력
            string input;
            while (true)
            {
                Console.Write("입력 : ");
                input = Console.ReadLine();
                if (input.Equals("q"))
                    break;
                else
                    Console.WriteLine(input);
            }

            //자료형 변환
            var a1 = (int)10.3;
            var b1 = (float)10;
            var c1 = (double)10;

            long longNumber = 2147483637L + 2147483637L;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber); //-22 값 손실이 발생한다.

            long longNumber2 = 52773;
            int intNumber2 = (int)longNumber2;
            Console.WriteLine(intNumber2);

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine(int.Parse("43"));
            Console.WriteLine(long.Parse("435"));
            Console.WriteLine(float.Parse("43.15"));
            Console.WriteLine(double.Parse("43.22"));
            Console.WriteLine(int.Parse("43").GetType());
            Console.WriteLine(long.Parse("435").GetType());
            Console.WriteLine(float.Parse("43.15").GetType());
            Console.WriteLine(double.Parse("43.22").GetType());
            try
            {
                Console.WriteLine(int.Parse("43.654"));
                Console.WriteLine(int.Parse("abd"));
                Console.WriteLine(int.Parse("육십삼"));
                Console.WriteLine(int.Parse("seven"));
            }catch(FormatException e)
            {
                Console.WriteLine("포맷이 맞지 않습니다 : " + e.Message);
            }

            //ToString()
            (10).ToString();
            (53.234).ToString();

            double numberToString = 52.435;
            Console.WriteLine(numberToString.ToString("0.0"));
            Console.WriteLine(numberToString.ToString("0.00"));
            Console.WriteLine(numberToString.ToString("0.000"));
            Console.WriteLine(numberToString.ToString("0.0000"));
            Console.WriteLine(numberToString.ToString("0.00000"));

            //숫자와 문자열 덧셈
            Console.WriteLine(54 + 344);
            Console.WriteLine("43" + 356);
            Console.WriteLine(232 + "43" + 356);
            Console.WriteLine("43" + 356 + "34");

            char character = 'a';
            string outputB = character + "";
            Console.WriteLine(outputB);

            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("TruE"));
            Console.WriteLine(bool.Parse("trUe"));
            Console.WriteLine(bool.Parse("TRUE"));

            int outputInt = int.MinValue;
            Console.WriteLine(-(long)outputInt);
            Console.WriteLine(-(-561656565));
        }
    }
}
