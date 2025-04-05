namespace AbstractFactory.Certificate;

public class BrazilianCertificate : ICertificate
{
    public void ApplyCertification()
    {
        Console.WriteLine("Applying brazilian certificate.");
    }
}