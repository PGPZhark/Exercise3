using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class PersonHandler
    {
        public Person CreatePerson(int age, string fName, string lName, float height, float weight)
        {
            Person pers = new Person(age, fName, lName, height, weight);

            return pers;
        }

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public void SetFName(Person pers, string FName)
        {
            pers.FName = FName;
        }
        public void SetLName(Person pers, string LName)
        {
            pers.LName = LName;
        }
        public void SetHeight(Person pers, float height)
        {
            pers.Height = height;
        }
        public void SetWeight(Person pers, float weight)
        {
            pers.Weight = weight;
        }

    }
}
