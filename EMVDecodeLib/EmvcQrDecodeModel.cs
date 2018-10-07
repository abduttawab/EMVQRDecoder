using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMVDecodeLib
{

    public class EmvcQrDecodeModel
    {
        public string ObjectNo { get; set; }
        public int DataLength { get; set; }
        public string Data { get; set; }
    }
}
