using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Core.BaseEntities;

namespace VeganFit.Core.IBaseRepositories
{
    /// <summary>
    /// Kullanılacak metotları tüm entity'lere göre ayrı ayrı yazmamak için generic metot yöntemiyle interface'leri oluşturuldu.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        /// <summary>
        /// Database'e yeni veri ekleyen ve bu veriyi döndüren metot. (Yapılan işlemin doğrunu kontrol etmek için değer döndürüyoruz.)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TEntity? Create(TEntity entity);

        /// <summary>
        /// Database'deki veriyi güncelleyen ve bu veriyi döndüren metot. (Yapılan işlemin doğrunu kontrol etmek için değer döndürüyoruz.)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TEntity? Update(TEntity entity);

        /// <summary>
        /// Database'deki veri DeletedDate property'sine sahipse o veriyi database'den kaldıran sahip değilse verinin state property'sini Deleted olarak güncelleyen ve sonucu boolean olarak döndüren metot. (Yapılan işlemin doğrunu kontrol etmek için değer döndürüyoruz.)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(TEntity entity);

        /// <summary>
        /// Database'de parametredeki şartı sağlayan verinin olup olmadığını kontrol eden ve sonucu boolean değer döndüren metot.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        bool Any(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// Database'de parametredeki şartı sağlayan ilk veriyi döndüren, şartı sağlayan veri yoksa default değeri (null) döndüren metot.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        TEntity? GetFirstOrDefault(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// Database'de parametredeki şartı sağlayan tüm verilen listesini döndüren metot.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        ICollection<TEntity>? GetAll(Expression<Func<TEntity, bool>> filter = null);

        /// <summary>
        /// Database'de parametredeki şartı sağlayan ilk veriyi döndüren, şartı sağlayan veri yoksa default değeri (null) döndüren metot. (TResult => DTO / VM)
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="orderBy"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        TResult? GetFilteredFirstOrDefault<TResult>(Expression<Func<TEntity, TResult>> select,
                                                    Expression<Func<TEntity, bool>> where,
                                                    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>?
                                                    orderBy = null,
                                                    params Expression<Func<TEntity, object>>[] includes);

        /// <summary>
        /// Database'de parametredeki şartı sağlayan tüm verilen listesini döndüren metot. (TResult => DTO / VM)
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="orderBy"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        ICollection<TResult>? GetFilteredList<TResult>(Expression<Func<TEntity, TResult>> select,
                                                       Expression<Func<TEntity, bool>> where,
                                                       Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>?
                                                       orderBy = null,
                                                       params Expression<Func<TEntity, object>>[] includes);

        /// <summary>
        /// Parametre olarak girilen değerin Id'sini döndüren metot.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        int FindId(Expression<Func<TEntity, bool>> filter,
                   Expression<Func<TEntity, bool>> where,
                   Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>?
                   orderBy = null,
                   params Expression<Func<TEntity, object>>[] includes);
    }
}
