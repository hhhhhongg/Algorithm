public class Solution {
    public long[] solution(int x, int n) 
    {
        long[] answer = new long[] { };
        long[] arr = new long[n];
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == 0)
            {
                arr[i] = x;
            }
            else
            {
                arr[i] = arr[i - 1] + x;
            }
        }
        answer = arr;
        return answer;
    }
}