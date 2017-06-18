using System;      
using System.Collections.Generic;  
        
public class NthPrime{

    public static long Solve (int nth){
        //long x=3;
       // int cntr = 1;
        if (nth == 1)return 2;

        var pl = makePrimeListTo(nth);
        return pl[pl.Count-1];

    }
    private static bool isPrime(long num){
        if (num % 2==0) return false;
        for (long i=3; i<(num/2);i=i+2)
            if (num % i == 0)
                return false;
        return true;
    }
   /* private static bool isPrimeDiv(long num){
        long div = (long)Math.Floor(Math.Sqrt(num));
        long factor = 2;
        while (true){
            if (div % factor==0){

            }
        }
        return true;
    }*/
    private static List<long> makePrimeListTo(int cnt){
        List<long> pList = new List<long>();
        long prime = 2;
        if (cnt == 0) return pList;
        pList.Add(prime);
        prime++;
        while (pList.Count < cnt){        
            if (isPrime(pList,prime))
                pList.Add(prime);
            prime = prime+2;
        }
        return pList;
    }
    private static bool isPrime(List<long>pList, long num){
        long numSqrt = (long)Math.Floor(Math.Sqrt(num));
        for(int i=0;i<pList.Count;i++){
            long n = pList[i];
            if (n > numSqrt) break;
            if (num % n == 0)
                return false;
        }
        return true;
    }

}