﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Utilities.Results.ComplexType
{
    public enum ResultStatus
    { 
        Success=0,
        Error=1,
        Warning=2, //ResultStatus.Warning şeklinde kullanılacak
        Info=3
    }
}
