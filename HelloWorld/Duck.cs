using System;
using System.Collections.Generic;
using System.Drawing;

namespace HelloWorld
{
    
    public class Duck : IQuackable
    {
        public Color Color { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public IEnumerable<Duck> Family { get; set; } = new Duck[]{};

        public string Quack()
        {
            return $"{Name} says Quack!";
        }

        public static IEnumerable<Duck> GetDucks()
        {
            return new[]
            {
                new Duck {Name = "Zenikanard", Color = Color.Red, BirthDate = new DateTime(2018, 3, 28)},
                new Duck
                {
                    Name = "Donald Duck", Color = Color.White, BirthDate = new DateTime(1937, 6, 9), Family = new[]
                    {
                        new Duck
                        {
                            Name = "Huey Duck", Color = Color.White, BirthDate = new DateTime(1937, 10, 17)
                        },
                        new Duck
                        {
                            Name = "Dewey Duck", Color = Color.White, BirthDate = new DateTime(1937, 10, 17)
                        },
                        new Duck
                        {
                            Name = "Louie Duck", Color = Color.White, BirthDate = new DateTime(1937, 10, 17)
                        }
                    }
                },
                new Duck
                {
                    Name = "Daffy Duck", Color = Color.Black,
                    BirthDate = new DateTime(1937, 4, 17)
                }
            };
        }
    }


    public interface IQuackable
    { 
        string Quack();
    }
}