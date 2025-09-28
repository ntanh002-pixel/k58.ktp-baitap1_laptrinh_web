using System;
using System.Drawing;
using System.Threading;
using DolphinLib;

class Program
{
    static void Main(string[] args)
    {
        Dolphin d = new Dolphin(100, 100);
        PointF[] targets = new PointF[] {
            new PointF(300,200),
            new PointF(50,400),
            new PointF(500,50),
            new PointF(400,300)
        };
        int idx = 0;
        while (true)
        {
            PointF t = targets[idx];
            d.Update(t);
            Console.Clear();
            Console.WriteLine("Target: {0},{1}", t.X, t.Y);
            Console.WriteLine("Dolphin: X={0:0.0}, Y={1:0.0}", d.X, d.Y);
            if (Math.Abs(d.X - t.X) < 2 && Math.Abs(d.Y - t.Y) < 2)
                idx = (idx + 1) % targets.Length;
            Thread.Sleep(50);
        }
    }
}
