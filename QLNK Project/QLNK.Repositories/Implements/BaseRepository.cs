using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using QLNK.Repositories.Interfaces;

namespace QLNK.Repositories.Implements
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        private readonly IUnitOfWork _unitOfWork;
        internal DbSet<T> DbSet;
        public BaseRepository(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null) throw new ArgumentNullException(nameof(unitOfWork));
            _unitOfWork = unitOfWork;
            this.DbSet = _unitOfWork.Db.Set<T>();
        }

        /// <summary>
        /// Returns the object with the primary key specifies or throws
        /// </summary>
        /// <param name="primaryKey">The primary key</param>
        /// <returns>The result mapped to the specified type</returns>
        public T Single(object primaryKey)
        {

            var dbResult = DbSet.Find(primaryKey);
            return dbResult;

        }


        /// <summary>
        /// Returns the object with the primary key specifies or the default for the type
        /// </summary>
        /// <param name="primaryKey">The primary key</param>
        /// <returns>The result mapped to the specified type</returns>
        public T SingleOrDefault(object primaryKey)
        {
            var dbResult = DbSet.Find(primaryKey);
            return dbResult;
        }





        //public virtual IEnumerable<T> GetAllWithDeleted()
        //{
        //    var dbresult = _unitOfWork.Db.Fetch<T>("");

        //    return dbresult;
        //}

        public bool Exists(object primaryKey)
        {
            return DbSet.Find(primaryKey) != null;
        }

        public virtual int Insert(T entity)
        {
            dynamic obj = DbSet.Add(entity);
            this._unitOfWork.Db.SaveChanges();
            return obj.Id;

        }

        public virtual T InsertObject(T entity)
        {
            dynamic obj = DbSet.Add(entity);
            this._unitOfWork.Db.SaveChanges();
            return obj;

        }

        public virtual void Update(T entity)
        {
            DbSet.Attach(entity);
            _unitOfWork.Db.Entry(entity).State = EntityState.Modified;
            this._unitOfWork.Db.SaveChanges();
        }
        public virtual bool UpdateResult(T entity)
        {
            DbSet.Attach(entity);
            _unitOfWork.Db.Entry(entity).State = EntityState.Modified;
            if (this._unitOfWork.Db.SaveChanges() > 0)
                return true;
            return false;
        }

        public virtual void Detach(T entity)
        {
            _unitOfWork.Db.Entry(entity).State = EntityState.Detached;
        }
        public int Delete(T entity)
        {
            if (_unitOfWork.Db.Entry(entity).State == EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            dynamic obj = DbSet.Remove(entity);
            this._unitOfWork.Db.SaveChanges();
            return obj.Id;
        }


        public int Delete(object primaryKey)
        {
            T dbResult = DbSet.Find(primaryKey);
            if (_unitOfWork.Db.Entry(dbResult).State == EntityState.Detached)
            {
                DbSet.Attach(dbResult);
            }
            dynamic obj = DbSet.Remove(dbResult);
            this._unitOfWork.Db.SaveChanges();
            return obj.Id;
        }

        public virtual void Deactive(T entity)
        {
            DbSet.Attach(entity);
            _unitOfWork.Db.Entry(entity).State = EntityState.Modified;
            this._unitOfWork.Db.SaveChanges();
        }

        public IUnitOfWork UnitOfWork => _unitOfWork;
        internal DbContext Database => _unitOfWork.Db;

        public Dictionary<string, string> GetAuditNames(dynamic dynamicObject)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return DbSet.AsNoTracking().AsEnumerable().ToList();
        }
       
        internal T GetFirst(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = DbSet.AsNoTracking();
            return query.FirstOrDefault(filter);
        }
        internal IQueryable<T> Get(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>,
                IOrderedQueryable<T>> orderBy = null,
            List<Expression<Func<T, object>>>
                includeProperties = null,
            int? page = null,
            int? pageSize = null)
        {
            IQueryable<T> query = DbSet;

            includeProperties?.ForEach(i => { query = query.Include(i); });

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
                query = orderBy(query);

            if (page != null && pageSize != null)
                query = query
                    .Skip((page.Value - 1) * pageSize.Value)
                    .Take(pageSize.Value);

            return query;
        }
    }
}
