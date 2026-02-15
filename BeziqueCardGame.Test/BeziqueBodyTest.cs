using BeziqueCardGame;

namespace BeziqueCardGame.Test;

[TestFixture]
[TestOf(typeof(BeziqueBody))]
public class BeziqueBodyTest
{

    [Test]
    public void DealThreeCards()
    {
        var beziqueConcrete = new BeziqueBody();
        var bezique = new BeziqueBrain(beziqueConcrete);
        bezique.Start();  // Required before dispatching events
        bezique.DispatchEvent(BeziqueBrain.EventId.FOURPLAYERGAME);
        Assert.That(beziqueConcrete.dealCardCount, Is.EqualTo(BeziqueBody.TotalCard - 2));
    }

} 