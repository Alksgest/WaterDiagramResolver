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

        public static int[] data1 = { 4, 3, 4, 7, 6, 7 };

        public static string sampleString = "5, 2, 1, 1, 0, 1, 1, 2, 2, 4";

        private static int[] ParseData(string[] args)
        {
            if (args.Length < 2)
                throw new ArgumentException("There are no input data");

            string strData = args[1].Replace(" ", "");
            int[] data = strData.ToCharArray().Select(c => (int)Char.GetNumericValue(c)).Where(i => i != -1).ToArray();

            return data;
        }

        static void Main(string[] args)
        {
            var argsData = ParseData(new string[] { "path", sampleString });

            IWaterDiagramResolver resolver = new WaterDiagramResolver(argsData);

            int result = resolver.ResolveVolume();
            Console.WriteLine("Result : " + result);
        }

    }
}


