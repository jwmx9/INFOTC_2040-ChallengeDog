using System;

public enum Gender
{
    Male,
    Female
}

namespace Dog
{
    public class Dog
    {
        private string name; 
        private string owner; 
        private int age; 
        private Gender gender; 

        //declaring Copy constructor
        public Dog(Dog s)
        {
            name = s.name;
            owner = s.owner;
            age = s.age;
            gender = s.gender;
        }

        //Instance constructor
        public Dog(string name, string owner, int age, Gender gender)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;
        }

        //Creates a method
        public void Bark(int woofTimes)
        {
            int i = 0;
            for(i = 0; i < woofTimes; i++)
            {
                Console.Write("Woof!");
            }
        }

        public void GetTag()
        {
            Console.WriteLine("");

            string HeOrShe;
            string HimOrHer;
            if (gender == Gender.Male)
            {
                HeOrShe = "he";
                HimOrHer = "His";
            }
            else
            {
                HeOrShe = "she";
                HimOrHer = "Her";
            }

            string YearOrYears;
            if (age > 1)
            {
                YearOrYears = "years";
            }
            else
            {
                YearOrYears = "year";
            }
            Console.WriteLine("If lost, call {0}. {1} name is {2} and {3} is {4} {5} old.", owner, HimOrHer, name, HeOrShe, age, YearOrYears);
        }

    }

    class MainClass
    {

        public static void Main(string[] args)
        {
            Dog puppy1 = new Dog("Orion", "Shawn", 1, Gender.Male);
            puppy1.Bark(3);
            puppy1.GetTag();

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);
            myDog.Bark(1);
            myDog.GetTag();
        }

    }
}
