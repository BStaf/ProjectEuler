using System;      
using System.Collections.Generic;  
        
public class SumOfPrimes{

    public static long Solve (long max){
        //long x=3;
       // int cntr = 1;
        if (max < 2)return 0;

        long pl = getSumOfPrimesToMax(max);
        return pl;//[pl.Count-1];

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
    private static long getSumOfPrimesToMax(long max){
        List<long> pList = new List<long>();
        long prime = 2;
        long sum = 2;
        //if (cnt == 0) return pList;
        pList.Add(prime);
        prime++;
        while (prime < max){        
            if (isPrime(pList,prime)){
                pList.Add(prime);
                sum += prime;
            }
            prime = prime+2;
        }
        return sum;
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