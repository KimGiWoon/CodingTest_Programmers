#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int n) {
    int answer = 1;
    while(true)
    {
        if((6 * answer) % n != 0) // 나머지가 0과 같을때 까지 무한 반복
        {
            answer++;   // 피자 추가
        }
        else
        {
            break;  // 나머지가 0과 같으면 빠져나옴
        }
        
    }
    
    return answer;
}