﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation
{
    public interface IMarineTransportation: ITransportation
    {
        void DropAnchor();
    }
}
