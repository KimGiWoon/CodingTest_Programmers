using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int measure = 0;
        
        // 합성수 == 소수가 아닌 수
        // 전체의 수와 나누어 소수가 아닌 수의 약수 확인
        for(int i = 1; i <= n; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                if(i % j == 0)
                {
                    measure++;
                }                                
            }
            if(measure >= 3)    // 합성수의 약수는 3개 이상
            {
                answer++;                
            }
            measure = 0;    // 약수 초기화
        }
    
        return answer;
    }
}