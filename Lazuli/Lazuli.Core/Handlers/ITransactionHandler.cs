using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Lazuli.Core.Requests.Transactions;
using Lazuli.Core.Responses;

namespace Lazuli.Core.Handlers
{
    public interface ITransactionHandler
    {
        Task<Response<Transaction?>> CreateAsync(CreateTransactionRequest request);
        Task<Response<Transaction?>> UpdateAsync(UpdateTransactionRequest request);
        Task<Response<Transaction?>> DeleteAsync(DeleteTransactionRequest request);
        Task<Response<Transaction?>> GetByIdAsync(GetTransactionById request);
        Task<PagedResponse<List<Transaction>>> GetByPeriodAsync (GetTransactionsByPeriod request);
    }
}