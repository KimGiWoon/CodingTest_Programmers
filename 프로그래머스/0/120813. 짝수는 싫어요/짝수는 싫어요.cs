using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[] {};        
        List<int> evenNumber = new List<int>();
        
        for(int i = 0; i <= n; i++)
        {
            
            if( i % 2 == 1)
            {
                evenNumber.Add(i);
            } 
        }
        evenNumber.Sort();
        answer = evenNumber.ToArray();
        return answer;
    }
}