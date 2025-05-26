using System;

public class Solution {
    public string solution(string rsp) {
        string answer = "";
        
        foreach(char choice in rsp)
        {
            switch (choice)
            {
                case '0' :
                    answer += '5';
                    break;
                case '2' :
                    answer += '0';
                    break;
                case '5' :
                    answer += '2';
                    break;
                default :
                    break;
            }
        }
        
        return answer;
    }
}