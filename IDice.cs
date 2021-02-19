using System;
using System.Collections.Generic;
using System.Text;

namespace CIKuppgift3
{
    public interface IDice
    {
        // Properties of a dice
        int Sides { get; set; }
        int Result { get; set; }
        int Roll { get; }
        void RollNext();
    }
}
