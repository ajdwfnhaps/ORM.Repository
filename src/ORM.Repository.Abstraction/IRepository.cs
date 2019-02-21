using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ORM.Repository.Abstraction
{
    /// <summary>
    /// 仓储模式接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<TEntity> where TEntity : class
    {
        
        TEntity Get(Expression<Func<TEntity, bool>> exp, params string[] includes);
        TEntity Get(params object[] keyValues);

        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> exp, params string[] includes);
        Task<TEntity> GetAsync(params object[] keyValues);
        

        /// <summary>
        /// FromSql
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        IQueryable<TEntity> FromSql(string sql);
    }
}
