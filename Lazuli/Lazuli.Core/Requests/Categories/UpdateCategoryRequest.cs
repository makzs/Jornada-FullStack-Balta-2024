using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lazuli.Core.Requests.Categories
{
    public class UpdateCategoryRequest : Request
    {
        public long Id {get; set;}
        
        [Required(ErrorMessage = "Titulo Invalido")]
        [MaxLength(80, ErrorMessage = "O titulo deve conter até 80 caracteres")]
        public string Title {get; set;} = string.Empty;

        [Required(ErrorMessage = "Descrição invalida")]
        public string Description {get; set;} = string.Empty;
    }
}