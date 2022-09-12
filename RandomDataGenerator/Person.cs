using System.Security.Cryptography;
using System.Threading.Channels;

namespace RandomDataGenerator;

public class Person
{
    Random rand = new Random();

    private string[] _arrayOfFirstNames = new String[10]
        { "Roy", "Craig", "Rose", "Milton", "Peter", "Brian", "Hugh", "Greg", "Sam", "Fred" };

    public string firstName;
    public Enum lastName;
    public DateTime birthDate;
    public double age;
    public SSN ssNum;
    public Phone phoneNumber;
    //public Person[] Dependents;


    public override string ToString()
    {
        return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}",
            firstName,
            lastName,
            age,
            birthDate.ToString("MM/dd/yyyy"),
            ssNum,
            phoneNumber,
            "Dependants");
        //Dependents.Length);
    }

 
    public string FirstName
    {
        get { return firstName; }
        init { firstName = value; }
    }

    public string LastName
    {
        get { return firstName; }
        init { firstName = value; }
    }

    public DateTime BirthDate
    {
        get { return birthDate; }
        init { birthDate = value; }
    }

    public double Age
    {
        get { return age; }
        init { age = value; }
    }

    public Phone PhoneNumber
    {
        get { return phoneNumber; }
        init { phoneNumber = value; }
    }

    public SSN SSNUM
    {
        get { return ssNum; }
        init { ssNum = value; }
    }

    public string[] ArrayOfFirstNames
    {
        get { return _arrayOfFirstNames; }
        init { _arrayOfFirstNames = value; }
    }
}
