using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_str, int n) {
        string[] answer = new string[] {};
        List<string> cutNumber = new List<string>();
        
        for(int i = 0; i < my_str.Length; i += n)
        {
            int cutLength = Math.Min(n, my_str.Length - i);
            cutNumber.Add(my_str.Substring(i, cutLength));
        }
        
        answer = cutNumber.ToArray();
        
        return answer;
    }
}