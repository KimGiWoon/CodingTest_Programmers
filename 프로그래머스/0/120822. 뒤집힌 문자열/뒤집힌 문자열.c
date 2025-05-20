#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>

// 파라미터로 주어지는 문자열은 const로 주어집니다. 변경하려면 문자열을 복사해서 사용하세요.
char* solution(const char* my_string) {
    // return 값은 malloc 등 동적 할당을 사용해주세요. 할당 길이는 상황에 맞게 변경해주세요.
    
    int length = strlen(my_string);
    char* answer = (char*)malloc(length);
    
    for(int i = 0; i < length; i++)
    {
        answer[i] = my_string[length - i - 1];  // my_string 끝 문자부터 answer 앞으로 저장하여 문자열 리버스
    }
    answer[length] = NULL;
    
    return answer;
}