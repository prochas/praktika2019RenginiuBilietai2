﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenginiuBilietai3
{
    class User : Prisijungimas
    {
        public override string LoginTable
        {
            get
            {
                return "users";
            }

        }
    }
}
