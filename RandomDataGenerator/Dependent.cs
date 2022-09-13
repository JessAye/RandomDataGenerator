using System.Collections;
using System.Runtime.CompilerServices;

namespace RandomDataGenerator;

public class Dependent : Person
{
    protected Random rand = new Random();


    public Dependent()
    {
        firstName = ArrayOfFirstNames[rand.Next(0, ArrayOfFirstNames.Length - 1)];
        lastName = (LastNames)rand.Next(Enum.GetNames(typeof(LastNames)).Length);
        birthDate = RandomDate();
        age = DateTime.Today.Year - birthDate.Year;
        ssNum = new SSN();
        phoneNumber = new Phone();
      
    }

    public override string ToString()
    {
        return string.Format(
            "First Name:{0}\nLast Name{1}\nAge:{2}\nBirthday:{3}\nSocial Security Number:{4}\nPhone Number:{5}\nNumber of Dependents: {6}",
            firstName,
            lastName,
            age,
            birthDate.ToString("MM/dd/yyyy"),
            ssNum,
            phoneNumber,
            Dependents.Count);
    }

    public DateTime RandomDate()
    {
        Random rand = new Random();
        int randYear = rand.Next(2004, 2022);
        int randMonth = rand.Next(1, 12);
        int randDay;
        if (randMonth == 2)
        {
            randDay = rand.Next(1, 28);
        }
        else if (randMonth % 2 == 0)
        {
            randDay = rand.Next(1, 30);
        }
        else
        {
            randDay = rand.Next(1, 31);
        }

        DateTime generateDate = new DateTime(randYear, randMonth, randDay);
        return generateDate;
    }
}
