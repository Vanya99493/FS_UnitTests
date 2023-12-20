using ClassLibrary;

namespace NUnitTest
{
    public class PlaygroundTest
    {
        Playground _playground;

        [SetUp]
        public void Setup()
        {
            _playground = new Playground(new char[,] {
                { '#', '#', '#', '#', '#', '#', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', '#', ' ', '#', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', '#', ' ', '#', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', '#', '#', '#', '#', '#', '#' }
            });
        }

        [Test]
        public void Test1()
        {
            Player player = new Player('@', 3, 3);

            Assert.AreEqual(_playground.SpawnPlayer(player), true);
        }

        [Test]
        public void Test2()
        {
            Player player = new Player('@', 2, 2);

            Assert.AreEqual(_playground.SpawnPlayer(player), false);
        }

        [Test]
        public void Test3()
        {
            Player player = new Player('@', 0, 0);

            Assert.AreEqual(_playground.SpawnPlayer(player), false);
        }

        [Test]
        public void Test4()
        {
            Player player = new Player('@', 4, 3);

            Assert.AreEqual(_playground.SpawnPlayer(player), true);
        }
    }
}