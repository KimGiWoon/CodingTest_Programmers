using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int[] answer = new int[numbers.Length];
        
        switch(direction)
        {
            case "right":
                for(int i = 0; i < numbers.Length; i++)
                {
                    if((i + 1) == numbers.Length)
                    {
                        answer[0] = numbers[i];
                    }
                    else
                    {
                        answer[i + 1] = numbers[i];
                    }
                    
                }
                break;                
                
            case "left":
                for(int i = 0; i < numbers.Length; i++)
                {
                    if(i != numbers.Length - 1)
                    {
                        answer[i] = numbers[i + 1];
                    }
                    else
                    {
                       answer[i] = numbers[0];   
                    }
                                                                          
                }
                break; 
        }
        
        return answer;
    }
}