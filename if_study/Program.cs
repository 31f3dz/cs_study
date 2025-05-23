//ゲームの冒険の地形の話
//冒険プログラム

//プレイヤーがとある地形の上に立った時に
//起こるイベント

const float maxHP = 10; //プレイヤーの最大HP　定数
float currentHP = maxHP; //その時々のHP

int result; //何を踏んだかの結果

//地形の種類
//    0:通常    プラマイ0
//    1:回復    プラス
//    2:毒　    マイナス
//    3:罠　    即死

//地形の種類の名前を格納する配列
//string[] grounds = new string[4];
//grounds[0] = "通常";
//grounds[1] = "回復";
//grounds[2] = "毒";
//grounds[3] = "罠";
string[] grounds = { "通常", "回復", "毒", "罠" };

int cure = 5; //回復量
int poison = 5; //ダメージ量

Console.WriteLine("最初のHP：" + currentHP);

Random rand = new Random(); //ランダムな機能を持っているRandomクラスの能力を変数randに実体化（randという名前で実体化）
result = rand.Next(0,4); //Nextメソッドがランダム値を出す（0以上、4未満）

if(result == 1)
{
    //currentHP = currentHP + cure;
    currentHP += cure; //currentHPにcureを足して入れ直す
    if(currentHP > maxHP)
    {
        currentHP = maxHP;
    }
    Console.WriteLine(grounds[result] + "！現在のHP：" + currentHP);
}
else if(result == 2)
{
    //currentHP = currentHP - poison;
    currentHP -= poison; //currentHPにpoisonを引いて入れ直す
    if(currentHP < 0)
    {
        currentHP = 0;
        Console.WriteLine(grounds[result] + "！現在のHP：" + currentHP);
        Console.WriteLine("死亡した！");
    }
    else
    {
        Console.WriteLine(grounds[result] + "！現在のHP：" + currentHP);
    }
}
else if(result == 3)
{
    currentHP = 0;
    Console.WriteLine(grounds[result] + "！現在のHP：" + currentHP);
    Console.WriteLine("死亡した！");
}
else
{
    Console.WriteLine("何も起きなかった");
}
