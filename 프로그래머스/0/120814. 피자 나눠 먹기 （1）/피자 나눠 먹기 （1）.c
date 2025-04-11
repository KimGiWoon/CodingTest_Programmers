#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int n) {
    int answer;
    if(n % 7 == 0) // 인원에서 피자를 나눴을 때 딱 맞아 떨어지면  
    {        
        answer = n / 7; // 필요한 피자 개수 반환
    }
    else  // 인원에 비해 피자의 개수가 부족하면
    {
        answer = (n / 7) + 1;  // 피자 하나 추가
    }
  
    return answer;
}