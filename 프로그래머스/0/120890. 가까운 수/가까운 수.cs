using System;
using System.Linq;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        int maxNum = 100;
        
        Array.Sort(array);
        
        for(int i = 0; i < array.Length; i++)
        {
            // n의 숫자와의 거리를 확인하여 가장 가까운 수 확인
            if(Math.Abs(array[i] - n) < maxNum)
            {
                maxNum = Math.Abs(array[i] - n);
                answer = array[i];
            }
        }
        
        return answer;
    }
}