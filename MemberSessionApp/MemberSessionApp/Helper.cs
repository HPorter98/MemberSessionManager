using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace MemberSessionApp
{
    public static class Helper
    {
        public static string ConVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
