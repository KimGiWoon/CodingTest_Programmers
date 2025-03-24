using System;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        int[] index = new int[1000];
        
        if(array.Length == 0)
        {
            index[array[0]] += 1;    
        }
        
        for(int i = 0; i < array.Length; i++)
        {
            index[array[i]] += 1;
        }
        
        int number1 = Array.IndexOf(index, index.Max());
        int number2 = Array.LastIndexOf(index, index.Max());
        
        if(number1 == number2)
        {
            answer = number1;
        }
        else
        {
            answer = -1;
        }
        return answer;
    }
}