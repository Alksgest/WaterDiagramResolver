using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWaterDiagram
{
    interface IWaterDiagramResolver
    {
        int ResolveVolume();
        void SetWaterDiagram(int[] array);
    }
}
