using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";
        foreach(char character in my_string)
        {
            for(int i = 0; i < n; i++)
            {
                answer += character.ToString();
            }
        }
        return answer;
    }
}