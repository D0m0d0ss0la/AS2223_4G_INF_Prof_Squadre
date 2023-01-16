using Library;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddPlayers()
        {
            Team team = new Team("Squadra x");
            bool boolean = team.AddPlayer(new Player("Cognome 1", "Nome 1", Player.ERole.Rosa));
            Assert.IsTrue(boolean, "The bool is false");
        }

        [Test]
        public void AddCaptain()
        {
            Team team = new Team("Squadra x");
            bool boolean =  team.AddCaptain(new Player("Cognome 1", "Nome 1", Player.ERole.Rosa));
            Assert.IsTrue(boolean, "The bool is false");
        }
    }
}