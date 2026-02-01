public class Consultation
{
    private Patient patient;
    private Medecin medecin;
    private DossierMedical dossier;
    private DateTime date;

    public Consultation(Patient patient, Medecin medecin, DossierMedical dossier)
    {
        this.patient = patient;
        this.medecin = medecin;
        this.dossier = dossier;
        this.date = DateTime.Now;
    }

    public void AfficherConsultation()
    {
        Console.WriteLine("\n--- CONSULTATION ---");
        patient.AfficherInfos();
        medecin.AfficherInfos();
        dossier.AfficherDossier();
        Console.WriteLine("Date : " + date);
    }
}
