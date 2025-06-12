using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[] {};        
        List<int> measure = new List<int>();
        int index = 0;
        
        for(int i = 1; i <= n; i++)
        {
            if(n % i == 0)
            {
                measure.Add(i);
            }
        }
        answer = measure.ToArray();
        
        return answer;
    }
}