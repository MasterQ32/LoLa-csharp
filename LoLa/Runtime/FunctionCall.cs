﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoLa.Runtime
{
    public abstract class FunctionCall
    {
        protected FunctionCall()
        {

        }

        public abstract bool Next();

        public Value Result { get; protected set; }
    }
}
