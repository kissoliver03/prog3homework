﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3HomeWork.Interface
{
    public interface IParser<T>
    {
        T Parse(string[] input);
    }
}
