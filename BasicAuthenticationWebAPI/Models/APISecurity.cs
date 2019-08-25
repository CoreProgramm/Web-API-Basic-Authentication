using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthenticationWebAPI.Models
{
    public class APISecurity
    {
        public static bool Validate(string username, string password)
        {
            
            if (username.Equals("CoreProgramm", StringComparison.OrdinalIgnoreCase) && password == "Core@4327$")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}