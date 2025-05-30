using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        foreach(char n in my_string)
        {
            switch(n)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    break;
                default:
                    answer += n;
                    break;
            }
        }
        
        return answer;
    }
}