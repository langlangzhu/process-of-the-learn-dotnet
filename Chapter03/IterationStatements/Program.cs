//while循环语句
int x=0;
while(x < 10)
{
    WriteLine(x);
    x++;
}

WriteLine("---------------------------------------------------------");
//利用标签和goto组合实现while的功能
int y =0;
test1:
    if(y<10)
    {
        WriteLine(y);
        y++;
        goto test1;
    }
//------------------------------
//do while 循环语句
string ? password;
int i=0;
do 
{  i++;
    if(i>10)
    break;
    WriteLine($"第{i}次尝试......");
    Write("Enter your password：");
    password=ReadLine();
}
while(password != "Pa$$w0rd");
WriteLine("Correct!");
