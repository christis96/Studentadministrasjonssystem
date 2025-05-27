namespace Studentadministrasjonssystem;

public class Student
{
    public string Navn { get; set; }
    public int Alder { get; set; }
    public string Studieprogram { get; set; }
    public List<Karakter> Karakterer { get; set; } = new List<Karakter>();
    public List<Fag> FagListe { get; set; }

    public Student(string navn, int alder, string studieprogram,  List<Fag> fagListe, List<Karakter>? karakterer = null)
    {
        Navn = navn;
        Alder = alder;
        Studieprogram = studieprogram;
        Karakterer = karakterer ?? new List<Karakter>();
        FagListe = fagListe;
    }

    public string SkrivUtInfo()
    {
        return $"Denne personen heter {Navn}, er {Alder} år og går {Studieprogram}";
    }
    
    public void LeggTilKarakter(Karakter karakter)
    {
        Karakterer.Add(karakter);
    }
}