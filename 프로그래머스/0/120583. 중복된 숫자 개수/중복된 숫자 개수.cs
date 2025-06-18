using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        
        foreach(int number in array)
        {
            if(number == n)
            {
                answer++;
            }
        }
        
        return answer;
    }
}