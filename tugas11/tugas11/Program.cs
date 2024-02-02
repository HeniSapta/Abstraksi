using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Makanan
{
    public abstract void Sound();
}

interface IFlyable
{
    void Fly();
}

public class Cake : Makanan, IFlyable
{
    public override void Sound()
    {
        Console.WriteLine("Cake strawberry");
    }

    public void Fly()
    {
        Console.WriteLine("Cake strawberry lezat sekali");
    }


public class Gorengan : Cake
    {
        public override void Sound()
        {
            Console.WriteLine("Gorengan the best");
        }
    }

public class Program
    {
        public static void Main(string[] args)
        {
            Makanan makanan = new Gorengan();
            makanan.Sound();
            IFlyable flayer = new Cake();
            flayer.Fly();
        }
    }
}
