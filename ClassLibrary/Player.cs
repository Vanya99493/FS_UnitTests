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
    }
}