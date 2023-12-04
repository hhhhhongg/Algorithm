
public class Solution {
    public int[] solution(long n)
        {
            string arr = n.ToString();
            int[] answer = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                answer[i] = (int)char.GetNumericValue(arr[arr.Length-1 - i]);
            }
            return answer;
        }
}