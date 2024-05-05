/*一元算术运算符 */

// int a =3;
// int b=a++;  //先赋值后自增
// WriteLine($"a is {a}, b is {b}");

int c =3;
int d=++c;  //先自增后赋值
WriteLine($"c is {c}, d is {d}");
//-----------------------------------------------------

/* 二元算术运算符 */

int e =11;
int f=3;
WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");
//---------------------------------------------
double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");
//-----------------------------
/*条件逻辑运算符*/
bool a =true;
bool b =false;
static bool DoStuff(){

    WriteLine("I am doing some stuff.");
    return true;
} //定义自定义静态函数

WriteLine();
WriteLine($"a & DoStuff() = {a & DoStuff()}");
WriteLine($"b & DoStuff() = {b & DoStuff()}");
WriteLine("------------------------------------------------------");
WriteLine();
WriteLine($"a & DoStuff() = {a && DoStuff()}");
WriteLine($"b & DoStuff() = {b && DoStuff()}");
//当使用&&运算符的时候假如第一个条件是false那么条件二将不会执行，这就是短路布尔运算符&&的特性

