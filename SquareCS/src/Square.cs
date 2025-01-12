using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//create a class and remove the namespace declaration since we plan to use this as a object and not a util file
class Square
{
    //prevent non class methods from accessing this varible for instance SquareObj.size = 5 will not work when privated
    private int size;

   
    public Square(int data)
    {
        SetSize(data);
    }

    public Square()
    {
        SetSize(0);
    }

    
    public int GetSize()
    {
        return size;
    }

    public void SetSize(int setter)
    {
        size = setter;
    }

    public static void Print(int data)
    {
        Console.WriteLine(data);
    }

    //a simple staircase drawing method props to Lua in computercraft for showing me the idea
    public static void DrawStairs(int data)
    {
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < i; j++)
            {
                Console.Write(data);
            }
            Console.WriteLine();
        }

    }
}
