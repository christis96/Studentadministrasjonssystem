namespace Studentadministrasjonssystem;

public class Fag
{
    public string Fagkode { get; set; }
    public string Fagnavn  { get; set; }
    public int Studiepoeng { get; set; }

    public Fag(string fagkode, string fagnavn, int studiepoeng)
    {
        Fagkode = fagkode;
        Fagnavn = fagnavn;
        Studiepoeng = studiepoeng;
    }

    public string SkrivUtInfo()
    {
        return $"Fagkoden er {Fagkode}, navnet på faget er {Fagnavn} og det gir {Studiepoeng} studiepoeng";
    }
}