using GrpcMyExampleServer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcMyExampleServer.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Category> AddCategory(CategoryCreate category)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
