using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = new int[] {};
        List<int> numList = new List<int>();
        
        for(int i = 0; i < my_string.Length; i++)
        {
            if(char.IsDigit(my_string[i]) == true)
            {
                numList.Add((int)my_string[i] - 48);
            }
        }
        answer = numList.ToArray();
        Array.Sort(answer);

        return answer;
    }
}