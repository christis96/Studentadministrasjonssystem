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

    public string SkrivUtGjennomsnitt()
         {
             if (Karakterer == null || Karakterer.Count == 0)
                 return "Ingen karakterer";

             Dictionary<string, int> bokstavTilTall = new Dictionary<string, int>
             {
                 { "A", 6 },
                 { "B", 5 },
                 { "C", 4 },
                 { "D", 3 },
                 { "E", 2 },
                 { "F", 1 }
             };
             Dictionary<int, string> tallTilBokstav = new Dictionary<int, string>
             {
                 { 6, "A" },
                 { 5, "B" },
                 { 4, "C" },
                 { 3, "D" },
                 { 2, "E" },
                 { 1, "F" }
             };

             double gjennomsnitt = Karakterer.Average(k => bokstavTilTall[k.Karakterbokstav]);
             int avrundet = (int)Math.Round(gjennomsnitt);  

             return tallTilBokstav[avrundet];
         }
    public int TotaltStudiepoeng()
    {
        int sum = 0;
        foreach (var fag in FagListe)
        {
            sum += fag.Studiepoeng;
        }
        return sum;
    }
}