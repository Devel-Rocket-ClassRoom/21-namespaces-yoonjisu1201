using MyGame.Items;
using System;
using System.Xml.Serialization;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("=== 캐릭터 시스템 ===");

MyGame.Characters.Player player = new MyGame.Characters.Player();
MyGame.Characters.Enemy enemy = new MyGame.Characters.Enemy();

player.Name = "용사";
enemy.Type = "고블린";

player.Attack();
enemy.TakeDamage();
Console.WriteLine("\n=== 아이템 시스템 ===");

MyGame.Items.Weapon weapon = new MyGame.Items.Weapon();
MyGame.Items.Potion potion = new MyGame.Items.Potion();

weapon.Name = "불꽃검";
potion.Name = "체력 포션";

weapon.GetDamege(50);
potion.Use();





namespace MyGame.Characters
{
    public class Player
    {
        public string Name;
        public void Attack()
        {
            Console.WriteLine($"플레이어 {Name}(이)가 공격합니다!");
        }
    }

    public class Enemy
    {
        public string Type;
        public void TakeDamage()
        {
            Console.WriteLine($"적 {Type}(이)가 데미지를 받았습니다!");
        }
    }
}

namespace MyGame.Items
{
    public class Weapon
    {
        public string Name;
        public void GetDamege(int damage)
        {
            Console.WriteLine($"무기 {Name}의 공격력: {damage}");
        }
    }
    public class Potion
    {
        public string Name;
        public void Use()
        {
            Console.WriteLine($"포션 {Name}을(를) 사용했습니다.");
        }
    }
}
