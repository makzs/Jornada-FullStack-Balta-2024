using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lazuli.Core.Requests.Transactions
{
    public class DeleteTransactionRequest : Request
    {
        public long Id {get; set;}
    }
}