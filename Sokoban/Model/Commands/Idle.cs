﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    class Idle : ICommand
    {
        public int DeltaX { get; }
        public int DeltaY { get; }
    }
}