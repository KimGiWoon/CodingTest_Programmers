using System;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
        // 배열의 크기 설정
        int[] answer = new int[num2 - num1 + 1];
        // (num1)부터 (num2)번째 인덱스까지 정수 배열 반환
        for(int i = num1; i <= num2; i++)
        {
            answer[i - num1] = numbers[i];
        }
        return answer;
    }
}