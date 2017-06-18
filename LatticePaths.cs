using System;      
using System.Collections.Generic;  
        
public class LatticePaths{
    public class node{
        public int right {get;set;}
        public int down {get;set;}
    }
    private static long count;
    public static long Solve (int x, int y){
        Dictionary<int,node> matrix;
        count = 0;
        matrix = makeNewMatrix(x+1, y+1);
        getPathCountFast(matrix);//,0);
        //getPathCount(matrix,0);
        return count;

    }
    //build matrix nodes
    private static Dictionary<int,node> makeNewMatrix(int x, int y){
        var retDict = new Dictionary<int,node>();

        for (int i = 0; i< (x*y); i++){
            node n = new node();
            //n.id = i;
            int xPos = i-(int)Math.Floor((double)(i/x)) * x;
            int yPos = (int)Math.Floor((double)(i/y));
            //find right node
            if (xPos < (x-1))
                n.right = i+1;
            else
                n.right = -1;
            //find down node
            
            if (yPos  < (y-1))
                n.down = i+y;
            else
                n.down = -1;
            retDict.Add(i,n);
        }
        return retDict;
    }
    private static void getPathCount(Dictionary<int,node> matrix, int key){
        node n = matrix[key];
        if ((n.right == -1)&&(n.down == -1)){
            count++;
            return;
        }
        if (n.right > -1)
            getPathCount(matrix, n.right);
        if (n.down > -1)
            getPathCount(matrix, n.down);
    }
    private static void getPathCountFast(Dictionary<int,node> matrix){
        //this is always a rectangle of some sorts. The path count from one corner 
        //to the other is the same the other way around
        //this logic starts at the end of the path (reall the beginning but as I said
        //it doesn't matter. I will go one node at a time, logging the path count.)
        Dictionary<int,long> pathCountDict = new Dictionary<int,long>();
        //int cnt = 0;
        for (int i=matrix.Count-1; i>=0; i--){
            count = 0;
            getPathCountForNode(matrix,i, pathCountDict);
            pathCountDict.Add(i,count);
        }    
    }
    private static void getPathCountForNode(Dictionary<int,node> matrix, int key, Dictionary<int,long> pathCountDict){
        if (pathCountDict.ContainsKey(key)){
            count += pathCountDict[key];
            return;
        }
        node n = matrix[key];

        if ((n.right == -1)&&(n.down == -1)){
            count++;

            return;
        }
        if (n.right > -1)
            getPathCountForNode(matrix, n.right,pathCountDict);
        if (n.down > -1)
            getPathCountForNode(matrix, n.down,pathCountDict);
    }
}