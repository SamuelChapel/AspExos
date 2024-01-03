namespace AspExos.Models;

public record Message(
    string Emetteur,
    string Contenu,
    DateOnly Date
    );
