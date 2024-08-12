using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lazuli.Api.Common.Api;
using Lazuli.Core.Handlers;
using Lazuli.Core.Models;
using Lazuli.Core.Requests.Transactions;
using Lazuli.Core.Responses;

namespace Lazuli.Api.Endpoints.Transactions
{
    public class GetTransactionByIdEndpoint : IEndpoint
    {
        public static void Map(IEndpointRouteBuilder app)
            => app.MapGet("/{id}", HandleAsync)
                .WithName("Transactions: Get By Id")
                .WithSummary("Recupera uma transação")
                .WithDescription("Recupera uma transação")
                .WithOrder(4)
                .Produces<Response<Transaction?>>();

        private static async Task<IResult> HandleAsync(
            ITransactionHandler handler,
            long id)
        {
            var request = new GetTransactionById
            {
                UserId = ApiConfiguration.UserId,
                Id = id
            };

            var result = await handler.GetByIdAsync(request);
            return result.IsSuccess
                ? TypedResults.Ok(result)
                : TypedResults.BadRequest(result);
        }
    }
}