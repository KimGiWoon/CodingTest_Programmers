using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] array) {
        int[] answer = new int[2];
        int max = array.Max();
        
        answer[0] = max;
        answer[1] = Array.IndexOf(array, max);
        
        return answer;
    }
}