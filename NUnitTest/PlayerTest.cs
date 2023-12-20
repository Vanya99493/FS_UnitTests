using ClassLibrary;

namespace NUnitTest
{
    public class PlayerTest
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
            player.Move(_playground, Direction.Up);

            Assert.AreEqual(player, new Player('@', 2, 3));
        }

        [Test]
        public void Test2()
        {
            Player player = new Player('@', 3, 3);
            player.Move(_playground, Direction.Up);
            player.Move(_playground, Direction.Up);
            player.Move(_playground, Direction.Up);

            Assert.AreEqual(player, new Player('@', 1, 3));
        }

        [Test]
        public void Test3()
        {
            Player player = new Player('@', 3, 3);
            player.Move(_playground, Direction.Left);
            player.Move(_playground, Direction.Up);
            player.Move(_playground, Direction.Up);
            player.Move(_playground, Direction.Right);

            Assert.AreEqual(player, new Player('@', 3, 3));
        }

        [Test]
        public void Test4()
        {
            Player player = new Player('@', 3, 3);

            player.Move(_playground, Direction.Up);
            player.Move(_playground, Direction.Up);
            player.Move(_playground, Direction.Left);
            player.Move(_playground, Direction.Down);
            player.Move(_playground, Direction.Down);
            player.Move(_playground, Direction.Right);
            player.Move(_playground, Direction.Right);
            player.Move(_playground, Direction.Up);

            Assert.AreEqual(player, new Player('@', 1, 4));
        }
    }
}