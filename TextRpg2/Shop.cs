using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpg2
{
    // 상점 클래스
    // 클래스를 나눈 이유는 상점과 아이템을 분리하여 관리하기 위함.
    // 아이템 클래스는 상점에서 판매되는 아이템의 속성을 정의하고, 상점 클래스는 아이템 목록을 관리하고 상점을 표시하는 기능을 포함.
    // Item 클래스는 상점에서 판매되는 아이템의 속성을 정의합니다.
    public class Item
    {
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public int ItemValue { get; set; }
        public string ItemDescription { get; set; }
        public int ItemPrice { get; set; }

        // 생성자 : 아이템의 순서대로 이름, 타입, 가치, 설명, 가격을 초기화합니다.
        public Item(string itemName, string itemType, int itemValue, string itemDescription, int itemPrice)
        {
            ItemName = itemName;
            ItemType = itemType;
            ItemValue = itemValue;
            ItemDescription = itemDescription;
            ItemPrice = itemPrice;
        }
    }
    public class Shop
    {
        // 아이템 목록을 반환하는 메서드입니다.
        // GetItemList 메서드는 상점에서 판매되는 아이템들을 정의하고, 이를 List<Item> 형태로 반환합니다.
        public List<Item> GetItemList()
        // 이 메서드는 상점에서 사용할 아이템 목록을 생성하는 역할을 합니다.
        // 반환되는 아이템 목록은 Item 클래스의 인스턴스들로 구성되어 있습니다.
        {
            return new List<Item>
            {
                new Item("나무검", "공격력", 5, "나무를 깍아 만든 기본 검", 300),
                new Item("녹슨 철검", "공격력", 8, "상태가 좋지 않은 철로 만든 검", 500),
                new Item("나무방패", "벙어력", 3, "나무로 만든 기본 방패", 300),
                new Item("철제 방패", "방어력", 10, "철로 만든 방패", 800)
            };
        }

        public void DisplayShop()
        {
            while (true)
            {
                Console.Clear(); // 콘솔 화면을 지움
                Console.WriteLine("상점에 오신것을 환영합니다.\n");

                Console.WriteLine("----------------------------------------------------------------------------");

                var items = GetItemList();
                foreach (var item in items)
                {
                    Console.WriteLine($"{item.ItemName}\t| {item.ItemType} +{item.ItemValue}\t| {item.ItemDescription}\t| {item.ItemPrice} Gold");
                }
                Console.WriteLine("\n[0. 나가기]");
                Console.WriteLine("\n원하시는 행동을 입력해주세요.");

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
