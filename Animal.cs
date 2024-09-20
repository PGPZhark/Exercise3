using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }

        public abstract void DoSound();

        public virtual string Stats()
        {
            return $"Name: {Name} \nAge: {Age} \nWeight: {Weight}";
        }

        public Animal(string name, int age, float weight)
        {
            Name = name;
            Age = age;
            Weight = weight; 
        }


    }


    internal class Horse : Animal
    {
        // If you don't know what angle I'm talking about google "horses funny angle"
        // and since they are always funny from that angle this will be a readonly that returns true, always.
        public bool IsFunnyFromThatAngle 
        { 
            get
            {
                return true;
            }
        }


        public Horse(string name, int age, float weight):base(name, age, weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public override void DoSound()
        {
            Console.WriteLine("Neigh neigh");
        }
        public override string Stats()
        {
            return $"Name: {Name} \nAge: {Age} \nWeight: {Weight} \nFunny From Angle: {IsFunnyFromThatAngle} ";
        }

    }

    internal class Dog : Animal
    {
        public bool IsGoodBoy { get; set; }

        public Dog(string name, int age, float weight, bool isGoodBoy) : base(name, age, weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
            IsGoodBoy = isGoodBoy;
        }

        public override void DoSound()
        {
            Console.WriteLine("Woof woof");
        }
        public override string Stats()
        {
            return $"Name: {Name} \nAge: {Age} \nWeight: {Weight} \nIs A Good Boy: {IsGoodBoy} ";
        }

        public string Bark()
        {
            return "Bark bark";
        }

    }

    internal class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }

        public Hedgehog(string name, int age, float weight, int nrOfSpikes) : base(name, age, weight)
        {
            Name = name;
            Age = age;
            Weight = weight; 
            NrOfSpikes = nrOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("Gotta go fast");
        }

        public override string Stats()
        {
            return $"Name: {Name} \nAge: {Age} \nWeight: {Weight} \nNumber Of Spikes: {NrOfSpikes} ";
        }
    }

    internal class Worm : Animal
    {
        public bool IsPoisonous { get; set; }


        public Worm(string name, int age, float weight, bool isPoisonous) : base(name, age, weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
            IsPoisonous = isPoisonous;
        }

        public override void DoSound()
        {
            Console.WriteLine("I am... The Worminator!");
        }
        public override string Stats()
        {
            return $"Name: {Name} \nAge: {Age} \nWeight: {Weight} \nIs Poisonous: {IsPoisonous} ";
        }
    }

    internal class Bird : Animal
    {
        public float WingSpan { get; set; }

        public Bird(string name, int age, float weight, float wingSpan) : base(name, age, weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
            WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine("Chirp chirp");
        }
        public override string Stats()
        {
            return $"Name: {Name} \nAge: {Age} \nWeight: {Weight} \nWing Span: {WingSpan} ";
        }
    }

    internal class Wolf : Animal
    {
        public bool IsGoodBoy { get; set; }

        public Wolf(string name, int age, float weight, bool isGoodBoy) : base(name, age, weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
            IsGoodBoy = isGoodBoy;
        }


        public override void DoSound()
        {
            Console.WriteLine("Awoooo");
        }
        public override string Stats()
        {
            return $"Name: {Name} \nAge: {Age} \nWeight: {Weight} \nIs A Good Boy: {IsGoodBoy} ";
        }
    }

    internal class Pelican : Bird
    {
        public float Buoyancy { get; set; }
        public Pelican(string name, int age, float weight, float wingSpan, float buoyancy) : base(name, age, weight, wingSpan)
        {
            Name = name;
            Age = age;
            Weight = weight;
            WingSpan = wingSpan;
            Buoyancy = buoyancy;
        }

        public override void DoSound()
        {
            Console.WriteLine("Squawk");
        }
        public override string Stats()
        {
            return $"Name: {Name} \nAge: {Age} \nWeight: {Weight} \nWing Span: {WingSpan} \nBuoyancy: {Buoyancy}";
        }
    }

    internal class Flamingo : Bird
    {
        public float Pinkness { get; set; }
        public Flamingo(string name, int age, float weight, float wingSpan, float pinkness) : base(name, age, weight, wingSpan)
        {
            Name = name;
            Age = age;
            Weight = weight;
            WingSpan = wingSpan;
            Pinkness = pinkness;
        }

        public override void DoSound()
        {
            Console.WriteLine("Honk");
        }
        public override string Stats()
        {
            return $"Name: {Name} \nAge: {Age} \nWeight: {Weight} \nWing Span: {WingSpan} \nPinkness: {Pinkness}";
        }
    }

    internal class Swan : Bird
    {
        public bool WhiteSwan { get; set; }
        public Swan(string name, int age, float weight, float wingSpan, bool whiteSwan) : base(name, age, weight, wingSpan)
        {
            Name = name;
            Age = age;
            Weight = weight;
            WingSpan = wingSpan;
            WhiteSwan = whiteSwan;
        }

        public override void DoSound()
        {
            Console.WriteLine("Quack");
        }
        public override string Stats()
        {
            return $"Name: {Name} \nAge: {Age} \nWeight: {Weight} \nWing Span: {WingSpan} \nIs A White Swan: {WhiteSwan}";
        }
    }

    internal class Wolfman : Wolf, IPerson
    {

        public Wolfman(string name, int age, float weight, bool isGoodBoy) : base(name, age, weight, isGoodBoy)
        {
            Name = name;
            Age = age;
            Weight = weight;
            IsGoodBoy = isGoodBoy;
        }
        public override string Stats()
        {
            return $"Name: {Name} \nAge: {Age} \nWeight: {Weight} \nIs A Good Boy: {IsGoodBoy} ";
        }

        public override void DoSound()
        {
            Console.WriteLine("Awoooo");
        }

        public void Talk(string message)
        {
            Console.WriteLine(message);
        }
    }

}
