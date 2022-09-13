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
        lastName= (LastNames) rand.Next(Enum.GetNames(typeof(LastNames)).Length);
        birthDate = RandomDate();
        age = DateTime.Today.Year - birthDate.Year;
        ssNum = new SSN();
        phoneNumber = new Phone();
        int amountOfChildern = rand.Next(1, 1);
        
    }

   

    public override string ToString()
    {
        return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}",
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
        int rndYear = rand.Next(1942, 2004);
        int rndMonth = rand.Next(1, 12);
        int rndDay = rand.Next(1, 28); // I hate this line of code so much
        DateTime generateDate;
        generateDate = new DateTime(rndYear, rndMonth, rndDay);
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
    public List<Person> Dependents{
        get { return dependents; }
        init { dependents = value; }
    }

    public string[] ArrayOfFirstNames
    {
        get { return _arrayOfFirstNames; }
        init { _arrayOfFirstNames = value; }
    }
}
