using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int answer = 0;
        int ballCount = 0;
        
        // 정수 K만큼 반복
        for(int i = 0; ballCount < k; i += 2)
        {
            // 배열의 길이와 같거나 초과 시 배열의 길이만큼 뺀 후 순환
            if(i >= numbers.Length)
            {
                i -= numbers.Length;
            }
            
            // 공을 마지막으로 던진 사람 저장 후 볼 카운트 추가
            answer = numbers[i];
            ballCount++;
        }
        return answer;
    }
}