using BeziqueCardGame;

namespace BeziqueCardGame.Test;

[TestFixture]
[TestOf(typeof(BeziqueLocalBody))]
public class BeziqueLocalBodyTest
{

    [Test]
    public void DealThreeCards()
    {
        var beziqueConcrete = new BeziqueLocalBody();
        var bezique = new BeziqueBrain(beziqueConcrete);
        bezique.Start();  // Required before dispatching events
        bezique.DispatchEvent(BeziqueBrain.EventId.FOURPLAYERGAME);
        Assert.That(beziqueConcrete.dealCardCount, Is.EqualTo(BeziqueLocalBody.TotalCard - 2));
    }

} 