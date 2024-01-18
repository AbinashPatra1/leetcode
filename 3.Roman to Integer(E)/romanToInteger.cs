public class Solution {
    Dictionary<char,int> Romans = new Dictionary<char,int>()
    {
        {'I',1},{'V',5},{'X',10},{'L',50},{'C',100},{'D',500},{'M',1000}
    };

    public int RomanToInt(string s) {
        int number = 0;
        char[] strArr = s.ToCharArray();
        Array.Reverse(strArr);
        char prev = new char();
        foreach(char c in strArr){
            if( (c == 'I' && (prev == 'V' || prev == 'X')) ||
                (c == 'X' && (prev == 'L' || prev == 'C')) ||
                (c == 'C' && (prev == 'D' || prev == 'M')) )
                {
                    number = number - Romans[c];
                }
            else
                {
                    number = number + Romans[c];
                }
            prev = c;
        }
        return number;
    }
}

////METHOD 2;

//using System.Collections.Generic;
public class Solution {
    Dictionary<char,int> Romans = new Dictionary<char,int>()
    {
        {'I',1},{'V',5},{'X',10},{'L',50},{'C',100},{'D',500},{'M',1000}
    };

    public int RomanToInt(string s) {
        int number = 0;
        int num = 0;
        char[] strArr = s.ToCharArray();
        Array.Reverse(strArr);
        foreach(char c in strArr){
            if(4 * Romans[c] < number)
                number -= Romans[c];
            else
                number += Romans[c];
        }
        return number;
    }
}