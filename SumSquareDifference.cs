using System;        
        
public class SumSquareDifferences{

    public static double solve(double num){
        double ans = Math.Pow(addDownFromFast(num),2);
        double ans2 = addSquareDownFrom(num);
        Console.WriteLine(ans.ToString() + " and " + ans2.ToString());
        return  ans-ans2;
    }
    static double addDownFrom(double x){
        if (x==0)return 0;
        return x + (addDownFrom(x-1));
    }
    //solution to n + (n-1) + (n-2) to 0 = (n+1) * (n/2)
    static double addDownFromFast(double x){
        return (x+1) * (x/2);
    }
    static double addSquareDownFrom(double x){
        if (x==0)return 0;
        return Math.Pow(x,2) + (addSquareDownFrom(x-1));
    }
}