using System;
using System.Linq;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        answer = n.ToString().Sum(x => int.Parse(x.ToString()));
           
        return answer;
    }
}