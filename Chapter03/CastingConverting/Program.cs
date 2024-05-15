using static System.Convert;

double g =9.8;
int h= ToInt32(g);//System.Convert的一个方法
WriteLine($"g is {g} and h is {h}"); //convert转换会将double值圆整为10，而不是去掉小数点后的部分

//圆整数字
//默认的圆整规则:如果小数部分是0.5或更大，则向上圆整；如果小数部分比0.5小，则向下圆整。
//C#中的圆整规则:  
/*
 如果小数部分小于0.5，则向下圆整。
 如果小数部分大于0.5，则向上圆整。
 如果小数部分等于0.5，那么在非小数部分是奇数的情况下向上圆整，在非小数部分是偶数的情况下向下圆整。
*/
double [] doubles =new []
{9.49,9.5,9.51,10.49,10.5,10.51};

foreach(double n in doubles)
{
    WriteLine($"ToInt32({n} is {ToInt32(n)})");
    //Math类的Round方法控制圆整规则
    // Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero);
}

//从任何类型转换成字符串
int number =12 ;
WriteLine(number.ToString());
bool boolean =true;
WriteLine(boolean.ToString());
DateTime now = DateTime.Now;
WriteLine(now.ToString());
object me =new();
WriteLine(me.ToString());
//----------------------------------------------------------------------
byte[] binaryObject = new byte[128];

Random.Shared.NextBytes(binaryObject); 
/*
当你调用 NextBytes 方法时，它会自动处理数组中每个位置的随机值填充，
你不需要在外部对数组的每个位置单独调用随机数生成方法。
*/

WriteLine("Binary Object as bytes:");
for(int index=0; index < binaryObject.Length;index++)
{
    Write($"{binaryObject[index]:X} "); //:X代表了输出将以16进制输出。
}
WriteLine();
// ToBase64String属于System.Convert方法
String encoded = ToBase64String(binaryObject);//将 8 位无符号整数的数组转换为其用 Base64 数字编码的等效字符串表示形式。
WriteLine($"Binary Object as Base64: {encoded}");

//---------------------------------------------------------------------------------------
//将字符串转换成数字或日期和时间
int age =int.Parse("27");

DateTime birthday=DateTime.Parse("2024 05 1");

WriteLine($"I was born {age} years ago.");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthdayis {birthday:D}.");//D格式表示仅输出使用了长日期格式的日期部分(只有年月日)

//int count= int.Parse("abc");//r如果字符串无法转换，将会报错

//--------------------------
//使用TryParse方法避免异常

Write("How many eggs are  there? ");
string? input =ReadLine();

//out 关键字允许TryParse在转换时设置count变量
if(int.TryParse(input,out int count ))
{
  WriteLine($"There are {count} eggs.");

}
else
{
    WriteLine("I could not parse the input.");
}
//---------------------------------------------------------------------------------
 


