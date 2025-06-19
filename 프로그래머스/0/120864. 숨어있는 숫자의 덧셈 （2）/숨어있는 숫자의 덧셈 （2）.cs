using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        int saveNum = 0;
        my_string += "Z";
        
        foreach(char n in my_string)
        {
            if(char.IsDigit(n))
            {
                saveNum = saveNum * 10 + (n - '0');
            }
            else
            {
                answer += saveNum;
                saveNum = 0;
            }
        }
        
        return answer;
    }
}