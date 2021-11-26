namespace diario_libruso.Models
{
    public class Ogloszenie
    {
        public int Id { get; set; }
        public string Tresc { get; set; }
    }

    public class OgloszenieKlasowe : Ogloszenie
    {
        public Klasa Klasa { get; set; }
    }
}