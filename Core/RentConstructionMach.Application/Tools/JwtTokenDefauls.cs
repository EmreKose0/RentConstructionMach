using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Tools
{
    public class JwtTokenDefauls
    {
        public const string ValidAudience = "https://localhost";
        public const string ValidIssuer = "https://localhost";
        public const string Key = "MachineRent+*010203CARBOOK1+*..020304RentMachinwe";
        public const int Expire = 3;
    }
}
