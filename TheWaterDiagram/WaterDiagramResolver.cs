using System.Collections.Generic;

namespace TheWaterDiagram
{
    public class WaterDiagramResolver : IWaterDiagramResolver
    {
        private int[] array;

        public WaterDiagramResolver(int[] array)
        {
            SetWaterDiagram(array);
        }

        public void SetWaterDiagram(int[] array) => this.array = array;

        public int ResolveVolume()
        {
            int result = 0;

            GetAllGapes().ForEach((g) => result += GetGapeVolume(g));

            return result;
        }

        private int GetGapeVolume(Gape gape)
        {
            int maxDeep = gape.GetLowest();
            int maxSize = maxDeep * gape.GetDiff();

            int size = maxSize;
            for (int i = gape.leftIndex + 1; i < gape.rightIndex; ++i)
                size -= this.array[i];

            return size;
        }

        private List<Gape> GetAllGapes()
        {
            int left = 0;
            List<Gape> gapes = new List<Gape>();
            while(left != array.Length - 1)
            {
                var gape = GetNextGape(left);
                left = gape.rightIndex;
                gapes.Add(gape);
            }
            return gapes;
        }

        private Gape GetNextGape(int start)
        {
            int left = array[start];

            int max = -1;
            int maxIndex = -1;
            for(int i = start + 1; i < array.Length; ++i)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                    if (max > left)
                        break;
                }
            }
            return new Gape(left, max, start, maxIndex);
        }
    }
}


