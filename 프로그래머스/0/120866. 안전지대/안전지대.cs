using System;

public class Solution {
    public int solution(int[,] board) {
        int answer = 0;
        int boardSize = board.GetLength(0);
        
        for(int i = 0; i < boardSize; i++)
        {
            for(int j = 0; j < boardSize; j++)
            {
                if(board[i, j] == 1)
                {
                    for(int row = i - 1; row <= i + 1; row++)
                    {
                        for(int col = j - 1; col <= j + 1; col++)
                        {
                            if(row >= 0 && row < boardSize && col >= 0 && col < boardSize)
                            {
                                if(board[row, col] == 0)
                                {
                                    board[row, col] = 2;
                                }
                            }
                        }
                    }
                }
            }
        }
        
        for(int i = 0; i < boardSize; i++)
        {
            for(int j = 0; j < boardSize; j++)
            {
                if(board[i, j] == 0)
                {
                    answer++;
                }
            }
        }
        
        return answer;
    }
}