using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VeganFit.DAL.Base.EntityFramework
{
    public static class QueryableExtension
    {
        /// <summary>
        /// Kullandığımız entity'i bu entity'nin dışında bu entity ile ilişkisi olan başka bir entity ile birlite kullanmak için oluşturulan ve iki entity'nin birleştirilmiş halini döndüren metot. (Linq'daki Include metodunu özelleştirdiğimiz metot)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        public static IQueryable<T> MyIncludes<T>(this IQueryable<T> query, 
                                                  params Expression<Func<T, object>>[] includes) where T : class
        {
            if (query != null)
            {
                query = includes.Aggregate(query, (a, b) => a.Include(b));
            }
            return query;
        }
    }
}
