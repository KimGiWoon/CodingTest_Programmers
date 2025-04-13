#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int* solution(int money) {
    // return 값은 malloc 등 동적 할당을 사용해주세요. 할당 길이는 상황에 맞게 변경해주세요.
    int* answer = (int*)malloc(1);
    answer[0] = money / 5500;   // 구매할 수 있는 아메리카노 개수
    answer[1] = money % 5500;   // 남은 잔돈
    
    return answer;
}