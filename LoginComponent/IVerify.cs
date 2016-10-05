﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginComponent
{
    interface IVerify
    {
        void CheckEmail();
        void CheckPassword();
        void ConfirmPassword();
    }
}
