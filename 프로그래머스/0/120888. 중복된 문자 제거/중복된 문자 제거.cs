using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        // 중복 제거 후 문자열 연결
        answer = string.Concat(my_string.Distinct());
        return answer;
    }
}