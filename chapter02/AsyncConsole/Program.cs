
//发送Http异步请求
HttpClient client =new();
HttpResponseMessage response= await client.GetAsync("http://www.apple.com/");
WriteLine("Apple's home page has {0:N0} bytes."
    , response.Content.Headers.ContentLength);

    string compilerVersion = typeof(object).Assembly.ImageRuntimeVersion;
        Console.WriteLine("C# Compiler Version: " + compilerVersion);
 // 获取语言版本
string languageVersion = Environment.Version.ToString();
Console.WriteLine("Language Version: " + languageVersion);

WriteLine(sizeof(double));

//----------------------------------------
//控制程序流程、转换类型和处理异常

//操作变量