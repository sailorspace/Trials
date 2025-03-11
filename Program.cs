using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Gee.External.Capstone.X86;
using System.Diagnostics;

namespace Trials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new int[] { 1, 2, 3, 4,5,6,7 };
            var d = c[..3];
            var g = c[4..];
            int[] n = d.Concat(c).ToArray(); // Using LINQ's Concat method
            /*int[] n = new int[d.Length + c.Length];
            Array.Copy(d, 0, n, 0, d.Length);
            Array.Copy(c, 0, n, d.Length, c.Length);*/
            int[] n2 = [..d ,..c];
            int x = 3;
            int y = 7;
            Person person = new Person(x,y);
            var(xx,yy)= person;
            Console.WriteLine(xx);

        }
    }

    public class Person
{
    public int x { get; set; }
    public int y { get; set; }


    public Person(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Deconstruct(out int x, out int y)
    {
        y = this.x;
        x = this.y;
    }
}

}
