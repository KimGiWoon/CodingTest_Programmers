using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[] {};
        List<int> numList = new List<int>();
        
        for(int i = 2; i <= n; i++)
        {
            while(n % i == 0)
            {
                n /= i;
                numList.Add(i);
            }               
        }
        // 리스트의 중복 값 제거 후 배열로 변환하여 answer에 대입
        answer = numList.Distinct().ToArray();
        
        return answer;
    }
}