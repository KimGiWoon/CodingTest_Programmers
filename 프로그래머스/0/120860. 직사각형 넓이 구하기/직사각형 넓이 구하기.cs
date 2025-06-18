using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[,] dots) {
        int answer = 0;
        List<int> x = new List<int>();
        List<int> y = new List<int>();
        
        for(int i = 0; i < 4; i++)
        {
            x.Add(dots[i, 0]);
            y.Add(dots[i, 1]);
        }
        
        answer = (x.Max() - x.Min()) * (y.Max() - y.Min());
        
        return answer;
    }
}