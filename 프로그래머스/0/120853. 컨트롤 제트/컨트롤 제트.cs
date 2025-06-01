using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int sumNumber = 0;
        string[] array = s.Split(" ");
        
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] == "Z")
            {
                sumNumber -= int.Parse(array[i - 1]);
            }
            else
            {
                sumNumber += int.Parse(array[i]);
            }
        }
        
        answer = sumNumber;
        return answer;
    }
}