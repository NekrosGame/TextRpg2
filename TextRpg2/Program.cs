using System.Numerics;

namespace TextRpg2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Startstory startStory = new Startstory(); // Startstory 클래스의 인스턴스를 생성
            startStory.Start(); // Startstory 클래스의 Start 메서드를 호출
                                // 시작텍스트 출력
            Player player = new Player(); // Player 클래스의 인스턴스를 생성
            string name = startStory.Playername; // Startstory 클래스에서 플레이어 이름을 가져옴
            player.name = name; // Player 클래스의 name 속성에 플레이어 이름을 설정
            string Playerjob = startStory.Playerjob; // Startstory 클래스에서 플레이어 직업을 가져옴
            player.PlayerJob = Playerjob; // Player 클래스의 PlayerJob 속성에 플레이어 직업을 설정

            Shop shop = new Shop(); // Shop 클래스의 인스턴스를 생성
            shop.player = player; // Shop 클래스에 Player 객체를 전달하여 상점과 플레이어를 연결
            Inventory inventory = new Inventory(); // Inventory 클래스의 인스턴스를 생성
            inventory.SetPlayer(player); // 반드시 Player를 연결
            shop.inventory = inventory; // Shop 클래스에 Inventory 객체를 전달하여 상점과 인벤토리를 연결


            
            
            


            while (true)
            {
                Console.Clear(); // 콘솔 화면을 지움
                Console.WriteLine($"{name}테스트 공간에서 무엇을 하고 싶으신가요?\n");
                Console.WriteLine("[1. 상태 보기]");
                Console.WriteLine("[2. 상점]");
                Console.WriteLine("[3. 인벤토리]");
                Console.WriteLine("\n원하시는 행동을 입력해주세요.");
                Console.WriteLine(">> ");



                switch (Console.ReadLine())
                {
                    case "1": // 상태 보기
                        player.DisplayStatus(); // Player 클래스의 DisplayStatus 메서드를 호출하여 상태를 보여줌
                        break;
                    case "2":
                        shop.DisplayShop(); // Shop 클래스의 DisplayShop 메서드를 호출하여 상점 화면을 보여줌
                        break;
                    case "3":
                        Console.WriteLine("인벤토리를 확인합니다.");
                        inventory.DisplayInventory(); // Inventory 클래스의 DisplayInventory 메서드를 호출하여 인벤토리 화면을 보여줌
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        continue;
                }
            }
            


        }
    }
}
