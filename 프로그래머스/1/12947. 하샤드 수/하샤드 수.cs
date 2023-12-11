using System;
public class Solution {
    public bool solution(int x) {
        bool answer = true;
        int sum = 0;
        string arr = x.ToString();
        for(int i = 0; i < arr.Length; i++)
        {
            sum += Int32.Parse(arr[i].ToString());
        }
        if (x % sum == 0)
        {
            answer = true;
        }
        else
        {
            answer = false;        
        }
        
        
        return answer;
    }
}