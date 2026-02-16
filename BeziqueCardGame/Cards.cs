namespace BeziqueCardGame;
public record Card(Suit? Suit, Rank? Rank, bool IsJoker = false);
public enum Rank
{
    Ace,
    Ten,
    King,
    Queen,
    Jack,
    Nine,
    Eight,
    Seven
};

public enum Suit
{
    Hearts,
    Spades,
    Diamonds,
    Clubs
};

public static class Cards
{
    private const byte CardCount = 132;
    private const byte Decks = 4;
    
    public static List<Card> CreateCard()
    {
        var Cards = new List<Card>(CardCount);
        for (int i = 0; i < Decks; i++)
        {
            foreach (var suit in Enum.GetValues<Suit>())
            {
                foreach (var rank in Enum.GetValues<Rank>())
                {
                    Cards.Add(new Card(suit, rank));
                }
            }
            Cards.Add(new Card(null,null,true));
        }
        return Cards;
    }
}