using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpg2
{
    public class Inventory
    {
        private List<Item> items = new List<Item>(); // 인벤토리 아이템 목록
        private HashSet<int> equippedIndices = new HashSet<int>(); // 여러 장착 인덱스
        private Player player; // Player 참조

        public Inventory(Player player = null)
        {
            this.player = player;
        }

        public void SetPlayer(Player player)
        {
            this.player = player;
        }

        // 아이템 추가 메서드
        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void DisplayInventory()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("인벤토리 목록:");
                Console.WriteLine("----------------------------------------------------------------------------");
                if (items.Count == 0)
                {
                    Console.WriteLine("인벤토리가 비어 있습니다.");
                }
                else
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        var item = items[i];
                        if (equippedIndices.Contains(i))
                        {
                            Console.WriteLine($"-[E] {item.ItemName}\t| {item.ItemType} +{item.ItemValue}\t| {item.ItemDescription}\t| {item.ItemPrice} Gold");
                        }
                        else
                        {
                            Console.WriteLine($"- {item.ItemName}\t| {item.ItemType} +{item.ItemValue}\t| {item.ItemDescription}\t| {item.ItemPrice} Gold");
                        }
                    }
                }

                Console.WriteLine("\n[1. 장착관리]");
                Console.WriteLine("[0. 나가기]");
                string Input = Console.ReadLine();
                if (Input == "0")
                {
                    break;
                }
                else if (Input == "1")
                {
                    if (items.Count == 0)
                    {
                        Console.WriteLine("장착할 아이템이 없습니다.");
                        Console.ReadKey();
                        continue;
                    }

                    Console.Clear();
                    Console.WriteLine("인벤토리 목록:");
                    Console.WriteLine("----------------------------------------------------------------------------");
                    for (int i = 0; i < items.Count; i++)
                    {
                        var item = items[i];    
                        if (equippedIndices.Contains(i))
                        {
                            Console.WriteLine($"-{i + 1}[E] {item.ItemName}\t| {item.ItemType} +{item.ItemValue}\t| {item.ItemDescription}\t| {item.ItemPrice} Gold");
                        }
                        else
                        {
                            Console.WriteLine($"-{i + 1} {item.ItemName}\t| {item.ItemType} +{item.ItemValue}\t| {item.ItemDescription}\t| {item.ItemPrice} Gold");
                        }
                    }

                    Console.WriteLine("장착/해제할 아이템 번호를 입력하세요 (1~{0}), [0. 취소]", items.Count);
                    string sel = Console.ReadLine();
                    if (sel == "0") continue;
                    if (int.TryParse(sel, out int idx) && idx >= 1 && idx <= items.Count)
                    {
                        int realIdx = idx - 1;
                        var item = items[realIdx];

                        if (equippedIndices.Contains(realIdx))
                        {
                            // 해제: 능력치 감소
                            if (player != null)
                            {
                                if (item.ItemType == "공격력")
                                    player.PlayerAttack -= item.ItemValue;
                                else if (item.ItemType == "방어력")
                                    player.PlayerDefense -= item.ItemValue;
                            }
                            equippedIndices.Remove(realIdx);
                        }
                        else
                        {
                            // 장착: 능력치 증가
                            if (player != null)
                            {
                                if (item.ItemType == "공격력")
                                    player.PlayerAttack += item.ItemValue;
                                else if (item.ItemType == "방어력")
                                    player.PlayerDefense += item.ItemValue;
                            }
                            equippedIndices.Add(realIdx);
                        }
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다. 다시 시도해주세요.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 시도해주세요.");
                    continue;
                }
            }
        }
    }
}
