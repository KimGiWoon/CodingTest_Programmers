using System;

public class Solution {
    public int solution(int n, int k) {
        int answer = 0;
        int lamb = 12000;
        int drink = 2000;
        
        // 양고기 1인분 12,000원
        for(int i = 1; i < n + 1; i++)
        {
            answer += lamb;
            // 10인분에 음료수 1개 서비스 
            if(i % 10 == 0)
            {
                answer -= drink;
            }
        }
        // 음료수 1개 2,000원
        for(int j = 1; j < k + 1; j++)
        {
            answer += drink;    
        }
        
                
        return answer;
    }
}