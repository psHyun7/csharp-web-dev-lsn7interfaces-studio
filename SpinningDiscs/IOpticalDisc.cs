using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SpinningDiscs
{
    public interface IOpticalDisc
    {
        void SpinDisc();
        void WriteOnDisc();
        void ReadDisc();

    }
}