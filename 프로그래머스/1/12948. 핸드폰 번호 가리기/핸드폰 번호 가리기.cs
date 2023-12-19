public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        char[] arr = phone_number.ToCharArray();
        
        for(int i = 0; i < arr.Length; i++)
        {
            if(i < arr.Length-4)
            {
                arr[i] = '*';
            }
        }
        answer = new string(arr);
        return answer;
    }
}