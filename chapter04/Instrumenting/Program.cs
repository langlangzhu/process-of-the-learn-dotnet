using System.Diagnostics;
using Microsoft.Extensions.Configuration;

/*
string logPath=Path.Combine(Environment.GetFolderPath(
    Environment.SpecialFolder.DesktopDirectory),"log.txt"
);

WriteLine($"writing to: {logPath}");

TextWriterTraceListener logFile =new (File.CreateText(logPath));//File.CreateText(logPath) 创建一个新的文本文件，如果文件已存在，将会被覆盖。

Trace.Listeners.Add(logFile);//将日志的文件路径添加进监听列表
Trace.AutoFlush=true;//这意味着每次写入后都会立即刷新缓冲区，确保内容立即写入到文件。
Debug.WriteLine("Debug says, I am watching!");//只会在Debug调试状态下运行

Trace.WriteLine("Trace says, I am watching!");//可以通过配置来决定是否开启

 /*当以dotnet run --configuration Debug运行时，日志文件将处于监听列表，此时
 Debug.WriteLine和Trace.WriteLine都将写入日志文件
 ，而以dotnet run --configuration Release运行时，仅仅Trace.WriteLine将会写入日志文件。*/

/*
 <PackageReference Include="Microsoft.Extensions.Configuration" Version="8.0.0" />
    <PackageReference Include="Microsoft.Extensions.Configuration.Binder" Version="8.0.1" />
    <PackageReference Include="Microsoft.Extensions.Configuration.FileExtensions" Version="8.0.0" />
    <PackageReference Include="Microsoft.Extensions.Configuration.Json" Version="8.0.0" />
//在命令行中输入 dotnet add package nuget包以导入。
*/

//---------------------------------------------------------------------------------

WriteLine("Reding from appsettings.json in {0}",Directory.GetCurrentDirectory()) ;

ConfigurationBuilder builder=new ();//ConfigurationBuilder的主要作用是组合不同的配置源，以便应用程序可以从这些源中读取配置设置。
builder.SetBasePath(Directory.GetCurrentDirectory());
/*
    SetBasePath是ConfigurationBuilder类的一个方法，它用于设置配置源的基路径。
    这个基路径主要用于确定配置文件的相对位置，当添加像AddJsonFile、AddXmlFile或AddIniFile这样的文件源时，
    它们会相对于这个基路径来查找文件。
    */

builder.AddJsonFile("appsettings.json",optional:true,reloadOnChange:true);//向ConfigurationBuilder实例添加一个JSON配置源

//`appsettings.json`文件`
/*
"appsettings.json"是你要添加的JSON配置文件的名称。
这个文件通常包含应用程序的配置设置，
如数据库连接字符串、API密钥或其他环境特定的设置。
*/
IConfigurationRoot configuration=builder.Build();//这行代码是将之前通过ConfigurationBuilder配置的所有源合并并构建为一个完整的配置实例。

TraceSwitch ts =new(
    displayName:"PackSwitch",
    description:"This switch is set via a  Json config."
);

configuration.GetSection("PackSwitch").Bind(ts);

Trace.WriteLineIf(ts.TraceError,"Trace error");
Trace.WriteLineIf(ts.TraceWarning,"Trace warning");
Trace.WriteLineIf(ts.TraceInfo,"Trace infomation"); 
Trace.WriteLineIf(ts.TraceVerbose,"Trace verbose");

int unitsInStock =12;
LogSourceDetails(unitsInStock > 10);
Console.ReadLine();
