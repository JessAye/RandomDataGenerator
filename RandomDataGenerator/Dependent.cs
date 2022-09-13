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
        int amountOfChildern = rand.Next(1, 1);
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
        int rndYear = rand.Next(2004, 2022);
        int rndMonth = rand.Next(1, 12);
        int rndDay = rand.Next(1, 28);
        DateTime generateDate = new DateTime(rndYear, rndMonth, rndDay);
        return generateDate;
    }
}