using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int[] answer = new int[2];
        int denom = denom1*denom2;
        int numer = denom1*numer2+denom2*numer1;
        
        int num = numer;
        int den = denom;
        int temp = 0;
        while(den != 0)
        {
            temp = num % den;
            num = den;
            den = temp;
        }
        answer[0] = numer / num;
        answer[1] = denom / num;
        return answer;
    }
}