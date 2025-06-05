using System;

public class Solution {
    public int solution(int order) {
        int answer = 0;
        int number = order;
        
        while (number != 0)
        {
            int clapNumber = number % 10;
            
            switch(clapNumber)
            {
                case 3:
                case 6:
                case 9:    
                answer++;
                break;
                    
                default:
                break;
            }
            
            number /= 10;
        }
        
        return answer;
    }
}