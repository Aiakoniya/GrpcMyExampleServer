using GrpcMyExampleServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcMyExampleServer.Repositories.Interfaces
{
    public class ICategoryRepository
    {
        Task<Category> AddCategory(CategoryCreate category);
        Task<Category> GetCategoryById(int id);
    }
}
