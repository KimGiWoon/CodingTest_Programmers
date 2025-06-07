using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        var selectResult = my_string.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c));
        answer = new String(selectResult.ToArray());

        return answer;
    }
}