using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        int sum = 0;
        int count = 0;
        for(int i = left; i < right + 1; i++)
        {
            for(int j = 1; j < i + 1; j++)
            {
                if(i % j == 0)
                {
                    count++;
                }
            }
            
            if(count % 2 == 0)
            {
                sum += i;
            }
            else
            {
                sum -= i;    
            }
            count = 0;
        }
        answer = sum;
        return answer;
    }
}