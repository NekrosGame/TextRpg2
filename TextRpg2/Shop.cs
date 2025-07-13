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
        public Player player { get; set; } // Player 객체를 상점 클래스에 추가
        public Inventory inventory { get; set; } // 인벤토리 참조
        private List<Item> purchasedItems = new List<Item>(); // 필드로 변경하여 상점 이용 시 구매내역 유지

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
                new Item("나무방패", "방어력", 3, "나무로 만든 기본 방패", 300),
                new Item("철제 방패", "방어력", 10, "철로 만든 방패", 800)
            };
        }

        public void DisplayShop()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("상점에 오신것을 환영합니다.\n");
                Console.WriteLine("----------------------------------------------------------------------------");

                var items = GetItemList();
                for (int i = 0; i < items.Count; i++)
                {
                    var item = items[i];
                    bool isPurchased = purchasedItems.Any(x => x.ItemName == item.ItemName);
                    string priceOrPurchased = isPurchased ? "구매완료" : $"{item.ItemPrice} Gold";
                    Console.WriteLine($"- {item.ItemName}\t| {item.ItemType} +{item.ItemValue}\t| {item.ItemDescription}\t| {priceOrPurchased}");
                }

                Console.WriteLine("\n[1. 구매하기]");
                Console.WriteLine("[0. 나가기]");
                Console.WriteLine("\n원하시는 행동을 입력해주세요.");

                string Exit = Console.ReadLine();
                if (Exit == "0")
                {
                    break;
                }
                else if (Exit == "1")
                {
                    Console.Clear();
                    Console.WriteLine("상점에 오신것을 환영합니다.\n");
                    Console.WriteLine("----------------------------------------------------------------------------");
                    for (int i = 0; i < items.Count; i++)
                    {
                        var item = items[i];
                        bool isPurchased = purchasedItems.Any(x => x.ItemName == item.ItemName);
                        string priceOrPurchased = isPurchased ? "구매완료" : $"{item.ItemPrice} Gold";
                        Console.WriteLine($"-{i + 1} {item.ItemName}\t| {item.ItemType} +{item.ItemValue}\t| {item.ItemDescription}\t| {priceOrPurchased}");
                    }

                    Console.WriteLine("구매할 아이템의 번호를 입력해주세요.");
                    Console.WriteLine("[0. 나가기]");

                    while (true)
                    {
                        string input = Console.ReadLine();
                        if (input == "0")
                        {
                            break;
                        }

                        int itemIndex;
                        if (int.TryParse(input, out itemIndex) && itemIndex >= 1 && itemIndex <= items.Count)
                        {
                            var selectedItem = items[itemIndex - 1];
                            bool isPurchased = purchasedItems.Any(x => x.ItemName == selectedItem.ItemName);

                            if (isPurchased)
                            {
                                Console.WriteLine("이미 구매한 아이템입니다.");
                                continue;
                            }

                            // 여기서 BuyItem만 호출하고, player.PlayerGold 차감 및 purchasedItems 추가는 BuyItem에서만 처리
                            if (BuyItem(selectedItem))
                            {
                                purchasedItems.Add(selectedItem);
                                Console.WriteLine($"{selectedItem.ItemName}을(를) 구매하셨습니다.");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                        }
                    }
                }                   
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 시도해주세요.");
                    continue;
                }
            }
        }

        // 반환값을 bool로 변경하여 구매 성공 여부를 알 수 있게 함
        public bool BuyItem(Item item)
        {
            if (player.PlayerGold >= item.ItemPrice)
            {
                player.PlayerGold -= item.ItemPrice;
                inventory.AddItem(item); // 인벤토리에 아이템 추가
                return true;
            }
            else
            {
                Console.WriteLine("골드가 부족합니다.");
                return false;
            }
        }
    }
}
