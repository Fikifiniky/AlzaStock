using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlzaStockCheck
{
    public enum SKUs
    {
        GPU_3090,
        //GPU_3080Ti,
        GPU_3080,
        //GPU_3070Ti,
        GPU_3070,
        GPU_3060Ti,
        GPU_3060,
    };

    public class GpuUrls
    {
        public static readonly Dictionary<SKUs, string> urls = new Dictionary<SKUs, string>()
        {
            {SKUs.GPU_3090, @"https://www.alza.cz/graficke-karty-nvidia-geforce-rtx3090/18881468.htm" },
            //{ChipType.GPU_3080Ti, String.Empty },
            {SKUs.GPU_3080, @"https://www.alza.cz/graficke-karty-nvidia-geforce-rtx3080/18881467.htm" },
            //{ChipType.GPU_3070Ti, String.Empty },
            {SKUs.GPU_3070, @"https://www.alza.cz/graficke-karty-nvidia-geforce-rtx3070/18881603.htm" },
            {SKUs.GPU_3060Ti, @"https://www.alza.cz/graficke-karty-nvidia-geforce-rtx-3060-ti/18884150.htm" },
            {SKUs.GPU_3060, @"https://www.alza.cz/graficke-karty-nvidia-geforce-rtx-3060/18885740.htm" }
        };
    }
}
