public class Infirmier : PersonnelMedical
{
    private string service;

    public Infirmier(string nom, int age, string matricule, string service)
        : base(nom, age, matricule)
    {
        this.service = service;
    }

    public override void AfficherInfos()
    {
        Console.WriteLine($"Infirmier : {nom} | Service : {service} | Matricule : {matricule}");
    }
}
