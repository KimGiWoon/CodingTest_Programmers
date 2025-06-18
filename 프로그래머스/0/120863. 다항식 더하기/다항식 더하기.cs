using System;

public class Solution {
    public string solution(string polynomial) {
        string answer = "";
        string[] strArray = polynomial.Split(" ");
        string temp = "";
        int x_Count = 0;
        int num = 0;
        
        for(int i = 0; i < strArray.Length; i += 2)
        {
            if(strArray[i].Contains("x"))
            {
                temp = strArray[i].Replace("x","");
                    
                if(temp == "")
                {
                    x_Count++;
                }
                else
                {
                    x_Count += int.Parse(temp);
                }
            }
            else
            {
                num += int.Parse(strArray[i]);
            }
        }
        
        if(num == 0)
        {
            if(x_Count == 1)
            {
                answer = "x";
            }
            else
            {
                answer = x_Count.ToString() + "x";
            }
        }
        else
        {
            if(x_Count == 0)
            {
                answer = num.ToString();
            }
            else if(x_Count == 1)
            {
                answer = "x + " + num.ToString();
            }
            else
            {
                answer = x_Count.ToString() + "x + " + num.ToString();
            }         
        }
        
        return answer;
    }
}