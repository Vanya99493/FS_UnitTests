using System.Text;

namespace ClassLibrary
{
    public class Playground
    {
        public char[,] PlaygroundNet;

        public Playground(char[,] playground)
        {
            PlaygroundNet = new char[playground.GetLength(0), playground.GetLength(1)];

            for (int i = 0; i < playground.GetLength(0); i++)
            {
                for (int j = 0; j < playground.GetLength(1); j++)
                {
                    PlaygroundNet[i, j] = playground[i, j];
                }
            }
        }

        public bool CanMove(int heightPos, int widthPos, Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    return PlaygroundNet[heightPos - 1, widthPos] == ' ';
                case Direction.Down:
                    return PlaygroundNet[heightPos + 1, widthPos] == ' ';
                case Direction.Right:
                    return PlaygroundNet[heightPos, widthPos + 1] == ' ';
                case Direction.Left:
                    return PlaygroundNet[heightPos, widthPos - 1] == ' ';
            }
            return false;
        }

        public bool SpawnPlayer(Player player)
        {
            if (PlaygroundNet[player.HeightIndex, player.WidthIndex] == ' ')
            {
                PlaygroundNet[player.HeightIndex, player.WidthIndex] = player.TextureSymbol;
                return true;
            }
            return false;
        }

        public void RemovePlayer(Player player)
        {
            PlaygroundNet[player.HeightIndex, player.WidthIndex] = ' ';
        }

        public void RemovePlayer(char playerTextureSymbol)
        {
            for (int i = 0; i < PlaygroundNet.GetLength(0); i++)
            {
                for (int j = 0; j < PlaygroundNet.GetLength(1); j++)
                {
                    if (PlaygroundNet[i, j] == playerTextureSymbol)
                    {
                        PlaygroundNet[i, j] = ' ';
                    }
                }
            }
        }
    }
}