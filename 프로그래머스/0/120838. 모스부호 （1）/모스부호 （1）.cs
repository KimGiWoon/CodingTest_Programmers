using System;

public class Solution {
    public string solution(string letter) {
        string answer = "";
        string[] morse = 
        { 
            ".-", "-...", "-.-.", "-..", ".",
            "..-.", "--.", "....", "..", ".---",
            "-.-", ".-..", "--", "-.", "---",
            ".--.", "--.-", ".-.", "...", "-",
            "..-", "...-", ".--", "-..-", "-.--", "--.."
        };
        
        // morse의 공백을 기준으로 나워서 mosNum에 대입
        foreach(string mos in letter.Split(" "))
        {
            // morse배열 중 mos이 있으면 문자열의 Index 반환하고
            int mosNum = Array.IndexOf(morse, mos);
            // 문자열의 Index에 아스키코드 소문자 알파벳 a의 값을 더하고 문자로 변환
            answer += Convert.ToChar(mosNum + 97);
        }
        
        return answer;
    }
}