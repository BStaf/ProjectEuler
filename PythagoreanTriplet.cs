using System;      
using System.Collections.Generic;  
        
public class PythagoreanTriplet{

    public static long Solve (int sumNum){
        for (int i = 1; i<= sumNum; i++){
            for (int j = 1; j<= sumNum; j++){
                if (isPTEqualToSum(i, j, sumNum- (i+j), sumNum))
                    return (long)(i*j*(sumNum-(i+j)));
            }
        }
        return 0;
    }
    public static long SolveFast (int sumNum){
        for (int i = 3; i<= sumNum; i= i+2){
            int j = (int)((Math.Pow(i,2)-1)/2);
                if (isPTEqualToSum(i, j, sumNum- (i+j), sumNum))
                    return (long)(i*j*(sumNum-(i+j)));
        }
        return 0;
    }
    private static bool isPTEqualToSum(int a, int b, int c, int sumNum){
        if ((a+b+c) != sumNum)
            return false;
        
        if (Math.Pow(a,2)+Math.Pow(b,2) == Math.Pow(c,2))
            return true;
        return false;
    }
    /*private static bool isPTEqualToSumFast(int a, int b, int c, int sumNum){
        if ((a+b+c) != sumNum)
            return false;
        
        if (Math.Pow(a,2)+Math.Pow(b,2) == Math.Pow(c,2))
            return true;
        return false;
    }*/
}