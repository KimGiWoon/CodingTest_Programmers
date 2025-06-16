using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        foreach(char sumNumber in n.ToString())
        {
            answer += int.Parse(sumNumber.ToString());
        }
        
        return answer;
    }
}