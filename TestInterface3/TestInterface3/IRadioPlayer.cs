using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface3
{
    interface IRadioPlayer
    {
        void SwitchRadio(bool on);
        void retune(double freq);
        void setVolumeRadio(int loud);
        void changeChannel();
    }
}
