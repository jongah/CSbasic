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

            
        }
    }
}
