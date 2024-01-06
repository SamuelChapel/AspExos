using Bogus;
using Location.Entities.Base;

namespace AspExos.Models;

public class Message : IEntity<int>
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

    public static Message GetRandomMessage()
    {
        return new Faker<Message>()
            .RuleFor(m => m.Emetteur, f => f.Person.FullName)
            .RuleFor(m => m.Contenu, f => f.Lorem.Paragraph(1))
            .RuleFor(m => m.Date, f => f.Date.PastDateOnly())
            .Generate();
    }

    public static IEnumerable<Message> GetRandomMessages(int count, int start = 1)
    {
        return Enumerable.Range(start, count).Select(i => new Faker<Message>()
            .RuleFor(m => m.Id, i)
            .RuleFor(m => m.Emetteur, f => f.Person.FullName)
            .RuleFor(m => m.Contenu, f => f.Lorem.Paragraph(1))
            .RuleFor(m => m.Date, f => f.Date.PastDateOnly())
            .Generate());
    }
};
