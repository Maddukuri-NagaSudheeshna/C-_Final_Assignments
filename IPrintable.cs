﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSForLitwareOrganization
{
    internal interface IPrintable  //interface only implements Interfaces.
    {
        void LoginForLitwareOrg();
        
        void LogoutfromLitwareOrg();
    }
}
