using System.Security.Cryptography;
using System.Threading.Channels;
using System.Collections;

namespace RandomDataGenerator;

public class Person
{
    protected Random rand = new Random();

    protected string firstName;
    protected Enum lastName;
    protected DateTime birthDate;
    protected double age;
    protected SSN ssNum;
    protected Phone phoneNumber;
    private List<Person> dependents = new List<Person>();

    private string[] _arrayOfFirstNames = new String[10]
        { "Roy", "Craig", "Rose", "Milton", "Peter", "Brian", "Hugh", "Greg", "Sam", "Fred" };

    public Person()
    {
        firstName = _arrayOfFirstNames[rand.Next(0, _arrayOfFirstNames.Length - 1)];
        lastName = (LastNames)rand.Next(Enum.GetNames(typeof(LastNames)).Length);
        birthDate = RandomDate();
        age = DateTime.Today.Year - birthDate.Year;
        ssNum = new SSN();
        phoneNumber = new Phone();
      
    }


    public override string ToString()
    {
        return string.Format("First Name:{0}\n Last Name: {1}\nAge: {2}\nBirthday: {3}\nSocial Security: {4}\nPhone Number: {5}\nNumber of Children: {6}\n",
            firstName,
            lastName,
            age,
            birthDate.ToString("MM/dd/yyyy"),
            ssNum,
            phoneNumber,
            dependents.Count);
    }

    public virtual DateTime RandomDate()
    {
        Random rand = new Random();
        DateTime currentDate = DateTime.Now;
        int randYear = rand.Next(1942, 2004);
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

    public void AddDependents()
    {
        this.dependents.Add(new Dependent());
    }


    public string FirstName
    {
        get { return firstName; }
        init { firstName = value; }
    }

    public Enum LastName
    {
        get { return lastName; }
        init { lastName = value; }
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

    public List<Person> Dependents
    {
        get { return dependents; }
        init { dependents = value; }
    }

    public string[] ArrayOfFirstNames
    {
        get { return _arrayOfFirstNames; }
        init { _arrayOfFirstNames = value; }
    }
}
