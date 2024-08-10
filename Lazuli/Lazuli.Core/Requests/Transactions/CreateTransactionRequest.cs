using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Lazuli.Core.Enums;

namespace Lazuli.Core.Requests.Transactions
{
    public class CreateTransactionRequest : Request
    {
        [Required(ErrorMessage = "Titulo Invalido")]
        [MaxLength(80, ErrorMessage = "O titulo deve conter até 80 caracteres")]
        public string Title {get; set;} = string.Empty;

        [Required(ErrorMessage = "Tipo invalido")]
        public ETransactionType Type { get; set; } = ETransactionType.Withdraw;

        [Required(ErrorMessage = "Valor invalido")]
        public decimal Amount {get; set;}

        [Required(ErrorMessage = "Categoria invalida")]
        public long CategoryId { get; set; }

        [Required(ErrorMessage = "Data invalida")]
        public DateTime? PaidOrReceiveAt {get; set;}
    }
}