namespace BeziqueCardGame;

public interface IBeziqueAdapter
{
    void DealThreeCards();
    void Add10PointsToDealer();
    void FlipCard();

    void DrawCardFromDeck();
    void CheckDeckCardCount();
    void AddMeldPoint();
    void AllPlayerPlayed();
    void DetermineWinner();
    void CheckCardsOnHand();
}