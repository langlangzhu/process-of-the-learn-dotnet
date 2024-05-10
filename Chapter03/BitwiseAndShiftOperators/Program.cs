int a =10; //00001010
int b=6; // 00000110

WriteLine($"a = {a}");
WriteLine($"b = {b}");
WriteLine($"a & b = {a & b}"); //二进制的与运算
WriteLine($"a | b = {a | b}"); //二进制的或运算
WriteLine($"a ^ b = {a ^ b}"); //二进制的异或运算
//-----
//二进制移位符

WriteLine($"a << 3 ={a << 3}"); //此时a从00001010=>01010000,往左边移动了三位，右边空缺的位置补0.

WriteLine($"b >> 1 = {b >> 1}"); //此时b从00000110=>00000011，往右平移1位,左边空缺位置补0.右边多余部分舍去

//---------------
//将整数值转换为包含0和1的二进制字符串

WriteLine();
WriteLine("Outputting integers as binary:");
WriteLine($"a=       {ToBinaryString(a)}");
WriteLine($"b=       {ToBinaryString(b)}");

static string ToBinaryString(int value)
{
    return Convert.ToString(value, toBase:2).PadLeft(8, '0');
}
/*Convert.ToString(value, toBase:2): 这是 .NET Framework 提供的 Convert 类中的一个方法，
用于将数字转换成其等效的字符串表示形式。value 是要转换的整数，而 toBase:2 指定了基数（二进制）
，因此这个调用将 value 转换为二进制的字符串形式。
.PadLeft(8, '0'): 这是字符串的一个方法，用于确保字符串达到一定的长度。
如果字符串的长度小于指定的长度（这里是8），这个方法会在字符串的左边填充指定的字符（这里是 '0'）直到字符串的长度为8。
如果字符串长度已经是8或更长，那么这个方法不会改变字符串。
*/

int age=50;
char firstDigit= age.ToString()[0]; //将整型数据转换成字符串，然后取第一个字符
WriteLine(firstDigit);

