namespace RandomDataGenerator;

public class Phone
{
    private string Number()
    {
        Random rng = new Random();
        string number = string.Format("{0}{1}{2}-{3}{4}{5}-{6}{7}{8}{9}",
            rng.Next(2, 9), 
            rng.Next(0, 9),
            rng.Next(0, 9),
            rng.Next(0, 9), 
            rng.Next(0, 9), 
            rng.Next(0, 9),
            rng.Next(0, 9),
            rng.Next(0, 9),
            rng.Next(0, 9),
            rng.Next(0, 9));
        return number;
    }

    public string CustomToString()
    {
        return Number();
    }

    public override string ToString()

    {
        return Number();
        ;
    }
}
