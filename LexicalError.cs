﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCompilador
{
    public class LexicalError : AnalysisError
    {
        public LexicalError(String msg, int position) : base (msg, position) { }

        public LexicalError(String msg) : base(msg) { }
    }
}
