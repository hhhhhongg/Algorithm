using System;
using System.Linq;
using System.Collections.Generic;
public class Solution 
{
    public int[] solution(int[] arr) 
    {
        int temp = arr[0];
        if(arr.Length == 1)
        {
            arr[0] = -1;
            return arr;
        }
        
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] < temp)
            {
                temp = arr[i];
            }
        }
        List<int> list = arr.ToList();
        list.Remove(temp);
        int[] answer = new int[] {};        
        answer = list.ToArray();
        return answer;
    }
}