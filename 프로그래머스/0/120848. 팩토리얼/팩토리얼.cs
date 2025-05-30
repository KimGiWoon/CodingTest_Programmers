using System;

public class Solution {
    int answer;
    int count = 1;
    public int solution(int n) {
        
        for(int i = 1; i <= 10; i++)
        {
            count *= i;
            
            if(count > n)
            {
                answer = i - 1;
                break;
            }
            else
            {
                answer = i;
            }
        } 
        
        return answer;
    }
}