using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] strlist) {
        int[] answer = new int[] {};
        List<int> findLength = new List<int>();
        
        foreach(string n in strlist)
        {
            findLength.Add(n.Length);
        }
        answer = findLength.ToArray();
             
        return answer;
    }
}