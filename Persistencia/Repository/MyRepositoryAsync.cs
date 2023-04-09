using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Persistencia.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Repository
{
    public class MyRepositoryAsync<T> : RepositoryBase<T>, IRepositoryBase<T> where T : class
    {
        private readonly applicationDbContext _dbContext;
        public MyRepositoryAsync(applicationDbContext dbContext) : base(dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}
