using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Core.Enums;

namespace VeganFit.UI.LoginUser
{
    public static class ActiveUser
    {
        public static string ActiveUserName { get; set; }
        public static string ActiveUserFirstName { get; set; }
        public static Role Role { get; set; }
    }
}
