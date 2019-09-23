using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWaterDiagram
{
    class Program
    {
        public static int[] sampleTileArray = { 5, 2, 1, 1, 0, 1, 1, 2, 2, 4 };

        public static int[] data1 = { 3, 2, 4, 1, 0, 1, 7, 2, 2, 4 };

        public static int[] data2 = { 4, 3, 4, 7, 6, 7 };

        public static string sampleString = "5,   . . . . .... .  .   2, 1, 1, 0, 1, 1, 2, 2, 4";

        private static string[] TokeniseString(string str)
        {
            return str.Replace(" ", "").Split(new char[] { ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private static int[] ParseValues(string[] args)
        {
            if (args.Length < 2)
                throw new ArgumentException("There are no input data");

            string[] tokens = TokeniseString(args[1]);

            return tokens.Select(str => Int32.Parse(str)).ToArray();
        }

        static void Main(string[] args)
        {
            var argsData = ParseValues(new string[] { "path", sampleString });

            IWaterDiagramResolver resolver = new WaterDiagramResolver(argsData);

            int result = resolver.ResolveVolume();
            Console.WriteLine("Result : " + result);
        }

    }
}


