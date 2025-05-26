//ライブラリから機能を引っ張るために必要なものを宣言
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_study
{
    internal class Player
    {
        private string name;
        protected int hp;
        protected float attack;
        private float defence;
        private string job;

        //コンストラクタの設計
        public Player() : this("名無し") //引数付きコンストラクタを利用している
        {
        }

        //引数付きコンストラクタ
        public Player(string name)
        {
            this.name = name;
            hp = 100;
            attack = 10;
            defence = 10;
            job = "村人";
        }

        public int HP
        {
            //set
            //{
            //    //valueは値を代入する際の想定値
            //    this.hp = value;
            //    if (this.hp < 0)
            //    {
            //        this.hp = 0;
            //    }
            //}
            get
            {
                //returnの後にある値を結果として返す
                return this.hp;
            }
        }

        //名前をセット
        public void NameSet(string name)
        {
            this.name = name; //変数nameに引数nameを代入
        }

        //職業をセット
        public void JobSet(string job)
        {
            this.job = job; //変数jobに引数jobを代入
        }

        //引数に応じて行動が変わるメソッド
        public void Action()
        {
            Console.WriteLine("横にかわした！");
        }

        public void Action(int i)
        {
            if (i == 1) Console.WriteLine(attack + "の力で攻撃した！");
            else if (i == 2) Console.WriteLine(defence + "の力で防御した！");
            else Console.WriteLine("横にかわした！");
        }

        public void StatusDisplay()
        {
            Console.WriteLine("名前は：" + name);
            Console.WriteLine("HPは：" + hp);
            Console.WriteLine("攻撃力は：" + attack);
            Console.WriteLine("防御力は：" + defence);
            Console.WriteLine("職業は：" + job);
        }

        //超必殺技
        public virtual void SpecialAttack()
        {
            Console.WriteLine("何か凄い攻撃！");
        }
    }
}
