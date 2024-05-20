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

            string suffix=lastDigit switch
            {   
                1=>"st",
                2=>"nd",
                3=>"rd",
                _=>"th"
            }; 
            return $"{number:N0}{suffix}";        
                }
}