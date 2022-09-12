using System.Collections;

namespace RandomDataGenerator;

public class RandomDataGenerator
{
    static public void Main(String[] args)
    {
        ArrayList listOfPersons = new ArrayList();
        Console.WriteLine("How many people: ");
        
        int userInput =Int32.Parse(Console.ReadLine());
        
        listOfPersons = CreatePerson(userInput, listOfPersons);

        //PrintList(listOfPersons);
    }

    private static ArrayList CreatePerson(int userInput, ArrayList arrayList)
    {
        for (int i = 0; i < userInput; i++)
        {
            Random rand = new Random();
            Person person = new Person();
            person.firstName = person.ArrayOfFirstNames[rand.Next(0, person.ArrayOfFirstNames.Length - 1)];
            person.lastName= (LastNames) rand.Next(Enum.GetNames(typeof(LastNames)).Length);
            person.birthDate = RandomAdultDate();
            person.age = DateTime.Today.Year - person.birthDate.Year;
            person.ssNum = new SSN();
            person.phoneNumber = new Phone();
            arrayList.Add(person);
            Console.WriteLine(person.ToString());
        }    
        return arrayList;

    }
    private static DateTime RandomAdultDate()
    {
        Random rand = new Random();
        DateTime currentDate = DateTime.Now;
        int rndYear = rand.Next(1942, 2004);
        int rndMonth = rand.Next(1, 12);
        int rndDay = rand.Next(1, 31);
        DateTime generateDate = new DateTime(rndYear, rndMonth, rndDay);
        return generateDate;
    }
    static void PrintList(ArrayList list)
    {
        foreach (Person person in list)
        {
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
            Console.WriteLine(person.BirthDate);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.SSNUM);
            Console.WriteLine(person.PhoneNumber);
        }
    }

  
}
