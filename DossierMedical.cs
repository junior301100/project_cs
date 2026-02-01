public class DossierMedical
{
    private string diagnostic;
    private string traitement;

    public DossierMedical(string diagnostic, string traitement)
    {
        this.diagnostic = diagnostic;
        this.traitement = traitement;
    }

    public void AfficherDossier()
    {
        Console.WriteLine("Diagnostic : " + diagnostic);
        Console.WriteLine("Traitement : " + traitement);
    }
}
