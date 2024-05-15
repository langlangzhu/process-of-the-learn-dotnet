//使用checked关键字来捕获溢出异常
/*int x = int.MaxValue -1;
WriteLine($"Initial value : {x}");
x++;
WriteLine($"After incrementing: {x}");
x++;
WriteLine($"After incrementing: {x}");
x++;
WriteLine($"After incrementing: {x}");   */

/*以上代码会依次输出：
Initial value : 2147483646
After incrementing: 2147483647
After incrementing: -2147483648
After incrementing: -2147483647
以上代码仅仅作为参照物
*/
//接下来我们将使用checked关键字来捕获溢出异常

using System.Threading.Channels;

try
{
checked
{
    int y = int.MaxValue -1;
    WriteLine($"Initial value : {y}");
    y++;
    WriteLine($"Initial value : {y}");
    y++;
    WriteLine($"Initial value : {y}");
    y++;
    WriteLine($"Initial value : {y}");
}
}
catch(OverflowException)
{
    WriteLine("The code overflowed but I caught the exception.");
}
/*Initial value : 2147483646
Initial value : 2147483647
Unhandled exception. System.OverflowException: Arithmetic operation resulted in an overflow.
   at Program.<Main>$(String[] args) in E:\dotNet7Visutal Stdio\Chapter03\CheckingForOverflow\Program.cs:line 26
   */
   //以上是checked关键字捕获溢出异常的代码输出，我们可以看到checked可以捕获溢出的部分。

//-------------------------------------------------------------------------------
//使用unchecked语句来禁用编译时溢出检查

unchecked{
int z= int.MaxValue+1;
WriteLine($"Initial value : {z}");
z--;
WriteLine($"After decrementing: : {z}");
z--;
WriteLine($"After decrementing: : {z}");
}
//unchecked关键字关闭编译器在代码块内执行的溢出检查。
