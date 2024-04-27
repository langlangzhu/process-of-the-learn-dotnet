
//根据编号的位置进行格式化
using System.Runtime.CompilerServices;

int numberOfApples=12;
decimal pricePerApple=0.35M;
Console.WriteLine(
  format:"{0} apples cost {1:C} 2:{2}  , 3:{3}, 4{4}",
    numberOfApples,
    pricePerApple * numberOfApples,
     numberOfApples,
    numberOfApples,// 确保这个参数存在
    numberOfApples
);
//-----------------------------------------------------
//使用内插字符串进行格式化

Console.WriteLine($"{numberOfApples} apples cost {pricePerApple
                         * numberOfApples:C}");
 
const string firstname ="Omar";
const string lastname="Rudberg";

const string fullname =$"{firstname}{lastname}";
Console.WriteLine(fullname);

//------------------------------------------------------------------------
//格式字符串
//语法如下:
/*

{index [,alignment] [:formatString]}
其中index 是一个 C# 表达式，比如一个变量或者一个计算式。
alignment 是一个可选项，它表示如何调整表达式的字符串表示形式的宽度。如果它是正数，则表示右对齐；如果它是负数，则表示左对齐。
formatString 也是一个可选项，它指定如何格式化表达式的值。例如，数字可以被格式化为货币、十进制、百分比等。
*/
string applesText="Apples";
int applesCount=1234;
string bananasText="Bananas";
int bananasCount=56789;
Console.WriteLine(
    format:"{0,-10} age={1,6:N0}",
     arg0:"name",
     arg1:"Count"
);
Console.WriteLine(
    format:"{0,-10} {1,6:N0}",
    arg0:applesText,
    arg1:applesCount
);
Console.WriteLine(
    format:"{0,-10} {1,6:N0}",
    arg0:bananasText,
    arg1:bananasCount
);