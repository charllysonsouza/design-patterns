namespace AbstractFactory.Certificate;

public class UsaCertificate : ICertificate
{
    public void ApplyCertification()
    {
        Console.WriteLine("Applying USA certificate.");
    }
}