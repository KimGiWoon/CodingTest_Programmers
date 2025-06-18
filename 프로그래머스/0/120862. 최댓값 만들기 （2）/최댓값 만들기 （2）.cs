using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int maxNumber = int.MinValue;
        
        for(int i = 0; i < numbers.Length; i++)
        {
            for(int j = i + 1; j < numbers.Length; j++)
            {
                answer = numbers[i] * numbers[j];
                
                if(answer > maxNumber)
                {
                    maxNumber = answer;
                }
            }
        }
              
        return maxNumber;
    }
}