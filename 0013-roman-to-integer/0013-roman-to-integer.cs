public class Solution {
    public int RomanToInt(string s) {
         Dictionary<char, int> RomanValues = new Dictionary<char, int>
    { {'I' , 1} , {'V' , 5} ,{ 'X' , 10},{'L' , 50} , {'C' , 100} ,{'D' ,500}
        ,{'M' ,1000}
    };

    int Total = 0;
    int prevValue = 0;
    for (int i = s.Length -1  ; i >= 0; i--)
    {
        int currentValue = RomanValues[s[i]];

        if (currentValue < prevValue)
        {
            Total -= currentValue;
        }
        else
        {
            Total += currentValue; 
        }
        prevValue = currentValue;
    }
    return Total;
    }
}