using System;

namespace CSBasic3202
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침먹을 시간입니다.");
            }else if(DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심먹을 시간입니다.");
            }
            else
            {
                Console.WriteLine("저녁 먹을 시간입니다.");
            }

            double score = 4.5;
            if(score == 4.5)
            {
                Console.WriteLine("신");
            }
            else if(score <= 4.0)
            {
                Console.WriteLine("교수님의 사랑");
            }
            else if (score <= 3.5)
            {
                Console.WriteLine("천재");
            }
            else if (score <= 3.0)
            {
                Console.WriteLine("동기의 선망의 눈빗");
            }
            else if (score <= 2.5)
            {
                Console.WriteLine("분발하세요");
            }
            else if (score <= 2.0)
            {
                Console.WriteLine("더 분발하세요");
            }
            else if (score <= 1.5)
            {
                Console.WriteLine("자벌래");
            }
            else if (score <= 1.0)
            {
                Console.WriteLine("...");
            }


            Console.WriteLine("몇월 인가요 : ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 12: case 1: case 2:
                    Console.WriteLine("겨울");
                    break;
                case 3: case 4: case 5:
                    Console.WriteLine("봄");
                    break;
                case 6: case 7: case 8:
                    Console.WriteLine("여름");
                    break;
                case 9: case 10: case 11:
                    Console.WriteLine("가을");
                    break;
                default:
                    Console.WriteLine("똑바로 입력해 주세요.");
                    break;
            }

            string input2 = Console.ReadLine();
            int number = int.Parse(input2);
            Console.WriteLine((number > 0) ? "자연수" : "자연수 아님");

        }
    }
}
