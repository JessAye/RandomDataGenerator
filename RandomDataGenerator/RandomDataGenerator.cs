using System.Collections;

namespace RandomDataGenerator;

public class RandomDataGenerator
{
    static public void Main(String[] args)
    {
        var done = false;
        List<Person> listOfPersons = new List<Person>();
        do
        {
            Menu(listOfPersons);
        } while (!done); // not really a point in breaking the loop
    }


    public static void Menu(List<Person> listOfPersons)
    {
        Console.WriteLine(
            "What would you like to do?\n" +
            "1.Create n Person(s)\n" +
            "2.View all Persons in the List\n" +
            "3.Delete Person From List\n" +
            "4.Get a random Last Name\n" +
            "5.Get a random SSN\n" +
            "6.Get a random Phone Number with your separator\n" +
            "7. Exit");
        try
        {
            var userInput = Int32.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    CreatePersons(listOfPersons);
                    break;
                case 2:


                    if (listOfPersons.Count == 0)
                    {
                        Console.WriteLine("No Person(s) Exist in the list");
                    }
                    else
                    {
                        ViewList(listOfPersons);
                    }

                    break;
                case 3:
                    if (listOfPersons.Count == 0)
                    {
                        Console.WriteLine("No Person(s) Exist in the list");
                    }
                    else
                    {
                        DeletePerson(listOfPersons);
                    }

                    break;
                case 4:
                    Random rand = new Random();
                    Console.WriteLine((LastNames)rand.Next(Enum.GetNames(typeof(LastNames)).Length));
                    break;
                case 5:
                    Console.WriteLine(new SSN());
                    break;
                case 6:
                    Console.WriteLine("Select your separator"); 
                    string userPhoneInput = Console.ReadLine();
                    Phone randomPhone = new Phone();
                    string[] words = randomPhone.ToString().Split('-');
                    Console.WriteLine($"{words[0]}{userPhoneInput}{words[1]}{userPhoneInput}{words[2]}");
                    break;
                case 7:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please Enter an Integer 1-7");
                    break;
            }
        }
        catch (System.FormatException e)
        {
            Console.WriteLine("Please Enter a valid Integer\n");
        }
    }

    private static List<Person> CreatePersons(List<Person> arrayList)
    {
        Console.WriteLine("How many people Would you Like to make?: ");
        var userInput = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < userInput; i++)
        {
            Random amountOfKids = new Random();
            Person person = new Person();
            for (int j = 0; j < amountOfKids.Next(0, 5); j++)
            {
                person.AddDependents();
            }

            arrayList.Add(person);
        }

        Console.WriteLine(userInput + " Person(s) created");
        return arrayList;
    }

    private static void ViewList(List<Person> arrayList)
    {
        foreach (var person in arrayList)
        {
            Console.WriteLine((person).ToString());
        }
    }

    private static void DeletePerson(List<Person> arrayList)
    {
        Console.WriteLine("Who would you like to delete");
        for (int i = 0; i < arrayList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {arrayList[i].FirstName} {arrayList[i].LastName}");
        }

        Console.WriteLine("Delete Number: ");
        var userInput = Int32.Parse(Console.ReadLine());
        arrayList.RemoveAt(userInput - 1);
    }
}
