using System.Security.Principal;

/*
WriteLine("Before parsing");
Write("What is your age? ");

string ? input =ReadLine();
try
{
  int age=int.Parse(input!); //'！'用于屏蔽空符号警告
  WriteLine($"You are {age} years old");

}
catch(OverflowException)
{
  WriteLine("Your age is a valid number format but it is either too big or small.");
}
catch(FormatException)
{
 WriteLine("The age you entered is not a valid number format.");
}
catch (Exception ex)
{
  WriteLine($"{ex.GetType()} says {ex.Message}");
}

WriteLine("After parsing");  */

//-------------------------------------------------------------
//用过滤器捕获异常,利用when关键字向catch语句添加过滤器

Write("Enter an amount: ");
string amount = ReadLine()!;
if(string.IsNullOrEmpty(amount)) 
{
  return;
}
try
{
  decimal amountValue = decimal.Parse(amount);
  WriteLine($"Amount formatted as currency: {amountValue:C}");
}
catch(FormatException) when (amount.Contains("$"))
{
  WriteLine("Amount cannot use the dollar sign!");
}
catch(FormatException)
{
  WriteLine("Amounts must only contain digits!");
}
//当你尝试将一个字符串转换成另一种数据类型（如整数、浮点数、日期等）时，如果输入的字符串不符合所期望的格式，就会抛出FormatException异常
//---------------------------------------------------------------

