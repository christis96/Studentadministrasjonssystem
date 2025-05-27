namespace Studentadministrasjonssystem;

public class Karakter
{
    public Student Student {get; set;}
    public Fag Fag {get; set;}   
    public string Karakterbokstav {get; set;}

    public Karakter(Student student, Fag fag, string karakterbokstav)
    {
        Student = student;
        Fag = fag;
        Karakterbokstav = karakterbokstav;
    }

    public string SkrivUtInfo()
    {
        return $"Studenten {Student.Navn} får karakteren {Karakterbokstav} i faget {Fag.Fagnavn}";
    }
}