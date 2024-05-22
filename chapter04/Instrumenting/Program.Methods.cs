using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

partial class Program
{
    static void LogSourceDetails(
        bool condition,
        [CallerMemberName] string member = "",
        [CallerFilePath] string filePath = "",
        [CallerLineNumber] int line = 0,
        [CallerArgumentExpression(nameof(condition))] string expression=" "
        /*
        [CallerMemberName] string member = "": 这个特性会自动填充调用 LogSourceDetails 
        的代码所在的成员（通常是方法或属性）的名称。例如，如果 LogSourceDetails 是在 MyMethod 
        方法中调用的，member 参数就会被设为 "MyMethod"。
        [CallerLineNumber] int line = 0: 这个特性会提供调用 LogSourceDetails 的代码所在的行号。
        例如，如果调用在 MyMethod 的第10行，line 参数就会被设为 10。
        [CallerArgumentExpression(nameof(condition))] string expression=" ": 
        这个特性从C# 10开始引入，用于获取调用 LogSourceDetails 时 condition 参数的表达式字符串。
        例如，如果调用时 condition 是 x > 5，expression 就会被设为 "x > 5"。
        */
    )
    {
        Trace.WriteLine(string.Format(
            "[{0}\n {1} on line {2}. Expression: {3}]",
            filePath,member,line,expression));
    }

}