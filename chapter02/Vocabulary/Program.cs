// using System.Reflection;
// Assembly? myApp=Assembly.GetEntryAssembly();

// if(myApp == null) return;

// foreach(AssemblyName name in myApp.GetReferencedAssemblies())
// {
//     Assembly a =Assembly.Load(name);
//     int methodCount =0;
//     foreach(TypeInfo t in a.DefinedTypes)
//     {
//         methodCount+=t.GetMethods().Count();

//     }

//     Console.WriteLine(
//         "{0:N0} types with {1:N0} methods in {2} assembly.",
//         arg0:a.DefinedTypes.Count(),
//         arg1:methodCount,
//         arg2:name.Name
//     );
// }
// System.Data.DataSet ds;
// HttpClient client;

//nameof 将会输出变量的名称.
using System.Data.Common;

double heightInMetres=1.88;
Console.WriteLine($"The Variable {nameof(heightInMetres)} has the value {heightInMetres}.");
//输出显示:The Variable heightInMetres has the value 1.88.

string firstName="Bob";
string lastname="Smith";
string phoneNumber="(215) 555-4256";

string horizontalLine=new('-',count:74);
/*输出emoji*/
Console.OutputEncoding=System.Text.Encoding.UTF8;//设置输出编码为UTF-8
string grinningEmoji=char.ConvertFromUtf32(0x1F600);
Console.WriteLine(grinningEmoji);
//-----------------------------------------------------------------------
string fullNameWithTabSeparator="Bob\tSmith";
Console.WriteLine(fullNameWithTabSeparator);
string filePath="E:\televisions\tony\bravia.txt";
string filePaths=@"E:\televisions\tony\bravia.txt";  //逐字字符串必须加上@符号作为前缀.
Console.WriteLine(filePath);
Console.WriteLine(filePaths);
//------------------------------------------------------------------

string xml="""
         <person age="50">
            <first_name>Mark</first_name>
         </person>

        """;

var person =new {FirstName="Alice",Age=56};
string json=$$$"""
{
    "first_name": "{person.FirstName}",
    "age":{{person.Age}}
    "calculation,
    "{{{{1+2}}}}"
}
""";
Console.WriteLine(json);
//------------------------------------------------------------------
//探索整数
 int decimalNotation=2_000_000;
 int binaryNotation=0b_0001_1110_1000_0100_1000_0000;
 int hexadecimalNotation=0x_001E_8480;

Console.WriteLine(decimalNotation);
Console.WriteLine(binaryNotation);

//---------------------------------------------
//显示三种数字数据类型的大小

Console.WriteLine($@"int uses {sizeof(int)} bytes and can store numbers in the range
    {int.MinValue:N0} to {int.MaxValue:N0}.");

Console.WriteLine($@"double uses {sizeof(double)} bytes and can store numbers
    in the range {double.MinValue:N0} to {double.MaxValue:N0}.");

Console.WriteLine($@"decimal uses {sizeof(decimal)} bytes and can store numbers
    in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

//-----------------------------------------------
//比较double 和decimall类型
//Double
Console.WriteLine("Using double:");
double a =0.1;
double b=0.2;
if(a+b==0.3)
{
    Console.WriteLine($"{a}+{b} equals {0.3}");
}
else
{
     Console.WriteLine($"{a}+{b} does NOT equal {0.3}");
}
//decimal
Console.WriteLine("Using decimal:");
decimal c =0.1M;
decimal d=0.2M;
if(c+d==0.3M)
{
    Console.WriteLine($"{c}+{d} equals {0.3}");
}
else
{
     Console.WriteLine($"{c}+{d} does NOT equal {0.3}");
}
