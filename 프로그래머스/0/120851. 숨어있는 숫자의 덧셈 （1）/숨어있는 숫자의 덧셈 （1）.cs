using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;      
        
        for(int i = 0; i < my_string.Length; i++)
        {
            if(char.IsNumber(my_string[i]) == true)
            {
                answer += (int)my_string[i] - 48;
            }
        }
        
        return answer;
    }
}