using System;      
using System.Collections.Generic;  
        
public class HighlyDivisibleTriangularNumber{

    public static long Solve (long num){
        long x=1;
        long cnt =1;

        while (true){
            
                long y = getDivisors(x);
                if (y > num)
                    return x ;

            cnt++;
            x += cnt;
        }
        //return 0;
    }
    private static long getDivisors(long x){
        long cnt = 0;
        for (long i = 1;i<=x/2;i++){
            if (x % i == 0)
                cnt++;
        }
        return cnt+1;
    }

}