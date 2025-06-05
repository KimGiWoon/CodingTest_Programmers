using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        Array.Sort(sides);
        // 가장 긴 변의 길이가 다른 두 변의 길이의 합보다 작으면 1 반환, 크거나 같으면 2 반환             
        return answer = (sides[2] < sides[0] + sides[1]) ? 1 : 2;
    }
}