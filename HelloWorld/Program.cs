using System;
using System.Drawing;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var redDucks = Duck.GetDucks()
                .Where(duck => duck.Color == Color.Red)
                .Select(duck => new {duck, quack = duck.Quack()})
                .Select(@t => new {Quack = @t.duck.Quack(), @t.duck.Name});
            
            foreach (var duck in redDucks)
            {
                Console.WriteLine(duck.Quack);
            }
        }
    }
}