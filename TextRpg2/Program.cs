namespace TextRpg2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Startstory startStory = new Startstory(); // Startstory 클래스의 인스턴스를 생성
            Player player = new Player(); // Player 클래스의 인스턴스를 생성


            startStory.Start(); // Startstory 클래스의 Start 메서드를 호출
                                // 1. 시작텍스트 출력
            
            string name = startStory.Playername; // Startstory 클래스에서 플레이어 이름을 가져옴
            player.name = name; // Player 클래스의 name 속성에 플레이어 이름을 설정


            while (true)
            {
                Console.Clear(); // 콘솔 화면을 지움
                Console.WriteLine($"{name} 테스트 공간에서 무엇을 하고 싶으신가요?\n");
                Console.WriteLine("[1. 상태 보기]");
                Console.WriteLine("[2. 상점]");
                Console.WriteLine("[3. 인벤토리]");

                switch (Console.ReadLine())
                {
                    case "1": // 상태 보기
                        Console.WriteLine($"{name}의 상태를 보여줍니다.");
                        player.DisplayStatus(); // Player 클래스의 DisplayStatus 메서드를 호출하여 상태를 보여줌
                        break;
                    case "2":
                        Console.WriteLine("상점에 입장합니다.");
                        // 상점 로직 추가
                        break;
                    case "3":
                        Console.WriteLine("인벤토리를 확인합니다.");
                        // 인벤토리 로직 추가
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다. 다시 시도해주세요.");
                        continue; // 잘못된 입력인 경우 다시 입력을 받도록 루프를 계속 진행
                }
            }
            


        }
    }
}
