using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] quiz) {
        string[] answer = new string[] {};
        List<string> result = new List<string>();

        foreach (string n in quiz)
        {
            string[] parts = n.Split(" ");
            int leftNum = int.Parse(parts[0]);
            int rightNum = int.Parse(parts[2]);
            int sumNum = int.Parse(parts[4]);
    
            if (parts[1] == "+")
            {
                result.Add(leftNum + rightNum == sumNum ? "O" : "X");
            }
            else if (parts[1] == "-")
            {
                result.Add(leftNum - rightNum == sumNum ? "O" : "X");
            }
            else
            {
                result.Add("X");
            }
        } 
        answer = result.ToArray();
        
        return answer;
    }
}