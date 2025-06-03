namespace Studentadministrasjonssystem;

class Program
{
    static void Main(string[] args)
    {
        var lfag1 = new Fag("STA-1001","Statistikk og sannsynlighet", 10);
        var lfag2 = new Fag("INF-1400","Intro til objektorientert programmering", 10);
        var lfag3 = new Fag("MAT-1005","Diskret matematikk", 10);

        var fagliste = new List<Fag> { lfag1, lfag2, lfag3 };
        
        var student = new Student("Pål", 18, "Studiespess", fagliste);
        var student2 = new Student("Per", 28, "Påbygg", fagliste);
        Console.WriteLine(student.SkrivUtInfo());
        Console.WriteLine(student2.SkrivUtInfo());
        var fag = new Fag("MAT-1001", "Kalkulus", 10);
        var fag2 = new Fag("INF-1101", "Datastrukturer og algoritmer", 10);
        Console.WriteLine(fag.SkrivUtInfo());
        Console.WriteLine(fag2.SkrivUtInfo());
        var karaktertilstudent = new Karakter(student, fag, "D");
        var karaktertilstudent2 = new Karakter(student2, fag2, "B");
        Console.WriteLine(karaktertilstudent.SkrivUtInfo());
        Console.WriteLine(karaktertilstudent2.SkrivUtInfo());
        Console.WriteLine("");
        
        foreach (var fagl in student.FagListe)
        {
            var karakter = new Karakter(student, fagl, "B");
            student.LeggTilKarakter(karakter);
        }
        
        foreach (var fagl2 in student2.FagListe)
        {
            var karakter = new Karakter(student2, fagl2, "A");
            student2.LeggTilKarakter(karakter);
        }
        foreach (var k in student.Karakterer)
        {
            Console.WriteLine(k.SkrivUtInfo());
        }

        foreach (var k in student2.Karakterer)
        {
            Console.WriteLine(k.SkrivUtInfo());
        }
        
        Console.WriteLine(student.SkrivUtGjennomsnitt());
        Console.WriteLine(student2.SkrivUtGjennomsnitt());
        

    }
}