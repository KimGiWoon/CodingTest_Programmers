using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
        int[] answer = new int[2];
        int max_X = board[0] / 2;
        int max_Y = board[1] / 2;
        
        foreach(string key in keyinput)
        {
            switch(key)
            {
                case "up":
                    if(answer[1] >= max_Y) break;
                    answer[1]++;
                    break;
                case "down":
                    if(answer[1] <= -max_Y) break;
                    answer[1]--;                    
                    break;
                case "left":
                    if(answer[0] <= -max_X) break;
                    answer[0]--;
                    break;
                case "right":
                    if(answer[0] >= max_X) break;
                    answer[0]++;
                    break;
                default:
                    break;
            }
        }
        
        return answer;
    }
}