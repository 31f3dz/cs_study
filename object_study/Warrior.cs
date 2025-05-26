using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_study
{
    internal class Warrior : Player
    {
        public Warrior() : this("名無し")
        {
        }

        public Warrior(string name) : base(name)
        {
            hp = 120;
            attack = 20;
            JobSet("戦士");
        }

        public void HardAttack()
        {
            Console.WriteLine("両手持ち攻撃！");
        }

        //超必殺技
        public override void SpecialAttack()
        {
            Console.WriteLine("滅茶苦茶凄い攻撃！");
        }
    }
}
