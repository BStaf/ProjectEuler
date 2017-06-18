using System;      
using System.Collections.Generic;  
        
public class LargestPrimeFactor{
    public static long solveFast(long num){
        //n=”the evil big number”
        long factor = 2;
        long lastFactor=1;
        while (num>1){
            if (num % factor==0){
                lastFactor = factor;
                Console.WriteLine((num / factor)+" = "+num+" / "+factor);
                num=num / factor;
                while (num % factor==0){
                    Console.WriteLine("-");//+(num / factor)+" = "+num+" / "+factor);
                    num=num / factor;
                } 
            }
            factor=factor+1;
        }
        return lastFactor;
    }
    public static long solve(long num){
        long sPoint = num/2;
        if (isPrime(sPoint))
            return sPoint;
        if (sPoint % 2 == 0)
            sPoint = sPoint - 1;
        for (long i=sPoint; i>2;i=i-2){
            if (num % i == 0)
                if (isPrime(i))
                    return i;
        }
        return 0;
    }
    private static bool isPrime(long num){
        if (num % 2 == 0) return false; // even
        if (num % 3 == 0) return false; // even
        if (num % 5 == 0) return false; // even
        for (long i = 7; i<(num/5); i=i+2)
            if ((i%5 != 0)&&(i%3 != 0))
                if ((num % i) == 0)
                    return false;
        return true;
    }
}