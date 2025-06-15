using System;

public class Solution {
    public int solution(int num, int k) {
        int answer = 0;
        int index = num.ToString().IndexOf(k.ToString());
        
        answer = index == -1 ? -1 : index +1;
                
        return answer;
    }
}