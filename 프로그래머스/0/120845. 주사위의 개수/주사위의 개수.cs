using System;

public class Solution {
    public int solution(int[] box, int n) {
        int answer = 0;
        
        int widthPiece = box[0] / n;    // 상자의 가로 만큼 들어가는 주사위 개수
        int lengthPiece = box[1] / n;   // 상자의 세로 만큼 들어가는 주사위 개수
        int heightPiece = box[2] / n;   // 상자의 높이 만큼 들어가는 주사위 개수
        
        answer = widthPiece * lengthPiece * heightPiece;
        return answer;
    }
}