using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Core.BaseEntities;
using VeganFit.Core.Enums;
using VeganFit.Core.IBaseRepositories;

namespace VeganFit.DAL.Base.EntityFramework
{
    /// <summary>
    /// Core katmanındaki IBaseRepository interface'ini implement etmek için BaseRepository class'ını açtık. Entity ve Context'lere göre birçok defa tanımlamamak için generic tipte yazdık.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TContext"></typeparam>
    public abstract class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity>
        where TEntity : BaseEntity
        where TContext : DbContext
    {
        protected readonly TContext _db;
        protected readonly DbSet<TEntity> _dbSet;
        //Readonly tanımlı değişkeni salt okunur moduna getirmektedir. Yani readonly olarak tanımlanan bir değişken sadece okunabilmektedir. Setleme işlemi değişkenin oluşturulduğu anda ya da oluşturulan sınıfın constructor metodu içerisinde yapılmaktadır. Çalışma zamanında sadece constructor içerisinde değer ataması yapılabilmektedir. Aksi halde salt okunur bir alana değer atanamaz uyarısı vermektedir.

        public BaseRepository(TContext context)
        {
            _db = context;
            //Dependency injection. _db'yi new'lemeden parametreyi _db'ye atayarak kullandık.

            _dbSet = _db.Set<TEntity>();
        }

        /// <summary>
        /// Database'de parametredeki şartı sağlayan verinin olup olmadığını kontrol eden ve sonucu boolean değer döndüren metot.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public bool Any(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.Any(filter);
        }

        /// <summary>
        /// Database'e yeni veri ekleyen ve bu veriyi döndüren metot. (Yapılan işlemin doğrunu kontrol etmek için değer döndürüyoruz.)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public TEntity? Create(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Added;
            return _db.SaveChanges() > 0 ? entity : null;
        }

        /// <summary>
        /// Database'deki veri DeletedDate property'sine sahipse o veriyi database'den kaldıran sahip değilse verinin state property'sini Deleted olarak güncelleyen ve sonucu boolean olarak döndüren metot. (Yapılan işlemin doğrunu kontrol etmek için değer döndürüyoruz.)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(TEntity entity)
        {
            bool hasProperty = HasOwnProperty(typeof(TEntity), "DeletedDate");
            if (!hasProperty)     //Gevşek silme
            {
                entity.State = State.Deleted;
                TEntity statedEntity = Update(entity);
                return statedEntity != null ? true : false;
            }
            else                  //Tam silme
            {
                _db.Entry(entity).State = EntityState.Deleted;
                return _db.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Parametredeki entity'nin içinde, parametredeki property'nin olup olmadığını kontrol eden ve sonucu boolean olarak döndüren metot.
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private bool HasOwnProperty(Type entityType, string propertyName)
        {
            var properties = entityType.GetProperties();
            bool hasproperty = properties.Any(p => p.Name == propertyName);
            return hasproperty;
        }


        /// <summary>
        /// Database'de parametredeki şartı sağlayan tüm verilen listesini döndüren metot.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public ICollection<TEntity>? GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter != null ? _dbSet.Where(filter).ToList() : _dbSet.ToList();
        }

        /// <summary>
        /// Database'de parametredeki şartı sağlayan ilk veriyi döndüren, şartı sağlayan veri yoksa default değeri (null) döndüren metot. (TResult => DTO / VM)
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="orderBy"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        public TResult? GetFilteredFirstOrDefault<TResult>(Expression<Func<TEntity, TResult>> select,
                                                           Expression<Func<TEntity, bool>> where,
                                                           Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>?
                                                           orderBy = null,
                                                           params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }

            if (includes != null)
            {
                query = query.MyIncludes(includes);
            }

            if (orderBy != null)
            {
                return orderBy(query).Select(select).FirstOrDefault();
            }

            return query.Select(select).FirstOrDefault();
        }

        /// <summary>
        /// Database'de parametredeki şartı sağlayan tüm verilen listesini döndüren metot. (TResult => DTO / VM)
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="orderBy"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        public ICollection<TResult>? GetFilteredList<TResult>(Expression<Func<TEntity, TResult>> select,
                                                             Expression<Func<TEntity, bool>> where,
                                                             Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>?
                                                             orderBy = null,
                                                             params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }
            if (includes != null)
            {
                query = query.MyIncludes(includes);
            }

            if (orderBy != null)
            {
                return orderBy(query).Select(select).ToList();
            }
            else
            {
                return query.Select(select).ToList();
            }
        }

        /// <summary>
        /// Database'de parametredeki şartı sağlayan ilk veriyi döndüren, şartı sağlayan veri yoksa default değeri (null) döndüren metot.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public TEntity? GetFirstOrDefault(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.FirstOrDefault(filter);
        }

        /// <summary>
        /// Database'deki veriyi güncelleyen ve bu veriyi döndüren metot. (Yapılan işlemin doğrunu kontrol etmek için değer döndürüyoruz.)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public TEntity? Update(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            return _db.SaveChanges() > 0 ? entity : null;
        }
    }
}
