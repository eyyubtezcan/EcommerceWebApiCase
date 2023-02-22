using EcommerceWebApiCase.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EcommerceWebApiCase.Service
{
    public class Service<T> : IService<T> where T : class
    {
  
        protected readonly EcommerceDbContext _context;
        private readonly DbSet<T> _dbSet;
        public Service(EcommerceDbContext context)
        {
            _context = context;           
        }       

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }       

        public async Task<bool> SingleOrDefaultAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }      

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
    }
}