using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radio
{
    internal class Radio
    {
        public float Volume { get; set; }

        public float Aumentavol()
        {
            Volume=(float)(Volume+Volume*0.1);
            return Volume;
        }

        public float Diminuiscivol()
        {
            Volume = (float)(Volume - (Volume * 0.1));
            return Volume;
        }
    }
}
