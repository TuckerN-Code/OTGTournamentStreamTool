using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using OTGStreamToolBackEnd;

namespace OTGStreamToolUserSide
{
    public static class Global
    {
        public static UpdatePackage updatePackage = new UpdatePackage();
        
        public static string[]? args;

        public static Process? process;
    }
}
