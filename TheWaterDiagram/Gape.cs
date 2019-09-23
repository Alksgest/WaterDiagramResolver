namespace TheWaterDiagram
{
    public struct Gape
    {
        public int left;
        public int right;

        public int leftIndex;
        public int rightIndex;

        public Gape(int l, int r, int li, int ri)
        {
            left = l;
            right = r;
            leftIndex = li;
            rightIndex = ri;
        }

        public int GetLowest() => left > right ? right : left;

        public int GetDiff() => rightIndex - leftIndex - 1;

        public override string ToString() 
            => $"left = {left}, right = {right}, leftIndex = {leftIndex}, rightIndex = {rightIndex}";
    }
}


