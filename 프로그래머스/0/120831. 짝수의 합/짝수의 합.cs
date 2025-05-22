using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        // 주어진 값을 순회
        for(int i = 1; i < n + 1; i++)
        {
            // 짝수 확인
            if(i % 2 == 0)
            {
                // 짝수의 합
                answer += i;
            }
        }
        return answer;
    }
}