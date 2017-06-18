using System;     
using System.Text; 
        
public class MGlass{

    /// <summary>
    /// Creates a Martini glass using the entered Width.
    /// </summary>
    /// <param name="width">Width of the Glass</param>
    public static void PrintGlass(int width){
        //the width must be greater than 0
        if (width < 1)
            throw new ArgumentOutOfRangeException();
        //the width needs to be an odd number, if an even is entered, subtract
        if (width % 2 == 0)
            width--;
        Console.WriteLine(makeGlass(width));
    }

    //I could use strings to create the martini glass, but when the width gets larger,
    //StringBuilders will perform better. 
    private static string makeGlass(int width){
        int curWidth = width;
        StringBuilder glassTop = new StringBuilder();
        StringBuilder glassStem = new StringBuilder();
        //The glass base is as wide as the entered width, so we create that now
        StringBuilder glassBase = new StringBuilder().Append('=',width);
        //loop through creating each line of the the top of the martini glass
        //The stem will also be created in this loop because it is as long as
        //the glass top
        while (curWidth > 0){
            glassTop.Append(makeMGlassLine(curWidth,width) + "\n");
            curWidth=curWidth-2;
            glassStem.Append(' ', width/2)
                    .Append("|\n");
        }
        //connect all three peices to create the martini glass
        return glassTop.Append(glassStem).Append(glassBase).ToString();
    }
    //Returns a StringBuilder one line of the top of the martini glass
    private static StringBuilder makeMGlassLine(int currentSize, int fullSize){
        int filler = (fullSize - currentSize)/2;//calculate blank spaces on either side
        if (filler < 0) return new StringBuilder();
        return new StringBuilder()
                .Append(' ', filler)
                .Append('O',currentSize)
                .Append(' ', filler);//.ToString();
    }
}