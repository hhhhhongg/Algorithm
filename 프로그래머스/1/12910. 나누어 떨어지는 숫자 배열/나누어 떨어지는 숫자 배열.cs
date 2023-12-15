using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int divisor) {
        List<int> answer = new List<int>();
        int[] exception = new int[] {-1};
        
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] % divisor == 0)
            {
                answer.Add(arr[i]);
            }
        }
        
        if (answer.Count == 0)
        {
            return exception;
        }
        
        answer.Sort();
        return answer.ToArray();
    }
}