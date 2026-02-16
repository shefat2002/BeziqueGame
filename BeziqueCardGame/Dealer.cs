namespace BeziqueCardGame;

public class Dealer
{
    public readonly List<byte> Cards;
    public Player Player;
    public byte CurrentPlayerTurn;

    public Dealer(List<byte> cards, Player player)
    {
        this.Cards = cards;
        this.Player = player;
    }

    public void NotifyDealComplete(int maxPlayer)
    {
        CurrentPlayerTurn = (byte)(CurrentPlayerTurn++ % maxPlayer);
    }
}