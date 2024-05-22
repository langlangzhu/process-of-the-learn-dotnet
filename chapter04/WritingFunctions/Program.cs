static string CardinalToOrdinal(int number)
{
    int lastTwoDigits = number % 100;
    switch(lastTwoDigits)
    {
        case 11:
        case 12:
        case 13:
            return $"{number}th";
        default:
            int lastDigit=number%10;

            string suffix=lastDigit switch  //lastDigit switch 是用来根据 lastDigit 的值进行匹配，并返回匹配的结果。
            {   
                1=>"st",
                2=>"nd",
                3=>"rd",
                _=>"th"
            }; 
            return $"{number:N0}{suffix}";        
                 
            }
            
}

static int FibFunctional(int term) =>

    term switch
    {
        1=>0,
        2=>1,
        _=> FibFunctional(term -1) + FibFunctional(term-2)
    };

static void RunFibFunctional()
{
    for(int i=1;i<=30;i++)
    {
        WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
          arg0: CardinalToOrdinal(i),
          arg1: FibFunctional(term:i)
        );
    }
}

RunFibFunctional();