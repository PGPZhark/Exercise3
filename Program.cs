using System.Reflection;

namespace Exercise3
{
    internal class Program
    {
        static void Main()
        {
            /* Kunskapsfrågor:
             * 3.3) 
             * 13. Bird-klassen.
             * 14. Animal-klassen.
             * 
             * 3.4)
             * 9. Är inte av samma typ. Kan inte konvertera från Horse till Dog.
             * 10. För att alla klasser som ärver av Animals måste listan ha Animal som typ. 
             * Så liksom klassen och alla subklasser kan vara i samma lista.
             * 13. Den skriver ut stats exakt som den ska göra? Antagligen kanske om man har mer att skriva ut gör den inte det för att det är för mycket eller?
             * Eller missar jag något? :O
             * 17. Nej. Eftersom den finns bara i subklassen Dog och inte i klassen Animal. 
             * En klass som ärver av en annan klass får deras egenskaper och metoder men inte tvärtom. 
            */


            /* 3.1
            Person person = new Person("Simon", "Haglund");
           
            try
            {
                person.Age = 2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"Age: {person.Age}");

            try
            {
                person.Age = -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"Age: {person.Age}");

            try
            {
                person.FName = "Z";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"First Name: {person.FName}");

            try
            {
                person.LName = "AAAAAAAAAAAAAAAAAAAAAAAAA";
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"Last Name: {person.LName}");
            */

            /* 3.1 5
            PersonHandler personHandler = new PersonHandler(); 


            Person person1 = personHandler.CreatePerson(30, "Le", "Dude", 180, 82);
            Person person2 = personHandler.CreatePerson(25, "Another", "Dude", 178, 78);

            Console.WriteLine($"Name: {person1.FName} {person1.LName} Age: {person1.Age}");
            personHandler.SetAge(person1, 20);
            personHandler.SetFName(person1, "Mange");
            personHandler.SetLName(person1, "Makers");
            Console.WriteLine($"Name: {person1.FName} {person1.LName} Age: {person1.Age}");*/


            /* 3.2
            List<UserError> userErrors = new List<UserError>();

            NumericInputError numericInputError1 = new NumericInputError();
            NumericInputError numericInputError2 = new NumericInputError();
            NumericInputError numericInputError3 = new NumericInputError();

            userErrors.Add(numericInputError1);
            userErrors.Add(numericInputError2);
            userErrors.Add(numericInputError3);

            TextInputError textInputError1 = new TextInputError();
            TextInputError textInputError2 = new TextInputError();
            TextInputError textInputError3 = new TextInputError();

            userErrors.Add(textInputError1);
            userErrors.Add(textInputError2);
            userErrors.Add(textInputError3);

            TooLargeInputError largeInputError = new TooLargeInputError();
            TooSmallInputError smallInputError = new TooSmallInputError();
            NonIntegerInputError nonIntegerInputError = new NonIntegerInputError();

            userErrors.Add(largeInputError);
            userErrors.Add(smallInputError);
            userErrors.Add(nonIntegerInputError);

            foreach (UserError userError in userErrors)
            {
                Console.WriteLine(userError.UEMessage());
            }
            */


            List<Animal> animals = new List<Animal>();
            Horse horse1 = new Horse("Sleipner", 13, 550f);
            Horse horse2 = new Horse("Bucephalus", 16, 590f);
            Dog dog1 = new Dog("Cerberus", 2, 2.6f, true);
            Dog dog2 = new Dog("Fluffles", 7, 20f, true);
            Hedgehog hedgehog = new Hedgehog("Sonic", 15, 35f, 8);
            Wolf wolf = new Wolf("Fenrir", 9, 40f, false);
            Bird bird = new Bird("Smol", 3, 0.1f, 5.5f);
            Swan swan = new Swan("Bella", 5, 8.5f, 200f, true);
            Wolfman wolfman = new Wolfman("Jacob", 15, 68, false);

            animals.Add(horse1);
            animals.Add(horse2);
            animals.Add(dog1);
            animals.Add(dog2);
            animals.Add(hedgehog);
            animals.Add(wolf);
            animals.Add(bird);
            animals.Add(swan);
            animals.Add(wolfman);

            List<Dog> dogs = new List<Dog>();

            dogs.Add(dog1);
            dogs.Add(dog2);
            

            foreach (var animal in animals)
            {
                animal.DoSound();

                if (animal is IPerson)
                {
                    IPerson person = (IPerson) animal;
                    person.Talk("Potatismos");
                }
                
                if (animal is Dog)
                {
                    Dog dog = (Dog) animal;
                    Console.WriteLine(dog.Bark());
                }
            }

            /*
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());
            }

            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog.Stats());
            }*/
            



            Console.ReadLine();
        }
    }
}
