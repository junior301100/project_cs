public class Patient : Personne
{
    private string numeroDossier;

    public Patient(string nom, int age, string numeroDossier)
        : base(nom, age)
    {
        this.numeroDossier = numeroDossier;
    }

    public override void AfficherInfos()
    {
        Console.WriteLine($"Patient : {nom} | Âge : {age} | Dossier : {numeroDossier}");
    }
}
