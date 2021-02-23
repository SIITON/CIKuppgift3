using System;
using System.Collections.Generic;
using System.Text;

namespace CIKuppgift3
{
    public interface IDice
    {
        // Properties of a dice
        int Sides { get; set; }
        IEnumerable<int> Result { get; set; }
        IEnumerable<int> Roll { get; }
        void RollNext();
    }
}
