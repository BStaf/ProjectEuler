using System;      
using System.Collections.Generic;  
        
public class LongestCollatz{
    private static Dictionary<long,int> currentSequenceCountsDict;
    public static int Solve (int num){
        int max = 0;
        int maxNum = 0;
        if (currentSequenceCountsDict == null)
            currentSequenceCountsDict = new Dictionary<long,int>();
        for (int i=1;i<=num;i++){
            int seqCnt = doCollatz(i);
            if (seqCnt > max){
                maxNum = i;
                max = seqCnt;
            }
        }
        return maxNum;

    }
    private static int doCollatz(int startNum){
        int cnt=1;
        long num = startNum;
        while (num > 1){
            if (num % 2 == 0)
                num = num/2;
            else
                num = 3*num+1;
            
            if (currentSequenceCountsDict.ContainsKey(num)){
                cnt += currentSequenceCountsDict[num];
                break;
            }
            cnt++;
        }
        currentSequenceCountsDict.Add(startNum, cnt);
        //Console.WriteLine(startNum + " - " + cnt);
        return cnt;//cnt;
    }
   

}