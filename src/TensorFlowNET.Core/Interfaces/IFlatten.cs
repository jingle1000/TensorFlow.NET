﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tensorflow
{
    public interface ICanBeFlattened
    {
        object[] Flatten();
    }
}
