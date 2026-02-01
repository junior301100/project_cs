public abstract class PersonnelMedical : Personne
{
    protected string matricule;

    public PersonnelMedical(string nom, int age, string matricule)
        : base(nom, age)
    {
        this.matricule = matricule;
    }
}
