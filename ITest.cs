using System;      
//using System.Collections.Generic; 

namespace test1
{
    public interface IShape{
        void Draw();
    }

    public class Circle : IShape{
        public void Draw(){
            Console.WriteLine("Circle Draw");
        }
    }

    public class Rectangle : IShape{
        public virtual void Draw(){
            Console.WriteLine("Rect Draw");
        }
    }

    public class Square : Rectangle{
        private int test {get;set;}
        public override void Draw(){
            Console.WriteLine("Square Draw");
        }
    }
}