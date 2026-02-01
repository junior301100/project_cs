public abstract class Personne
{
    protected string nom;
    protected int age;

    public Personne(string nom, int age)
    {
        this.nom = nom;
        this.age = age;
    }

    public abstract void AfficherInfos();
}
