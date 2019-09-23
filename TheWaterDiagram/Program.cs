using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWaterDiagram
{
    class Program
    {
        public static int[] sampleTileArray = { 5, 2, 1, 1, 0, 1, 1, 2, 2, 4 };

        public static int[] data = { 3, 2, 4, 1, 0, 1, 7, 2, 2, 4 };

        public static int[] data1 = { 4, 3, 4, 7 };

        public static int sampleResult = 22;
        static void Main(string[] args)
        {
            WaterDiagramResolver resolver = new WaterDiagramResolver(data1);

            int result = resolver.ResolveVolume();
            Console.WriteLine("Result : " + result);
        }

    }
}


