using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpg2
{
    public class Player
    {
        public string name { get; set; }
        public int PlayerLevel { get; set; }
        public string PlayerJob { get; set; }
        public int PlayerAttack { get; set; }
        public int PlayerDefense { get; set; }
        public int PlayerHealth { get; set; }
        public int PlayerGold { get; set; }


        public Player()
        {
            string Name = name; // 플레이어 이름
            int PlayerLevel = 1; // 레벨
            string PlayerJob = "전사"; // 직업
            int PlayerAttack = 10; // 공격력
            int PlayerDefense = 5; // 방어력
            int PlayerHealth = 100; // 체력
            int PlayerGold = 1500; // 골드
        }
        
                


        public void DisplayStatus()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("플레이어 상태를 확인합니다.\n");

                Console.WriteLine($"플레이어 이름: {name}");
                Console.WriteLine($"레벨: {PlayerLevel}");
                Console.WriteLine($"직업: {PlayerJob}");
                Console.WriteLine($"공격력: {PlayerAttack}");
                Console.WriteLine($"방어력: {PlayerDefense}");
                Console.WriteLine($"체력: {PlayerHealth}");
                Console.WriteLine($"골드: {PlayerGold}");

                Console.WriteLine("\n[0. 나가기]");
                string Exit = Console.ReadLine();
                if (Exit == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 시도해주세요.");
                    continue; // 잘못된 입력인 경우 다시 입력을 받도록 루프를 계속 진행
                }
            }
     
        }





    }
}
