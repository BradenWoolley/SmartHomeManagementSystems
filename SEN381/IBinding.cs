using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381
{
    interface IBinding
    {
        void RefreshAll();
        void RefreshComponents();
        void RefreshActors();
        void RefreshSensors();
        void RefreshControllers();
    }
}
