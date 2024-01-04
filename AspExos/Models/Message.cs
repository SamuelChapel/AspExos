namespace AspExos.Models;

public class Message
{
    public int Id { get; set; }
    public string Emetteur { get; set; } = null!;
    public string Contenu { get; set; } = null!;
    public DateOnly Date { get; set; }

    public Message(int id, string emetteur, string contenu, DateOnly date)
    {
        Id = id;
        Emetteur = emetteur;
        Contenu = contenu;
        Date = date;
    }

    public Message()
    {
    }

    public override string ToString()
    {
        return $"{Id} {Emetteur} {Contenu} {Date}";
    }
};
