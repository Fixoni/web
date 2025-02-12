using System;

namespace cw1.Models;

public class PersonRepo
{

    public static List<Person>GetPerson(){
        return new List<Person>{
            new Person{Id=1,FirstName="Tomasz",LastName="Problem",Age=56},
            new Person{Id=2,FirstName="Madga",LastName="Problem",Age=58},
            new Person{Id=3,FirstName="Kamil",LastName="Problem",Age=26},
            new Person{Id=4,FirstName="Natasha",LastName="Problem",Age=39},
        };
    }
}
