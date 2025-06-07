using System;

public class Solution {
    public string solution(string cipher, int code) {
        string answer = "";
        int count = 1;
        
        foreach(char message in cipher)
        {
            if(count == code)
            {
                answer += message;
                count = 1;
            }
            else
            {
                count++;
            }
        }
        
        return answer;
    }
}