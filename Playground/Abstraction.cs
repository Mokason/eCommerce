using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class Test {
        public Test() {

            var dog = new Dog();
            var cat = new Cat();
      
            dog.Eyes = 2;
            dog.Legs = 4;
            dog.isMansBestFriend();
            
        }
    }
    public abstract class Animal{
        public int Legs { get; set; }
        public int Eyes { get; set; }
        public bool Loyal { get; set; }

        public bool isMansBestFriend() 
        {
             return Loyal;
        }
    }

    public class Dog : Animal
    {
        public bool IsDog(){
            return true;
        }

    }
    public class Cat : Animal
    {
        
    }
}
