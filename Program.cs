using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // List 변수명은 복수로
            List<Dog> Dogs = new List<Dog>() {new Dog(), new Dog(), new Dog()};
            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

            // var는 타입 추론
            foreach(var item in Dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }

            foreach (var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }

        }
    }
}
