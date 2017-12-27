#region CodeCopyright

// // --------------------------------------------------------------------------------------------------------------------
//  <copyright  file="IEntityBaseRepository.cs" company="kcg, Inc.">
//   *     (C) 1997, 2001-2016, All rights reserved.  
//   *     This software constitutes the trade secrets and confidential  and proprietary information of kcg, Inc.  
//   *     It is intended solely for use by kcg, Inc.  This code may not be copied or redistributed to 
//   *     third parties without prior written authorization from kcg, Inc.
//   *     Create a specific repository class that implements the generic repository T each time a need for a new type of repository is needed
//  </copyright>
//  <summary>
//    The IEntityBaseRepository.cs.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------

#endregion

#region

using System;
using System.Linq;
using System.Linq.Expressions;
using HomeCinema.Entities;

#endregion

namespace HomeCinema.Data.Infrastructure
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> All { get; }

        IQueryable<T> GetAll();

        T GetSingle(int id);

        IQueryable<T> FindBy(Expression<Func<T, bool>> predict);

        void Add(T entity);

        void Delete(T entity);

        void Edit(T entity);
    }
}