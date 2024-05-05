using System.ComponentModel.DataAnnotations;
using System.Xml;

// object类型储存
object height =1.88;
object name ="Amir";
string namecopy= (string)name;
Console.WriteLine(name.GetType().Name);
Console.WriteLine($"{name} is {height} metres tall.");

//int length1 = name.Length;
int length2=((string)name).Length;//必须要转成string类的具体数据类型 ，否则单独的object调用Length编译器不知道调用的是什么类型的数据。

Console.WriteLine($"{name} has {length2} charcters.");

//---------------------------------
//动态存储类型(dynamic关键字)

dynamic something ="Ahmed";
something=12;
something=new []{3,5,7};
Console.WriteLine($"Length is {something.Length}");
Console.WriteLine(something.GetType().Name);

//---------------------------------------------------------------
//推断局部变量的类型

  // L:推断为long
  //UL:推断为ulong
  //M:推断为decimal
  //D:推断为double
  //F:推断为float

  var population =67_000_000;
  var weight =1.88;
  var price =4.99M;
  var friuit="Apples";
  var letter='z';
  var happy=true;
  
  var Xml1=new XmlDocument();

  XmlDocument xml2=new XmlDocument();
  
  var file1=File.CreateText("something1.txt");
  
  StreamWriter file2=File.CreateText("something2.txt");
  
  //----------------------------------------------------------------------------------
  //面向类型的new实例化对象
  XmlDocument xml3 =new();
  
  Person kim=new();
  
  kim.BirthDate=new(1967,12,26);
   
   List<Person> people =new()//这里的new其实new的是列表List
   {
    new(){FirstName = "Alice"},//这里new的是 Person
    new(){FirstName="Bob"},
    new(){FirstName="Charlie"}
   };

   foreach(var item in people)
   {
    Console.WriteLine(item.FirstName);
   }

 //------------------------------
 //获取和设置类型的默认值

 Console.WriteLine($"default(int) = {default(int)}");
 Console.WriteLine($"default(bool)={default(bool)}");
 Console.WriteLine($"default(DateTime)={default(DateTime)}");
 Console.WriteLine($"default(stirng)={default(string)}");
 //------------------------------------------------------------------
 //添加语句声明赋值，然后将其重置为默认值

 int number=13;
 Console.WriteLine($"number has been set to: {number}");
 number=default;//重置为默认值
 Console.WriteLine($"number has been reset to its default:{number}");
 