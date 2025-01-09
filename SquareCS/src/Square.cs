using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace SquareCS.src
//{
class Square
{

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
//}
