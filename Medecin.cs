public class Medecin : PersonnelMedical
{
    private string specialite;

    public Medecin(string nom, int age, string matricule, string specialite)
        : base(nom, age, matricule)
    {
        this.specialite = specialite;
    }

    public override void AfficherInfos()
    {
        Console.WriteLine($"Médecin : {nom} | Spécialité : {specialite} | Matricule : {matricule}");
    }
}
