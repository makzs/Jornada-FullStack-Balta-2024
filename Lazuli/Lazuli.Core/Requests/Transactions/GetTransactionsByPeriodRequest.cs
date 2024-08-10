using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lazuli.Core.Requests.Transactions
{
    public class GetTransactionsByPeriod : PagedRequest
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}