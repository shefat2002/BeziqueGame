namespace BeziqueCardGame;

public class BeziqueBody : IBeziqueAdapter
{
    public const int TotalCard = 132;
    public int dealCardCount = TotalCard;
    
    public void DealThreeCards()
    {
        dealCardCount -= 3;
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