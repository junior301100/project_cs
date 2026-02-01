using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Personne> personnes = new List<Personne>();
        List<Patient> patients = new List<Patient>();
        List<Medecin> medecins = new List<Medecin>();
        List<Consultation> consultations = new List<Consultation>();

        bool quitter = false;

        while (!quitter)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Ajouter un patient");
            Console.WriteLine("2. Ajouter un médecin");
            Console.WriteLine("3. Créer une consultation");
            Console.WriteLine("4. Afficher toutes les personnes");
            Console.WriteLine("5. Afficher les consultations");
            Console.WriteLine("6. Quitter");
            Console.Write("Choix : ");

            string choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    Console.Write("Nom : ");
                    string nomP = Console.ReadLine();
                    Console.Write("Âge : ");
                    int ageP = int.Parse(Console.ReadLine());
                    Console.Write("Numéro de dossier : ");
                    string nd = Console.ReadLine();

                    Patient p = new Patient(nomP, ageP, nd);
                    patients.Add(p);
                    personnes.Add(p);
                    break;

                case "2":
                    Console.Write("Nom : ");
                    string nomM = Console.ReadLine();
                    Console.Write("Âge : ");
                    int ageM = int.Parse(Console.ReadLine());
                    Console.Write("Matricule : ");
                    string mat = Console.ReadLine();
                    Console.Write("Spécialité : ");
                    string spec = Console.ReadLine();

                    Medecin m = new Medecin(nomM, ageM, mat, spec);
                    medecins.Add(m);
                    personnes.Add(m);
                    break;

                case "3":
                    if (patients.Count == 0 || medecins.Count == 0)
                    {
                        Console.WriteLine("Ajoutez d'abord un patient et un médecin.");
                        break;
                    }

                    Console.Write("Diagnostic : ");
                    string diag = Console.ReadLine();
                    Console.Write("Traitement : ");
                    string tr = Console.ReadLine();

                    DossierMedical dm = new DossierMedical(diag, tr);
                    Consultation c = new Consultation(patients[0], medecins[0], dm);
                    consultations.Add(c);
                    break;

                case "4":
                    foreach (Personne pers in personnes)
                    {
                        pers.AfficherInfos();
                    }
                    break;

                case "5":
                    foreach (Consultation cons in consultations)
                    {
                        cons.AfficherConsultation();
                    }
                    break;

                case "6":
                    quitter = true;
                    break;

                default:
                    Console.WriteLine("Choix invalide !");
                    break;
            }
        }
    }
}
