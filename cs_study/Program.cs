//45ページ　変数の型

//整数型
int month; //月
month = 5;
//変数の宣言と初期化を別で行った

int day = 22; //宣言と初期化を同時に行った

//単精度小数点型
float temperature_f = 26.2f;

//倍精度小数点型
double temperature_d = 26.2;

//文字列型
string week = "木曜日"; //ダブルクォーテーション

//フラグ（論理型） true / false
bool temp_display = false;

//まとめる文字列
string announce = month + "月" + day + "日は" + week + "です。";

Console.WriteLine(announce);

//もしもtemp_displayがON（true）なら温度の情報を出す
if(temp_display == true)
{
    Console.WriteLine("温度は" + temperature_f + "度です。");
}
