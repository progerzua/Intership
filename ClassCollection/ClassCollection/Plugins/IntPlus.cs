﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassCollection.Plugins
{
    class IntPlus : IPlugin<int>
    {
        public int Converting(int input)
        {
            return input + 10;
        }
    }
}
