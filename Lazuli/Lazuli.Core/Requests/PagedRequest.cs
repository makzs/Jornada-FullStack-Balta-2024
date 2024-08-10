using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lazuli.Core.Requests
{
    public abstract class PagedRequest : Request
    {
        public int PageSize { get; set; } = Configuration.DefaultPageSize;
        public int PageNumber { get; set; } = Configuration.DefaultPageNumber;
    }
}