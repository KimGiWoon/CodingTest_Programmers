using System;

public class Solution {
    public string solution(string my_string, string letter) {
        string answer = "";
        string[] removeString = my_string.Split(letter);
        
        for(int i = 0; i < removeString.Length; i++)
        {
            answer += removeString[i];
        }
        
        return answer;
    }
}