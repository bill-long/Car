﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class BatteryDeadException : Exception { }

    public class NoFuelException : Exception { }

    public class JumperCablesNotFoundException : Exception { }
}
