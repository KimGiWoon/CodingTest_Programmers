using System;

public class Solution {
    public string solution(int age) {
        string answer = "";
        
        // 나이가 0이 될 때까지 반복
        while(age != 0)
        {
            // age의 1의자리 확인 후 알파벳 반환 (아스키 코드 a = 97)
            answer = (char)((age % 10) + 97) + answer;
            // 다음 주어진 수의 자리의 숫자 확인
            age = age / 10;
        }
        
        return answer;
    }
}