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
        public string Playerjob { get; private set; }

        // 타자 효과 메서드 추가
        public void TypeWrite(string text, int delay = 40)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }

        public void Start()
        {
            TypeWrite("안녕하세요 여기는 테스트 공간입니다.");
            TypeWrite("당신의 이름은 무엇인가요?");
            Playername = Console.ReadLine();

            Console.Clear();

            while(true)
            {
                TypeWrite($"{Playername} 맞나요?\n");
                Console.WriteLine("[1. 네 맞습니다.]");
                Console.WriteLine("[2. 아니요, 다시 입력하겠습니다.]");
                string NameClear = Console.ReadLine();
                if (NameClear == "1")
                {
                    TypeWrite($"그렇군요 당신의 이름은 {Playername} 입니다.");
                    Thread.Sleep(500);
                    Console.Write("             ");
                    Console.Write("·  ");
                    Thread.Sleep(500);
                    Console.Write("·  ");
                    Thread.Sleep(500);
                    Console.Write("·  ");
                    Thread.Sleep(500);
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
            while (true)
            {
                TypeWrite("당신의 직업은 무엇인가요?\n");
                Console.WriteLine("[1. 전사]");
                Console.WriteLine("[2. 마법사]");
                Console.WriteLine("[3. 도적]");


                Playerjob = Console.ReadLine();
                switch (Playerjob)
                {
                    case "1":
                        TypeWrite("당신은 전사입니다. 강력한 힘을 가지고 있습니다.");
                        Playerjob = "전사"; // 직업을 전사로 설정
                        break;
                    case "2":
                        TypeWrite("당신은 마법사입니다. 마법을 사용할 수 있습니다.");
                        Playerjob = "마법사"; // 직업을 마법사로 설정
                        break;
                    case "3":
                        TypeWrite("당신은 도적입니다. 빠르고 민첩합니다.");
                        Playerjob = "도적"; // 직업을 도적으로 설정
                        break;
                    default:
                        TypeWrite("잘못된 입력입니다. 다시 선택해주세요.");
                        continue; // 잘못된 입력인 경우 다시 선택을 받도록 루프를 계속 진행
                }
                Thread.Sleep(500);
                Console.Write("             ");
                Console.Write("·  ");
                Thread.Sleep(500);
                Console.Write("·  ");
                Thread.Sleep(500);
                Console.Write("·  ");
                Thread.Sleep(500);
                Console.Clear();
                break;
            }

        }
    }
}
