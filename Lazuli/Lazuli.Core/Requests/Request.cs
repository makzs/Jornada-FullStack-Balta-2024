using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lazuli.Core.Requests
{
    
    public abstract class Request
    {
        public string UserId { get; set;} = string.Empty;

    }
}