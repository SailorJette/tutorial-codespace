//https://learn.microsoft.com/de-de/dotnet/csharp/tutorials/working-with-linq

// Arbeiten mit LINQ (Language-Integrated Query)

ArbeitenMitLinq();


void ArbeitenMitLinq()
{
    var startingDeck = from s in Suits()
                       from r in Ranks()
                       select (Suits: s, Rank: r);

    foreach (var card in startingDeck)
    {
        Console.WriteLine(card);
    }

}



static IEnumerable<string> Suits()
{
    yield return "Hearts";
    yield return "Diamonds";
    yield return "Clubs";
    yield return "Spades";
}

static IEnumerable<string> Ranks()
{
    yield return "Two";
    yield return "Three";
    yield return "Four";
    yield return "Five";
    yield return "Six";
    yield return "Seven";
    yield return "Eight";
    yield return "Nine";
    yield return "Ten";
    yield return "Jack";
    yield return "Queen";
    yield return "King";
    yield return "Ace";
}