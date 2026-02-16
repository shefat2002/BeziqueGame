namespace BeziqueCardGame;

public class BeziqueLocalBody : IBeziqueAdapter
{
    public const int TotalCard = 132;
    public Dealer Dealer;
    public Player[] Players;
    public int dealCardCount;

    public BeziqueLocalBody()
    {
        
    }

    public BeziqueLocalBody(int playerCount)
    {
        
    }

    public void DealThreeCards()
    {
        
    }

    public void Add10PointsToDealer()
    {
        throw new NotImplementedException();
    }

    public void FlipCard()
    {
        throw new NotImplementedException();
    }

    public void DrawCardFromDeck()
    {
        throw new NotImplementedException();
    }

    public void CheckDeckCardCount()
    {
        throw new NotImplementedException();
    }

    public void AddMeldPoint()
    {
        throw new NotImplementedException();
    }

    public void AllPlayerPlayed()
    {
        throw new NotImplementedException();
    }

    public void DetermineWinner()
    {
        throw new NotImplementedException();
    }

    public void CheckCardsOnHand()
    {
        throw new NotImplementedException();
    }
}