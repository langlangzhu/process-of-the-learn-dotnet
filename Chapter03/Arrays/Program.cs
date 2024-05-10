/*对于一维数组
对于一维数组，如int[] arr = new int[5];，.GetUpperBound(0)会返回数组
最后一个元素的索引位置，而.GetLowerBound(0)几乎总是返回0，因为C#的一维数组下标默认从0开始。
所以上述一维数组的上界将是4（因为它有5个元素，索引从0到4）。
------------------------------------------------------------------------------
对于二维数组
对于常规的二维数组（非交错数组，如string[,] grid），这两个方法分别提供了对数组两个维度上下界的访问。
例如，一个声明为string[,] grid = new string[3, 4];的二维数组，.GetUpperBound(0)会返回行数减1（即2），
.GetUpperBound(1)会返回列数减1（即3）。
-----------------------------------------------------------------------
对于交错数组（Jagged Arrays）
string[][] grid1是一个交错数组，它在概念上是一维数组，其中的每个元素又是一个一维数组。
因此，对于交错数组，.GetLowerBound(0)和.GetUpperBound(0)是有效的，
它们分别返回交错数组（外层数组）的第一个和最后一个元素的索引。在您的代码中，这将分别是0和3，因为您有4个子数组。*/

//二维数组

string[,] grid2=new[,]{
    {"Alpha","Beta","Gamma","Delta"},
{"Anne","Ben","Charlie","Doug"},
{"Aardvark","Bear","Cat","Dog"},
{"Aardvark","Bear","Cat","Dog"}
};

WriteLine($"Lower bound of the first dimension is: {grid2.GetLowerBound(0)}");//对于二维数组，其获取行数的下限
WriteLine($"Upper bound of the first dimension is: {grid2.GetUpperBound(0)}");//对于二维数组，其获取行数的上限
WriteLine($"子数组2的值是:{grid2[0,0]}");
                                                                                /*0代表行，1代表列*/
WriteLine($"Lower bound of the first dimension is: {grid2.GetLowerBound(1)}"); //对于二维数组，其获取列数的下限
 WriteLine($"Upper bound of the first dimension is: {grid2.GetUpperBound(1)}");//对于二维数组，其获取列数的上限
//-------------------------------------------------------------------------------------------------------
//for循环二维数组
for(int row=0;row<=grid2.GetUpperBound(0);row++)
{
    for(int col=0;col <=grid2.GetUpperBound(1);col++)
    {
        WriteLine($"Row {row}, Column {col}: {grid2[row,col]}");
    }
}

//--------------------------------------------------------------------------------------------------------
//交错（锯齿）数组
string[][] grid1 = new[]
{
    new[] {"Alpha","Beta","Gamma","Delta"},
    new[] {"Anne","Ben","Charlie","Doug"},
    new[] {"Aardvark","Bear","Cat","Dog"},    
    new[] {"Aardvark","Bear","Cat","Dog"}

};   
/*对于交错数组来说实际上它就是个一维套一个一维数组，所以GetLowerBound是按照一维数组的规则来的*/
WriteLine($"Lower bound of the first dimension is: {grid1.GetLowerBound(0)}"); 
WriteLine($"Upper bound of the first dimension is: {grid1.GetUpperBound(0)}");

WriteLine($"子数组1的值是:{grid1[0][0]}");
// WriteLine($"Lower bound of the first dimension is: {grid1.GetLowerBound(1)}");
// WriteLine($"Upper bound of the first dimension is: {grid1.GetUpperBound(1)}");
if (grid1.Length > 0) // 确保至少有一个子数组
{
    var firstSubArray = grid1[0];
    WriteLine($"Lower bound of the sub-array is: {firstSubArray.GetLowerBound(0)}");
    WriteLine($"Upper bound of the sub-array is: {firstSubArray.GetUpperBound(0)}");
}//交错数组获取行列上下限

/*从本质上来说二维数组和交错数组的区别在于:二维数组在存储的时候地址是连续的，而交错数组由于内部的子数组全部
都是分别new的，所以他们的地址是不连续的。所以我们在调用二维数组的时候内部实现原理是这样的：
二维索引到一维索引的转换。这个转换通常是基于数组的行数进行的，如果数组是行主序存储（大多数语言包括C#默认如此），
那么元素 array[row][column] 实际上映射到一维地址 row * 列数 + column。
如果是列主序，则转换方式会是 column * 行数 + row。所以我们回过头来看待二维数组在存储的时候他就是一个一维数组，只是我们写语法的时候设计者让我们
写起来像二维的写法，而交错数组我们可以把他看成是一维数组套了另外一个一维数组，所以访问交错数组我们可以写成：[][]。
*/

//-------------
//如果无法使用数组初始化语法，可能因为正从文件或数据库中加载值，此时我们可以用以下写法：
string[,] grid3 =new string [3,4];
grid3[0,0]="Alpha";
grid3[0,1]="Beta";
grid3[2,3]="Dog";

//------------------------------------------------------------------------
//---交错(锯齿)数组样例

string[][] jagged = new[]
{
    new[]{"Alpha","Beta","Gamma"},
    new[]{"Anne","Ben","Charlie","Doug"},
    new[]{"Aar"}
}