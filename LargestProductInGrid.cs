using System;      
using System.Collections.Generic;  
        
public class LargestProductInGrid{
    
    public static long Solve (int [,] grid, int lenToCalc){
        int yLen = grid.GetLength(0);
        int xLen = grid.GetLength(1);
        long largestNum = 0;
        long curResult =0;
        for (int i =0;i<yLen;i++){
            for (int j=0;j<xLen;j++){
                //Console.WriteLine(i+ " - " +j);
                if ((curResult = getSumDown(grid,j,i,xLen,yLen,lenToCalc)) > largestNum)
                    largestNum = curResult;
                if ((curResult = getSumRight(grid,j,i,xLen,yLen,lenToCalc)) > largestNum)
                    largestNum = curResult;
                if ((curResult = getSumDiagLeft(grid,j,i,xLen,yLen,lenToCalc)) > largestNum)
                    largestNum = curResult;
                if ((curResult = getSumDiagRight(grid,j,i,xLen,yLen,lenToCalc)) > largestNum)
                    largestNum = curResult;
                
            }
        }
        return largestNum;

    }
    private static long getSumDown(int [,] grid, int startX, int startY, int xLen, int yLen, int lenToCalc){
        if (lenToCalc > (yLen - startY))
            return 0;
        long result = 1;
        for (int i = 0; i<lenToCalc;i++)
            result *= grid[startY+i,startX];
        return result;
    }
    private static long getSumRight(int [,] grid, int startX, int startY, int xLen, int yLen, int lenToCalc){
        if (lenToCalc > (xLen - startX))
            return 0;
        long result = 1;
        for (int i = 0; i<lenToCalc;i++)
            result *= grid[startY,startX+i];
        return result;
    }
    private static long getSumDiagRight(int [,] grid, int startX, int startY, int xLen, int yLen, int lenToCalc){
        if ((lenToCalc > (xLen - startX))||(lenToCalc > (yLen - startY)))
            return 0;
        long result = 1;
        for (int i = 0; i<lenToCalc;i++)
            result *= grid[startY+i,startX+i];
        return result;
    }
    private static long getSumDiagLeft(int [,] grid, int startX, int startY, int xLen, int yLen, int lenToCalc){
        if ((lenToCalc > (startX))||(lenToCalc > (yLen - startY)))
            return 0;
        long result = 1;
        for (int i = 0; i<lenToCalc;i++)
            result *= grid[startY+i,startX-i];
        return result;
    }
}