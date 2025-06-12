using System;

public class Solution {
    public int solution(string my_string) {
        string[] message = my_string.Split(" ");
        int answer = 0;
        
        for(int i = 0; i < message.Length; i++)
        {
            if(i == 0)
            {
                answer = int.Parse(message[i]);
            }
            
            if(i % 2 != 0)
            {
                if(message[i] == "+")
                {
                    answer += int.Parse(message[i + 1]);
                }
                else
                {
                    answer -= int.Parse(message[i + 1]);
                }
            }
        }
              
        return answer;
    }
}