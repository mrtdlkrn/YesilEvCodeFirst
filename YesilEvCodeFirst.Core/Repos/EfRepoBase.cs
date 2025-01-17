﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using YesilEvCodeFirst.Core.Interfaces;

namespace YesilEvCodeFirst.Core.Repos
{
    public abstract class EfRepoBase<TContext, TEntity> :
        IDeletableRepo<TEntity>,
        IInsertableRepo<TEntity>,
        ISelectableRepo<TEntity>,
        IUpdatableRepo<TEntity>
        where TEntity : class
        where TContext : DbContext, new()
    {
        private readonly TContext _context;

        public EfRepoBase(TContext context)
        {
            _context = context;
        }

        public EfRepoBase()
        {
            _context = new TContext();
        }

        public TEntity Add(TEntity item)
        {
            return _context.Set<TEntity>().Add(item);
        }

        public List<TEntity> AddRange(List<TEntity> items)
        {
            return _context.Set<TEntity>().AddRange(items).ToList();
        }

        public TEntity Delete(TEntity item)
        {
            return _context.Set<TEntity>().Remove(item);
        }  
        public bool DeleteRange(List<TEntity> items)
        {
            try
            {
                _context.Set<TEntity>().RemoveRange(items);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public List<TEntity> GetAllWithInclude(string table)
        {
            return _context.Set<TEntity>().Include(table).ToList();
        }
        public List<TEntity> GetByCondition(Func<TEntity, bool> whereCondition)
        {
            return _context.Set<TEntity>().Where(whereCondition).ToList();
        }

        public List<TEntity> GetByConditionWithInclude(Func<TEntity, bool> whereCondition, string table, string table2)
        {
            var result = _context.Set<TEntity>().Include(table).Include(table2).Where(whereCondition).ToList();
            return result;
        }
        public List<TEntity> GetByConditionWithInclude(Func<TEntity, bool> whereCondition, string table, string table2, string table3, string table4)
        {
            var result = _context.Set<TEntity>().Include(table).Include(table2).Include(table3).Include(table4).Where(whereCondition).ToList();
            return result;
        }
        public List<TEntity> GetByConditionWithInclude(Func<TEntity, bool> whereCondition, string table)
        {
            var result = _context.Set<TEntity>().Include(table).Where(whereCondition).ToList();
            return result;
        }

        public TEntity GetByID(object ID)
        {
            return _context.Set<TEntity>().Find(ID);
        }

        public void MySaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.Set<TEntity>().Attach(item);
        }
    }
}
