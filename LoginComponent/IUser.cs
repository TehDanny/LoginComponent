﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginComponent
{
    interface IUser
    {
        string Email { get; set; }
        int HashedPassword { get; set; }
    }
}
