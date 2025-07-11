using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; // Thread.Sleep(1000) 사용을 위한 네임스페이스 추가 1000당 1초 지연 

namespace TextRpg2
{
    public class Startstory
    {
        public string Playername { get; private set; }

        public void Start()
        {
            Console.WriteLine("안녕하세요 여기는 테스트 공간입니다.");
            Console.WriteLine("당신의 이름은 무엇인가요?");
            Playername = Console.ReadLine();

            Console.Clear();

            while(true)
            {
                Console.WriteLine($"{Playername} 맞나요?\n");
                Console.WriteLine("[1. 네 맞습니다.]");
                Console.WriteLine("[2. 아니요, 다시 입력하겠습니다.]");
                string NameClear = Console.ReadLine();
                if (NameClear == "1")
                {
                    Console.WriteLine($"그렇군요 당신의 이름은 {Playername} 입니다.");
                    Thread.Sleep(1000); // 1초 지연
                    Console.Write("             ");
                    Console.Write("·  ");
                    Thread.Sleep(1000); // 1초 지연
                    Console.Write("·  ");
                    Thread.Sleep(1000); // 1초 지연
                    Console.Write("·  ");
                    Thread.Sleep(1000); // 1초 지연
                    Console.Clear();
                    break;
                    
                }
                else if (NameClear == "2")
                {
                    Console.WriteLine("\n이름을 다시 입력해주세요.");
                    Playername = Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 1 또는 2를 입력해주세요.");
                    continue; // 잘못된 입력인 경우 다시 입력을 받도록 루프를 계속 진행
                }
            }

        }
    }
}
