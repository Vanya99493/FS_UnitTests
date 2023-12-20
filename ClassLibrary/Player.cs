namespace ClassLibrary
{
    public struct Player
    {
        public char TextureSymbol { get; private set; }

        public int HeightIndex { get; private set; }
        public int WidthIndex { get; private set; }

        public Player(char textureSymbole, int heightIndex, int widthIndex)
        {
            TextureSymbol = textureSymbole;
            HeightIndex = heightIndex;
            WidthIndex = widthIndex;
        }

        public bool Move(Playground playground, Direction direction)
        {
            bool canMove = playground.CanMove(HeightIndex, WidthIndex, direction);

            if (canMove)
            {
                switch (direction)
                {
                    case Direction.Left:
                        --WidthIndex;
                        break;
                    case Direction.Right:
                        ++WidthIndex;
                        break;
                    case Direction.Up:
                        --HeightIndex;
                        break;
                    case Direction.Down:
                        ++HeightIndex;
                        break;
                }
            }

            return canMove;
        }
    }
}