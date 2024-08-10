using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lazuli.Core.Models;
using Lazuli.Core.Requests.Categories;
using Lazuli.Core.Responses;

namespace Lazuli.Core.Handlers
{
    public interface ICategoryHandler
    {
        Task<Response<Category?>> CreateAsync(CreateCategoryRequest request);
        Task<Response<Category?>> UpdateAsync(UpdateCategoryRequest request);
        Task<Response<Category?>> DeleteAsync(DeleteCategoryRequest request);
        Task<Response<Category?>> GetByIdAsync(GetCategoryByIdRequest request);
        Task<PagedResponse<List<Category>>> GetAllAsync(GetAllCategoriesRequest request);
    }
}